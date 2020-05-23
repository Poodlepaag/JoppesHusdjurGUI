using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JoppesHusdjurGUI.Animals
{
    class BabyBunny : Animal
    {
        Random random = new Random();

        public BabyBunny(string _name) : base(_name)
        {
            strength = 1;
            ageYears = 0;
            ageMonths = random.Next(0, 11);
            type = "Kaninunge";
            favoriteFood = "Hö";
            name = _name;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
