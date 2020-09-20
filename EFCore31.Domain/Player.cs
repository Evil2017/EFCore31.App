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
        [Display(Prompt = "队员介绍ID", Name = "简介ID")]
        public int ResumeId { get; set; }

        [Display(Prompt = "队员介绍实体", Name = "简介实体")]
        public Resume Resume { get; set; }

        [Display(Prompt = "输入比赛", Name = "比赛")]
        public List<GamePlayer> GamePlayers { get; set; }
    }
}
