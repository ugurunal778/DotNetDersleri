using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalPrototype
{
    class CounterStrikePlayer
    {
        public int PlayerID { get; set; }
        public string GameName { get; set; }
        public string GameType { get; set; }
        public bool isActive { get; set; }

        public CounterStrikePlayer(int PlayerID,string GameName,string GameType,bool isActive)
        {
            this.PlayerID = PlayerID;
            this.GameName = GameName;
            this.GameType = GameType;
            this.isActive = isActive;
        }
    }
}
