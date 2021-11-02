using BA_SOLID.SRP.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA_SOLID.SRP
{
    class GoodEmployeeProcessor
    {
        Logger logger;
        string log;
        public GoodEmployeeProcessor()
        {
            logger = new Logger();
        }

        //Görüldüğü üzere InsertEmployee sadece veri girişinden sorumlu hale geldi.
        //Son adım olarakta void metotları bool tipine çevirerek ekrana yazdırma işlemini de sınıftan çıkarıyoruz. 
        //Bu yaklaşım unit test  için de faydalıdır.

        public bool InsertEmployee(Employee newEmployee)
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

                log = logger.BuildLog(sb.ToString());
                logger.LogFile(@"C:\EmployeeData.txt",log);
                //


                sb = new StringBuilder();
                sb.Append("Personel Added : ");
                sb.AppendLine();
                sb.Append(newEmployee.FirstName).Append(" ");
                sb.Append(newEmployee.LastName);

                log = logger.BuildLog(sb.ToString());
                logger.LogFile(@"C:\Log.txt", log);

                return true;
            }
            catch (Exception ex)
            {
                sb = new StringBuilder();
                sb.Append("Hata Mesajı :");
                sb.AppendLine();
                sb.Append(ex.Message);

                log = logger.BuildLog(sb.ToString());
                logger.LogFile(@"C:\Log.txt", log);

                return false;
            }


        }
    }
}
