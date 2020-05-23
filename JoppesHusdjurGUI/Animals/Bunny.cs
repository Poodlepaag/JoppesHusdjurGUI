using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JoppesHusdjurGUI.Animals
{
    class Bunny : Animal
    {
        Random random = new Random();

        public Bunny(string _name) : base(_name)
        {
            strength = 2;
            ageYears = random.Next(1, 18);
            ageMonths = random.Next(0, 11);
            type = "Kanin";
            favoriteFood = "Hö";
            name = _name;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
