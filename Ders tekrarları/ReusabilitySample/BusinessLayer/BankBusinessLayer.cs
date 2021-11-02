using System.Collections.Generic;
using System.Linq;

namespace BusinessLayer
{
    public class BankBusinessLayer
    {
        private List<Salary> salaries = new List<Salary>()              //Salary class'ında salaries adında yeni bir liste oluştur.
        {
            new Salary(){FullName="Ercan Uykan", Id=1,SalaryTotal=100},     //bilgileri ile Salary elemanını oluştur 
            new Salary(){FullName="Levent Sendinc", Id=2,SalaryTotal=50},   //bilgileri ile Salary elemanını oluştur 
        };

        public bool ParaYatir(int fromId, int toId, decimal salary)     //parrayatırma kısmında çalışacak metod
        {
            var fromData = salaries.FirstOrDefault(x => x.Id == fromId);    //salaries'in değeri id'sinden büyükse fromid ile eşitle
            var transferValidation = fromData.SalaryTotal - salary >= 0;    //fromData'nın salaryTotal'inden salary çıkarıldığı zaman sonuç 0'dan büyük veya eşit ise transferValidation'a ata
            if (transferValidation)                                         //eğer transferValidation True ise
            {
                BakiyeGuncelle(fromId, -salary);                                //fromId ve - salary'ye göre BakiyeGuncelle metodunu çalıştır
                BakiyeGuncelle(toId, +salary);                                  //toId ve +salary'ye göre BakiyeGuncelle metodunu çalıştır
                return true;                                                    //true dön ve metoddan çık
            }
            else                                                            //değilse
            {
                return false;                                                   //false dön ve metoddan çık
            }
        }

        private void BakiyeGuncelle(int id, decimal salary)             //id ve salary değerine göre metodu çalıştır
        {
            var customer = salaries.FirstOrDefault(x => x.Id == id);        //salaries'in değeri Id'sinden büyükse id ile eşitle ve customer'a ata
            customer.SalaryTotal += salary;                                 //cuystomer'ın salaryTotal'ini salary ile topla ve salary'ye eşitle
        }
    }
}