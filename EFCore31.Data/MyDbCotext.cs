using EFCore31.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace EFCore31.Data
{
    public class MyDbCotext : DbContext
    {
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    base.OnConfiguring(optionsBuilder);
        //    //optionsBuilder.UseSqlServer("Data source=(localdb)\\MSSQLLocalDB; initial Catalog=EFCore31  ");
        //}
        public MyDbCotext(DbContextOptions<MyDbCotext> options)
            : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<GamePlayer>().HasKey(x => new
            {
                x.GameId,
                x.PlayerId
            });
            modelBuilder.Entity<Resume>()
                .HasOne(x => x.Player)
                .WithOne(x => x.Resume)
                .HasForeignKey<Resume>(x => x.PlayerId);
        }
        public DbSet<Game> Games { get; set; }
        public DbSet<Resume> Resumes { get; set; }
        public DbSet<Player> players { get; set; }
        public DbSet<League> Leagues { get; set; }
        public DbSet<Club> Clubs { get; set; }
 
    }
}
