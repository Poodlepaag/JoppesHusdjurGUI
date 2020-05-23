using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace JoppesHusdjurGUI
{
    class Animal
    {
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
            int _energyLevel = random.Next(0, 100);
            int _happinessLevel = random.Next(0, 100);
            int _hungerLevel = random.Next(0, 100);

            energyLevel = _energyLevel;
            happinessLevel = _happinessLevel;
            hungerLevel = _hungerLevel;
        }

        public int GetEnergyLevel()
        {
            return energyLevel;
        }

        public int GetHappinessLevel()
        {
            return happinessLevel;
        }

        public int GetHungerLevel()
        {
            return hungerLevel;
        }

        public string GetName()
        {
            return name;
        }

        public string GetAge()
        {
            return string.Format($"{ageYears} år och {ageMonths} månader");
        }

        public string GetType()
        {
            return type;
        }

        public string GetFavoriteFood()
        {
            return favoriteFood;
        }

        public override string ToString()
        {
            return string.Format($"{name}, {type}");
        }
    }
}
