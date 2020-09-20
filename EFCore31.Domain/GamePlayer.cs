using System.Collections.Generic;

namespace EFCore31.Domain
{
    public class GamePlayer
    {
        public GamePlayer()
        {
            GamePlayers = new List<GamePlayer>();
        }
        public int PlayerId { get; set; }
        public int GameId { get; set; }
        public List<GamePlayer> GamePlayers { get; set; }

    }
}
