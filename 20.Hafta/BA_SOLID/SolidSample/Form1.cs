using BA_SOLID.DIP.Bad;
using BA_SOLID.DIP.Validated.Abstract;
using BA_SOLID.DIP.Validated.Concrete;
using BA_SOLID.OCP;
using BA_SOLID.OCP.Validated;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolidSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BadRestaurant badrestaurant = new BadRestaurant();
          
            Restaurant restaurant = new Restaurant(
                new List<IProduct>() {
                    new Fish(),
                    new Poultry(),
                    new Fish(),
                    new Poultry()
                }
            );
            badrestaurant.GenerateInstructions();
            var goodınstructions = restaurant.GenerateInstructions();;

            BadCoffee badCoffee = new BadCoffee();

            badCoffee.GetTotalPrice(10, CoffeeType.Espresso);

            Espresso espresso = new Espresso();
            espresso.GetTotalPrice(10);


        }
    }
}
