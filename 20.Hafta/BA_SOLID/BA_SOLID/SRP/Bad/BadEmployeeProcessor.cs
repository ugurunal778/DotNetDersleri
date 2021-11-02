using BA_SOLID.SRP.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA_SOLID.SRP.Bad
{
    class BadEmployeeProcessor
    {

        //Alttaki işlemlere bakarsak, sınıf içerisinde çalışan ekleme kodumuzda birden fazla iş yapıldığını görebilmekteyiz. 
        //Hem ekleme, hemde log işlemleri bir arada gitmektedir. Alttaki kod bu nedenle Single Responsibility prensibimize ters düşmektedir.

        //Alttaki yöntemde, Loglama ile ilgili bir süreç değiştiğinde, sınıflara müdahale etmemiz gereklidir.(Farklı bir dosya, farklı yol veya farklı bir loglama çeşidi olabilir.)
        //Bu durumlar projenin genişletilebilir olmasını engeller, hata riskini arttırır.

        //Bunun yanında tamamen SRP üzerinden gidersek, konsole yazma işlemi de bu sınıfta yer almamalıdır. 
        //Platform değişiklikleri veya kullanıcı bilgilendirme işlemlerinde yaşanacak değişiklik aynı şekilde sınıfın çalışmasını bozacaktır.

        public void InsertEmployee(Employee newEmployee)
        {

            StringBuilder sb = new StringBuilder();
            try
            {
                sb.Append(newEmployee.Id);
                sb.AppendLine();
                sb.Append(newEmployee.FirstName);
                sb.AppendLine();
                sb.Append(newEmployee.LastName);
                sb.AppendLine();
                sb.Append(newEmployee.HireDate);
                File.WriteAllText(@"C:\EmployeeData.txt", sb.ToString());

                sb = new StringBuilder();
                sb.Append("Kayıt Eklenme Tarihi :");
                sb.Append(DateTime.Now.ToString());
                sb.AppendLine();
                sb.Append("Personel ID: ");
                sb.Append(newEmployee.FirstName).Append(" ");
                sb.Append(newEmployee.LastName);
                File.WriteAllText(@"C:\Log.txt", sb.ToString());

                Console.WriteLine("Çalışan Başarıyla Kaydedildi!");
            }
            catch (Exception ex)
            {
                sb = new StringBuilder();
                sb.Append("Hata Tarihi :");
                sb.Append(DateTime.Now.ToString());
                sb.AppendLine();
                sb.Append("Hata Mesajı :");
                sb.Append(ex.Message);
                File.WriteAllText(@"C:\Log.txt", sb.ToString());

                Console.WriteLine("Hata!");

            }


        }
    }
}
