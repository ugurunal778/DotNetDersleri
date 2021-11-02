using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
   public class BasePhone
    {
        public int id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public decimal UnitPrice { get; set; }
        public virtual void CallSound()
        {
          using(SoundPlayer player = new SoundPlayer(Environment.CurrentDirectory+ @"\..\..\Sounds\default.wav"))
            {
                player.PlaySync();
            }
        }




    }

}
