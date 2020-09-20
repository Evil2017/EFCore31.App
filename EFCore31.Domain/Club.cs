using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCore31.Domain
{
    public class Club
    {
        public Club()
        {
            Players = new List<Player>();
        }
        [Description("主键")]
        public int Id { get; set; }

        [Description("姓名")]
        [MaxLength(100)]
        public string Name { get; set; }
        [Description("城市")]
        [MaxLength(100)]
        public string City { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime DateofEstablishment { get; set; }
        [MaxLength(100)]
        [DisplayName("历史")]
        public string History { get; set; }

        public League league { get; set; }

        public List<Player> Players { get; set; }
    }
}
