using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JoppesHusdjurGUI.Animals
{
    class Cat : Animal
    {
        Random random = new Random();

        public Cat(string _name) : base(_name)
        {
            ageYears = random.Next(1, 18);
            ageMonths = random.Next(0, 11);
            type = "Katt";
            favoriteFood = "Fisk";
            name = _name;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
