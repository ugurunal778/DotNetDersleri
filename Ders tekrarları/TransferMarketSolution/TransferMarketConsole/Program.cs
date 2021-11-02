using System;
using BusinessLayer;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferMarketConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            ClubBusinessLayer clubBusinessLayer = new ClubBusinessLayer();
            clubBusinessLayer.Create(new DataTransferObject.ClubDto()
            {
                Name = "Besiktas Jimnastik Klubu",
                ColorOfJoursey = "Siyah Beyaz",
                CreatedON = DateTime.Now,
                EstablishDate = new DateTime(1903, 03, 19),
                IsActive = true,
                JerseyUrl = "/DummyUrl",
                ManagerId = 1,
                ModifiedOn = DateTime.Now,
                StadiumID = 1
            }); ;
        }
    }
}