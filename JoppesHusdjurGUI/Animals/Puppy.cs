using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JoppesHusdjurGUI.Animals
{
    class Puppy : Dog
    {
        Random random = new Random();

        public Puppy(string _name) : base(_name)
        {
            ageYears = 0;
            ageMonths = random.Next(0, 11);
            type = "Hundvalp";
            favoriteFood = "Köttben";
            name = _name;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
