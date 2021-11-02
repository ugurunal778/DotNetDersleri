using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralChainOfResponsibilities
{
    public abstract class PlayerHandler
    {
        protected PlayerHandler _SonrakiHandler;
        public PlayerHandler SonrakiHandler { set { _SonrakiHandler = value; } }

        public abstract void Play(string filePath);
    }
}
