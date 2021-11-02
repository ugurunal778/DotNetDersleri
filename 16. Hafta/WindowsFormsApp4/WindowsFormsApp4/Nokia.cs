using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    public class Nokia : BasePhone
    {
        public virtual void CallSound()
        {
            using (SoundPlayer player = new SoundPlayer(Environment.CurrentDirectory + @"https://www.youtube.com/watch?v=YQBBvvllwEo&list=RDYQBBvvllwEo&start_radio=1"))
            {
                player.PlaySync();
            }
        }
    }
}
