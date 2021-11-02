using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    public class Samsung : BasePhone
    {
        public virtual void CallSound()
        {
            using (SoundPlayer player = new SoundPlayer(Environment.CurrentDirectory + @"\..\..\Sounds\samsung.wav"))
            {
                player.PlaySync();
            }
        }
    }
}
