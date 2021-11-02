using CreationalBuilder.Vehicle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            
            Builder tasarım deseni creational grubuna aittir. Uluslar arası standartta hangi tasarım deseninin en fazla kullanıldığını gösteren dofactory.com a göre kullanım oranı %40 civarındadır. Builder tasarım deseninin esas amacı genişletilebilirliği sağlamak ve kod karmaşıklığını engellemek için kullanılır. Tam olarak çalışma prensibi ise bazı nesneler birden fazla nesnenin birleşmesinden meydana gelir. Zamanla bu asıl nesneyi oluşturan nesnelerde değişiklik meydana gelebilir ya da ek nesneler ile genişletilmek istenebilir. Bu esas sınıfları yaratmak isteyen sınıfa Builder denir. 

            Builder desenini oluşturan 4 alt yapı vardır.
            Product: Oluşturulan nesne.
            Builder: Product oluşturacak nesnelerin (Concrete Builder) uygulaması gereken arayüz.
            Concrete Builder: Product nesnesini oluşturan nesne veya özelliklerin oluşturulduğu sınıflar. Her concrete builder sınıfı aynı arayüzde farklı bir ürünün oluşturulmasını sağlar.
            Director: Verilen builder nesnesine göre product örneği oluşturur.

             */


            //KrediKartiBuilder gercekKart = new AmericanExpressConcreteBuilder();
            //KrediKartiKullan kullan = new KrediKartiKullan();
            //kullan.KartKullan(gercekKart);

            //Console.WriteLine(gercekKart.Kart.ToString());

            //Console.WriteLine("--**--**--**--**--**--**--**");

            //gercekKart = new VisaConcreteBuilder();
            //kullan.KartKullan(gercekKart);

            //Console.WriteLine(gercekKart.Kart.ToString());
            //Console.ReadLine();

            VehicleBuilder vehicle = new JaguarConcreteBuilder();
            VehicleBuilder vehicleBMW = new BMWConcreteBuilder();

            VehicleUse vehicleUse = new VehicleUse();
            vehicleUse.UseVehicle(vehicle);
            vehicleUse.UseVehicle(vehicleBMW);

            Console.WriteLine(vehicle.Vehicle.ToString());
            Console.WriteLine(vehicleBMW.Vehicle.ToString());
            Console.ReadLine();

        }
    }
}
