using BA_SOLID.SRP;
using BA_SOLID.SRP.Bad;
using BA_SOLID.SRP.Model;
using BA_SOLID.OCP.Validated;
using BA_SOLID.LSP;
using BA_SOLID.LSP.Validated;
using BA_SOLID.LSP.Bad;
using BA_SOLID.ISP;
using BA_SOLID.ISP.Bad;
using BA_SOLID.ISP.Validated;
using BA_SOLID.DIP;
using BA_SOLID.DIP.Validated;
using BA_SOLID.DIP.Bad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA_SOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            //SOLID Prensipleri => Solid , beş önemli OOP prensiplerinin kısaltmasıdır.
            //Temiz, modüler ve genişletilebilir kod yazımında önemli kuralları tanımlar.
            //Aynı zamanda Agile/Adaptive yazılım geliştirme için gereklidir.
            //AÇIKLAMA.TXT DOSYASINA BAKMAYI UNUTMAYINIZ!

            //-----------------------------------------------------------------
            //SRP => Single Responsibility Principle
            //Bir class sadece bir iş yapıyor olmalı.

            //Employee newEmployee = new Employee();
            //newEmployee.Id = 1;
            //newEmployee.FirstName = "Bilge";
            //newEmployee.LastName = "Adam";
            //newEmployee.HireDate = new DateTime(1997, 1, 1);

            //GoodEmployeeProcessor processor = new GoodEmployeeProcessor();
            //Console.WriteLine(processor.InsertEmployee(newEmployee) ? "Başarılı!" : "Hata!");
            //Console.ReadKey();

            //-----------------------------------------------------------------
            //OCP => Open/Closed Principle
            //Sınıflar ve metotlar genişletmeye açık, değişikliğe kapalı olmalıdır.
            //Her ihtiyaç değiştiğinde, yazdığımız kodu değiştirmek zorunda kalmamak, işlerimizi uzun vadede çok kolaylaştıracaktır.

            //GoodCoffee kahve1 = new Espresso();
            //GoodCoffee kahve2 = new Macchiato();
            //GoodCoffee kahve3 = new Latte();

            //List<GoodCoffee> coffies = new List<GoodCoffee>();
            //coffies.Add(kahve1);
            //coffies.Add(kahve2);
            //coffies.Add(kahve3);

            //double price = 0;

            //foreach (var item in coffies)
            //{
            //    price += item.GetTotalPrice(3);
            //}

            //Console.WriteLine("Kahve Fiyatı : " + price);

            //Console.ReadKey();

            //-----------------------------------------------------------------
            //LSP => Liskov Subtution Principle
            //Bir sınıftan türetilen sınıflar, base sınıfın yerine de kullanılabilmelidir.
            //Bu örnek için Square ve Rectangle sınıflarına bakıyoruz.
            //AreaCalculator sınıfı üzerinden alan hesaplama testi yapalım.

            //BadRectangle rectangle = new BadRectangle();
            //rectangle.Width = 2;
            //rectangle.Height = 3;

            //İstenirse, bu noktada Assertion için Unit Test örneği de yapılabilir.

            //if (BadAreaCalculator.CalculateArea(rectangle) !=6)
            //{
            //    Console.WriteLine("Dörtgen Alan Hesaplamasında Hatalı İşlem!");
            //}

            //Square için deniyoruz.
            //BadSquare square = new BadSquare();
            //square.Height = 3;


            //if (BadAreaCalculator.CalculateArea(square)!=9)
            //{
            //    Console.WriteLine("Kare Alan Hesaplamasında Hatalı İşlem!");
            //}

            //Üstteki testlerde bir hata alınmayacaktır. Şimdi yerlerini değiştirelim.

            //BadRectangle newRectangle = new BadSquare(); //Square 
            //newRectangle.Height = 4;
            //newRectangle.Width = 6;

            //if (BadAreaCalculator.CalculateArea(newRectangle)!=24)
            //{
            //    Console.WriteLine("Hata!");
            //}

            //Üstteki kod hata verecektir.
            //Validated klasöründe oluşturduğumuz sınıflarımızla tekrar deniyoruz.

            //Rectangle rectangle = new Rectangle();
            //rectangle.Width = 2;
            //rectangle.Height = 3;
            //if (rectangle.RectangleArea() != 6)
            //{
            //    Console.WriteLine("Dörtgen Alan Hesaplamasında Hatalı İşlem!");
            //}

            //Square square = new Square();
            //square.Width = 4;
            //if (square.SquareArea() != 16)
            //{
            //    Console.WriteLine("Kare Alan Hesaplamasında Hatalı İşlem!");
            //}


            //-----------------------------------------------------------------

            //ISP => Interface Segregation Principle
            //Sınıflar ihtiyaçları olmayan özellik ve davranışları içeren interfaceleri almamalıdır.
            //Bu örnek için ISP Klasörüne bakıyoruz.





            //DIP => Dependency Inversion Principle
            //Üst seviye sınıflar alt seviye sınıflara bağımlı olmamalıdır.
            //Bu örnek için DIP klasörüne bakabilirsiniz.



            Console.ReadKey();



        }
    }
}