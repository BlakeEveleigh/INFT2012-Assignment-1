using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlakeEastwoodAssgt
{
    public class GameInfo
    {
        private int playerCount;
        private int aiCount;
        private int totalPlayers;
        
        public GameInfo()
        {

        }

        public int PlayerCount
        {
            get
            {
                return playerCount;
            }
            set
            {
                playerCount = value;
            }
        }

        public int AiCount
        {
            get { return aiCount; }
            set { aiCount = value; }
        }
        public int TotalPlayers
        {
            get { return totalPlayers; }
            set { totalPlayers = value; }
        }

    }
    
    
}
