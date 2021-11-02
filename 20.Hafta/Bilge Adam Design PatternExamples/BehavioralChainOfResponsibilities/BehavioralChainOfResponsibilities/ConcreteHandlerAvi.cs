using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralChainOfResponsibilities
{
    public class ConcreteHandlerAvi : PlayerHandler
    {
        public override void Play(string filePath)
        {
            /*.avi uzantılı dosya ise bu sınıf cevap verir*/
            if (filePath.EndsWith(".avi"))
                Console.WriteLine("{0} dosyası oynatılıyor(avi player)...", filePath);
            else /*isteğe cevap verebilecek son sınıf bu olduğundan .avi uzantılı değil ise hata ver*/
                Console.WriteLine("{0} Geçersiz Dosya Formatı", filePath);

        }
    }
}
