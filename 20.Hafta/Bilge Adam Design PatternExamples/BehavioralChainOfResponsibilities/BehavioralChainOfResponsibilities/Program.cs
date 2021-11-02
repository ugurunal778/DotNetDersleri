using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralChainOfResponsibilities
{
    class Program
    {
        /*
         
            Chain of Responsibility (Sorumluluk Zinciri) tasarım deseni behavior grubununa ait, bir isteğin belli sınıflar içinde gezdirilerek ilgili sınıfın işlem yapmasını yöneten tasarım desenidir. Chain of responsibility tasarım deseninin uluslar arası kullanıma göre kullanım sıklığı 40% lardadır. 

            Chain of responsibility tasarım deseni; bir isteğin duruma göre farklı şekillerde işlem yapılması gereken durumlarda kullanılır. Bu tasarım deseninde isteğe cevap verebilecek sınıflar aynı arayüzü kullanır ve isteğin durumuna göre ya cevap verir ya da isteği zincirdeki sonraki nesneye gönderir.
             
            Handler: İsteği işleyebilecek sınıfların uygulaması gereken interface veya abstract sınıftır. Yani zincirdeki bütün halkalar bu arayüzü uygulamak zorundadır. Bu arayüzde kendisini gösteren bir property ve isteğe cevap verebilecek bir metot tanımlı olur.

            ConcreteHandler: İsteğe cevap verebilecek (veya sonraki nesneye yönlendirebilecek) gerçek sınıflardır. Bu sınıfların hepsi Handler olarak tanımlanan arayüzü uygulamak zorundadır.

            Client: Zincirin oluşturan ve zincirin ilk halkasına isteği gönderen nesnedir.
             */
        static void Main(string[] args)
        {

            /*zinciri oluşturacak halkaları tanımlıyoruz*/
            PlayerHandler mp4Player = new ConcreteHandlerMp4();
            PlayerHandler mpgPlayer = new ConcreteHandlerMpg();
            PlayerHandler aviPlayer = new ConcreteHandlerAvi();

            /*Zincirin halkalarını sıralıyoruz */
            /*İstek hangi sıra ile ConcreteHandler sınıflarına iletileceğini belirliyoruz*/
            mp4Player.SonrakiHandler = mpgPlayer;
            mpgPlayer.SonrakiHandler = aviPlayer;

            /*İstekleri zincirin ilk halkasına ygönderiyoruz*/
            mp4Player.Play("video.mpg");
            mp4Player.Play("video.avi");
            mp4Player.Play("video.mp4");
            mp4Player.Play("video.swf");

            Console.ReadLine();

        }
    }
}
