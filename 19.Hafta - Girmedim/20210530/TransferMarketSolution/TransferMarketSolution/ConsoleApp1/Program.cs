using BusinessLayer;
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
            Console.WriteLine("Hello World!");
            ClubBusinessLayer clubBusinessLayer = new ClubBusinessLayer();
            clubBusinessLayer.Create(new DataTransferObjectLayer.ClubDto()
            {
                Name = "Beşiktaş Jimnastik Klubü",
                ColorOfJersey = "Siyah Beyaz",
                CreatedOn = DateTime.Now,
                EstablishDate = new DateTime(1903, 03, 19),
                IsActive = true,
                JerseyUrl = "/DummyUrl",
                ManagerId = 1,
                ModifiedOn = DateTime.Now,
                StadiumId = 1

            }); ;
        }
    }
}
