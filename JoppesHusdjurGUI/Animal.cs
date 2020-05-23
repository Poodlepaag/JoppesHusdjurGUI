using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace JoppesHusdjurGUI
{
    class Animal
    {
        protected int strength;
        protected int ageYears;
        protected int ageMonths;
        protected string name;
        protected string type;
        protected string favoriteFood;
        protected int energyLevel;
        protected int happinessLevel;
        protected int hungerLevel;

        Random random = new Random();

        public Animal(string _name)
        {
            energyLevel = random.Next(0, 100);
            happinessLevel = random.Next(0, 100);
            hungerLevel = random.Next(0, 100);
        }

        public int EnergyLevel
        {
            get { return energyLevel; }
            set { energyLevel = value; }
        }

        public int HappinessLevel
        {
            get { return happinessLevel; }
            set { happinessLevel = value; }
        }

        public int HungerLevel
        {
            get { return hungerLevel; }
            set { hungerLevel = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string PrintAge()
        {
            return string.Format($"{ageYears} år och {ageMonths} månader");
        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public string FavoriteFood
        {
            get { return favoriteFood; }
            set { favoriteFood = value; }
        }

        public int Strength
        {
            get { return strength; }
        }

        public int AgeYears
        {
            get { return ageYears; }
            set { ageYears = value; }
        }

        public int AgeMonths
        {
            get { return ageMonths; }
            set { ageMonths = value; }
        }

        public override string ToString()
        {
            return string.Format($"{name}, {type}");
        }
    }
}
