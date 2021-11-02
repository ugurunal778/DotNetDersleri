using System.Collections.Generic;
using System.Linq;

namespace BusinessLayer
{
    public class BankBusinessLayer
    {
        private List<Salary> salaries = new List<Salary>()
        {
            new Salary(){FullName="Ercan Uykan",Id=1,SalaryTotal=100},
            new Salary(){FullName="Levent Sendinç",Id=2,SalaryTotal=50},
        };


        public bool ParaYatir(int fromId, int toId, decimal salary)
        {
            var fromData = salaries.FirstOrDefault(x => x.Id == fromId);
            var transferValidationResult = fromData.SalaryTotal - salary >= 0;

            if (transferValidationResult)
            {
                BakiyeGüncelle(fromId, -salary);
                BakiyeGüncelle(toId, +salary);
                return true;
            }
            else
            {
                return false;
            }
        }

        private void BakiyeGüncelle(int id, decimal salary)
        {
            var customer = salaries.FirstOrDefault(x => x.Id == id);
            customer.SalaryTotal += salary;
        }
    }
}
