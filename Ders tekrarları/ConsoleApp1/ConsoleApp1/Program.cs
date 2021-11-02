using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            -Get the parameters
            -Check the parameters
            -Calculate
            */

            string firstParam = getParameter("1");
            int firstnumber = checkParameter(firstParam, 1);
            string secondParam = getParameter("2");
            int secondNumber = checkParameter(secondParam, 2);
            calculate(firstnumber, secondNumber);
        }

        private static string getParameter(string parameterCount)
        {
            Console.WriteLine(parameterCount + ". parametreyi giriniz.");
            return Console.ReadLine();
        }

        private static int checkParameter(string parameter, int countOfParameter)
        {
            try
            {
                int param = Convert.ToInt32(parameter);
                if (countOfParameter == 2 && countOfParameter == 0)
                {
                    Console.WriteLine(countOfParameter + ". parametreyi 0 girdiniz programi kapatin");
                    Console.ReadLine();
                    Environment.Exit(0);
                }
                return param;
            }
            catch (Exception ex)
            {
                Console.WriteLine(countOfParameter + ". parametreyi hatali girdiniz programi kapatip tekrardan deneyiniz. mesaj: " + ex.Message);
                Console.ReadLine();
                Environment.Exit(0);
                return 0;
            }
        }

        private static void calculate(int firstNumber, int secondNumber)
        {
            int sumResult = firstNumber + secondNumber;
            int multipleResult = firstNumber * secondNumber;
            int subtructionResult = firstNumber - secondNumber;
            decimal divideResult = Convert.ToDecimal(firstNumber) / secondNumber;

            Console.WriteLine("birinci girilen deger: " + firstNumber);
            Console.WriteLine("ikinci girilen deger: " + secondNumber);
            Console.WriteLine("toplama sonucu: " + sumResult);
            Console.WriteLine("cikartma sonucu: " + subtructionResult);
            Console.WriteLine("carpma sonucu: " + multipleResult);
            Console.WriteLine("bolme sonucu: " + divideResult);
            Console.ReadLine();
        }
    }
}
