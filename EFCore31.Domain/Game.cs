using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCore31.Domain
{
    public class Game
    {
        public Game()
        {
            GamePlayers = new List<GamePlayer>();
        }
        public int Id { get; set; }

       //    [Display(Prompt = "第几轮", Description = "是几次赛次", Name = "轮次")]
        public int Round { get; set; }

        [Display(Prompt = "比赛开始时间", Name = "开始时间")]
        public DateTimeOffset? StartTime { get; set; }

        public List<GamePlayer> GamePlayers { get; set; }
    }
}
