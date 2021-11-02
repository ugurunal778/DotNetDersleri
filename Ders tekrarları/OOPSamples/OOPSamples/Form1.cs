using OOPSamples.Models;
using OOPSamples.Vehicles;
using OOPSamples.ExtensionMethod;
using System;
using System.Windows.Forms;

namespace OOPSamples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Engineer engineer = new Engineer();
            engineer.Name = "Ugur";
            engineer.Age = 25;
            engineer.BirthDate = DateTime.Now;
            engineer.Company = "asdasd";
            engineer.Height = 1.82f;
            engineer.Weight = 91.9f;
            engineer.IsMan = true;
            engineer.Speciality = "Electronic";
            engineer.TypeOfField = "Electrionic";

            Teacher teacher = new Teacher();
            teacher.Name = "Ugur";
            teacher.Age = 25;
            teacher.BirthDate = DateTime.Now;
            teacher.Height = 1.82f;
            teacher.Weight = 91.9f;
            teacher.IsMan = true;
            teacher.TypeOfField = "Electrionic";

            Boeing_737_800 boeing_737_800 = new Boeing_737_800();
            boeing_737_800.Isfly = true;
            boeing_737_800.Brand = "Boeing";
            boeing_737_800.Color = "Black";
            boeing_737_800.TailNumber = "TC 1345";
            boeing_737_800.TypeOfFuel = "JetFuel";
            boeing_737_800.CountOfCrew = 10;
            boeing_737_800.CountOfMotors = 2;
            boeing_737_800.CountOfPassenger = 96;
            boeing_737_800.HorsePower = 1500;
            boeing_737_800.Run();

            RenaultMegane renaultMegane = new RenaultMegane();
            renaultMegane.HorsePower = 80;
            renaultMegane.Isfly = false;
            renaultMegane.MaxSpeed = 250;
            renaultMegane.NumberOfCyclinder = 4;
            renaultMegane.TypeOfFuel = "Diesel";
            renaultMegane.CyclinderVolume = 1500;
            renaultMegane.Run();

            int value = 10;
            string strValue = null;
            strValue = value.GetMod().ToString();
            MessageBox.Show("Bolum'den kalan: " + strValue);
        }
    }
}
