using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JoppesHusdjurGUI.Animals
{
    class Kitten : Cat
    {
        Random random = new Random();

        public Kitten(string _name) : base(_name)
        {
            ageYears = 0;
            ageMonths = random.Next(0, 11);
            type = "Kattunge";
            favoriteFood = "Fisk";
            name = _name;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
