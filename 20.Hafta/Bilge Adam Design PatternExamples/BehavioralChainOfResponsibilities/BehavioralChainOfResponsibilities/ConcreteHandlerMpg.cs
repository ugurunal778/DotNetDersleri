using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralChainOfResponsibilities
{
    public class ConcreteHandlerMpg : PlayerHandler
    {
        public override void Play(string filePath)
        {
            /*.mpg uzantılı dosya ise bu sınıf cevap verir*/
            if (filePath.EndsWith(".mpg"))
                Console.WriteLine("{0} dosyası oynatılıyor(mpg player)...", filePath);
            else
            {
                /*.mpg uzantılı dosya değil ise _SonrakiHandler a isteği gönder*/
                if (_SonrakiHandler != null)
                    _SonrakiHandler.Play(filePath);
            }
        }
    }
}
