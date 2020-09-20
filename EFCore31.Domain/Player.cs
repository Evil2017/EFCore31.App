using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCore31.Domain
{
    public class Player
    {
        public Player()
        {
            GamePlayers = new List<GamePlayer>();
        }
        public int Id { get; set; }
        [Display(Name = "姓名")]
        [Required, MaxLength(100)]
        public string Name { get; set; }
        [Display(Prompt = "输入出生日期", Name = "生日")]
        [Column(TypeName = "date")]
        public DateTime DateOfBirth { get; set; }
        public int ResumeId { get; set; }
        public Resume Resume { get; set; }
        public List<GamePlayer> GamePlayers { get; set; }
    }
}
