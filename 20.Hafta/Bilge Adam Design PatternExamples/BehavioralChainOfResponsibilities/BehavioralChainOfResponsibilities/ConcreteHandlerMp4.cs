using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralChainOfResponsibilities
{
    public class ConcreteHandlerMp4 : PlayerHandler
    {
        public override void Play(string filePath)
        {
            /*.mp4 uzantılı dosya ise bu sınıf cevap verir*/
            if (filePath.EndsWith(".mp4"))
                Console.WriteLine("{0} dosyası oynatılıyor(mp4 player)...", filePath);
            else
            {
                /*.mp4 uzantılı dosya değil ise _SonrakiHandler a isteği gönder*/
                if (_SonrakiHandler != null)
                    _SonrakiHandler.Play(filePath);
            }
        }
    }
}
