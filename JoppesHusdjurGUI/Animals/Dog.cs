using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JoppesHusdjurGUI.Animals
{
    class Dog : Animal
    {
        Random random = new Random();

        public Dog(string _name) : base (_name)
        {
            strength = 3;
            ageYears = random.Next(1, 18);
            ageMonths = random.Next(0, 11);
            type = "Hund";
            favoriteFood = "Köttben";
            name = _name;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
