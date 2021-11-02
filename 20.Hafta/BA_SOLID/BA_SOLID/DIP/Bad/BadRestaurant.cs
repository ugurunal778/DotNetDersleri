using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BA_SOLID.DIP.Bad
{
    public class BadRestaurant
    {

        //Restaurant sınıfı high-level bir modüldür. 
        //Yalnız low-level modüllerden fish ve poultry sınıflarına bağımlılığı vardır. 
        //Dependency inversion prensibine göre değişiklikleri gerçekleştirelim.


        private BadFish tuna = new BadFish();
        private BadPoultry duck = new BadPoultry();
        private BadCow cow = new BadCow();
        private BadSnake snake = new BadSnake();


        public string GenerateInstructions()
        {
            return snake.GetFishCookingInstructions()+" "+tuna.GetFishCookingInstructions() + " " + duck.GetPoultryCookingInstructions() + " " + cow.GetFishCookingInstructions();
        }

    }
}