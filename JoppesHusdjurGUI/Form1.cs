using JoppesHusdjurGUI.Animals;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace JoppesHusdjurGUI
{
    public partial class JoppesHusdjurGUI : Form
    {
        int ballCount = 0;
        string chosenName;

        public JoppesHusdjurGUI()
        {
            InitializeComponent();

            // Add items to the foodList
            foodList.Items.Add("Köttben");
            foodList.Items.Add("Fisk");
            foodList.Items.Add("Hö");
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }

        private void buttonAddToy_Click(object sender, EventArgs e)
        {
            ballCount++;
            Ball ball = new Ball(ballCount);
            toyList.Items.Add(ball);
            textBoxActivities.Text += $"\r\n{ball} tillagd!\r\n";

        }

        private void toyList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ball ball = (Ball)toyList.SelectedItem;

            if (ball == null)
            {
                qualityBar.Value = 0;
            }
            else
            {
                qualityBar.Value = ball.Quality;
            }
        }

        private void buttonRemoveToy_Click(object sender, EventArgs e)
        {

            Ball ball = (Ball)toyList.SelectedItem;

            if (toyList.Items.Count == 0)
            {
                textBoxActivities.Text += "\r\nDet finns inga bollar i listan\r\n";
            }
            else if (toyList.SelectedItem == null)
            {
                textBoxActivities.Text += $"\r\nIngen boll är vald! Markera en boll i listan och försök igen!\r\n";
            }
            else
            {
                qualityBar.Value = 0;
                toyList.Items.Remove(toyList.SelectedItem);
                textBoxActivities.Text += $"\r\n{ball} borttagen ur listan!\r\n";
            }
        }

        private void buttonSaveName_Click(object sender, EventArgs e)
        {
            chosenName = textBoxNameInput.Text;
            buttonDog.Enabled = true;
            buttonPuppy.Enabled = true;
            buttonCat.Enabled = true;
            buttonKitten.Enabled = true;
            buttonBunny.Enabled = true;
            buttonBabyBunny.Enabled = true;
        }

        private void animalList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Animal animal = (Animal)animalList.SelectedItem;

            if (animal == null)
            {
                energyBar.Value = 0;
                happinessBar.Value = 0;
                hungerBar.Value = 0;
                labelDisplayType.Text = null;
                labelDisplayName.Text = null;
                labelDisplayAge.Text = null;
                labelDisplayFavoriteFood.Text = null;
            }
            else
            {
                StatusCheck();
                energyBar.Value = animal.EnergyLevel;
                happinessBar.Value = animal.HappinessLevel;
                hungerBar.Value = animal.HungerLevel;
                labelDisplayType.Text = animal.Type;
                labelDisplayName.Text = animal.Name;
                labelDisplayAge.Text = animal.PrintAge();
                labelDisplayFavoriteFood.Text = animal.FavoriteFood;
            }
        }

        private void textBoxNameInput_Click(object sender, EventArgs e)
        {
            textBoxNameInput.Text = null;
        }

        private void buttonRemoveAnimal_Click(object sender, EventArgs e)
        {
            Animal animal = (Animal)animalList.SelectedItem;

            if (animalList.Items.Count == 0)
            {
                textBoxActivities.Text += $"\r\nDet finns inga djur i listan..\r\n"; 
            }
            else if (animalList.SelectedItem == null)
            {
                textBoxActivities.Text += $"\r\nVälj ett djur i listan och försök igen!\r\n";
            }
            else
            {
                energyBar.Value = 0;
                happinessBar.Value = 0;
                hungerBar.Value = 0;
                animalList.Items.Remove(animalList.SelectedItem);
                textBoxActivities.Text += $"\r\n{animal.Name} borttagen ur listan\r\n";
            }
        }

        private void buttonDog_Click(object sender, EventArgs e)
        {
            Animal dog = new Dog(chosenName);
            animalList.Items.Add(dog);
            textBoxActivities.Text += $"\r\n{dog.Name} är tillagd i listan\r\n";
            chosenName = null;
            textBoxNameInput.Text = null;
            buttonDog.Enabled = false;
            buttonPuppy.Enabled = false;
            buttonCat.Enabled = false;
            buttonKitten.Enabled = false;
            buttonBunny.Enabled = false;
            buttonBabyBunny.Enabled = false;
        }

        private void buttonPuppy_Click(object sender, EventArgs e)
        {
            Animal puppy = new Puppy(chosenName);
            animalList.Items.Add(puppy);
            textBoxActivities.Text += $"\r\n{puppy.Name} är tillagd i listan\r\n";
            chosenName = null;
            textBoxNameInput.Text = null;
            buttonDog.Enabled = false;
            buttonPuppy.Enabled = false;
            buttonCat.Enabled = false;
            buttonKitten.Enabled = false;
            buttonBunny.Enabled = false;
            buttonBabyBunny.Enabled = false;
        }

        private void buttonCat_Click(object sender, EventArgs e)
        {
            Animal cat = new Cat(chosenName);
            animalList.Items.Add(cat);
            textBoxActivities.Text += $"\r\n{cat.Name} är tillagd i listan\r\n";
            chosenName = null;
            textBoxNameInput.Text = null;
            buttonDog.Enabled = false;
            buttonPuppy.Enabled = false;
            buttonCat.Enabled = false;
            buttonKitten.Enabled = false;
            buttonBunny.Enabled = false;
            buttonBabyBunny.Enabled = false;
        }

        private void buttonKitten_Click(object sender, EventArgs e)
        {
            Animal kitten = new Kitten(chosenName);
            animalList.Items.Add(kitten);
            textBoxActivities.Text += $"\r\n{kitten.Name} är tillagd i listan\r\n";
            chosenName = null;
            textBoxNameInput.Text = null;
            buttonDog.Enabled = false;
            buttonPuppy.Enabled = false;
            buttonCat.Enabled = false;
            buttonKitten.Enabled = false;
            buttonBunny.Enabled = false;
            buttonBabyBunny.Enabled = false;
        }

        private void buttonBunny_Click(object sender, EventArgs e)
        {
            Animal bunny = new Bunny(chosenName);
            animalList.Items.Add(bunny);
            textBoxActivities.Text += $"\r\n{bunny.Name} är tillagd i listan\r\n";
            chosenName = null;
            textBoxNameInput.Text = null;
            buttonDog.Enabled = false;
            buttonPuppy.Enabled = false;
            buttonCat.Enabled = false;
            buttonKitten.Enabled = false;
            buttonBunny.Enabled = false;
            buttonBabyBunny.Enabled = false;
        }

        private void buttonBabyBunny_Click(object sender, EventArgs e)
        {
            Animal babyBunny = new BabyBunny(chosenName);
            animalList.Items.Add(babyBunny);
            textBoxActivities.Text += $"\r\n{babyBunny.Name} är tillagd i listan\r\n";
            chosenName = null;
            textBoxNameInput.Text = null;
            buttonDog.Enabled = false;
            buttonPuppy.Enabled = false;
            buttonCat.Enabled = false;
            buttonKitten.Enabled = false;
            buttonBunny.Enabled = false;
            buttonBabyBunny.Enabled = false;
        }

        private void buttonPet_Click(object sender, EventArgs e)
        {
            Animal animal = (Animal)animalList.SelectedItem;

            if (animalList.Items.Count == 0)
            {
                textBoxActivities.Text += "\r\nDet finns inga djur att klappa, lägg till ett djur och försök igen!\r\n";
            }
            else if ( animal == null)
            {
                textBoxActivities.Text += "\r\nVälj ett djur i listan och försök igen!\r\n";
            }
            else
            {
                textBoxActivities.Text += $"\r\n{animal.Name} njuter av att bli klappad!\r\n";
                animal.HappinessLevel = animal.HappinessLevel + 15;
                animal.EnergyLevel = animal.EnergyLevel + 15;
                animal.HungerLevel = animal.HungerLevel - 10;
                StatusCheck();
                InactiveStatusChange();
                energyBar.Value = animal.EnergyLevel;
                happinessBar.Value = animal.HappinessLevel;
                hungerBar.Value = animal.HungerLevel;
            }
        }

        public void StatusCheck() // Kontrollerar att alla djurs variabler stannar mellan 0 - 100
        {
            Animal animal = (Animal)animalList.SelectedItem;

            if (animal.HappinessLevel < 0)
            {
                animal.HappinessLevel = 0;
            }

            if (animal.HappinessLevel > 100)
            {
                animal.HappinessLevel = 100;
            }

            if (animal.HungerLevel < 0)
            {
                animal.HungerLevel = 0;
            }

            if (animal.HungerLevel > 100)
            {
                animal.HungerLevel = 100;
            }

            if (animal.EnergyLevel < 0)
            {
                animal.EnergyLevel = 0;
            }

            if (animal.EnergyLevel > 100)
            {
                animal.EnergyLevel = 100;
            }
        }
        public void ActiveStatusChange() // Ändrar status hos det aktiva djuret vid misslyckad aktivitet!
        {
            Animal animal = (Animal)animalList.SelectedItem;

            animal.EnergyLevel = animal.EnergyLevel + 15;
            animal.HappinessLevel = animal.HappinessLevel - 15;
            animal.HungerLevel = animal.HungerLevel - 15;
            StatusCheck();
            energyBar.Value = animal.EnergyLevel;
            happinessBar.Value = animal.HappinessLevel;
            hungerBar.Value = animal.HungerLevel;
        }

        public void InactiveStatusChange() // Ändrar status på de inaktiva djuren vid specifika interaktioner med ett aktivt djur
        {
            foreach (var entity in animalList.Items)
            {
                Animal animal = (Animal)entity;

                if (animal != animalList.SelectedItem)
                {
                    animal.EnergyLevel = animal.EnergyLevel + 10;
                    animal.HappinessLevel = animal.HappinessLevel - 15;
                    animal.HungerLevel = animal.HungerLevel - 15;

                    StatusCheck();
                }
            }
        }

        private void textBoxActivities_TextChanged(object sender, EventArgs e)
        {

            textBoxActivities.SelectionStart = textBoxActivities.Text.Length;
            textBoxActivities.ScrollToCaret();
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            Animal animal = (Animal)animalList.SelectedItem;
            Ball ball = (Ball)toyList.SelectedItem;

            if (animalList.Items.Count == 0)
            {
                textBoxActivities.Text += $"\r\nDet finns inga djur att leka med, lägg till ett djur och försök igen!\r\n";
            }
            else if (toyList.Items.Count == 0)
            {
                textBoxActivities.Text += $"\r\nDet finns inga leksaker att använda, lägg till en leksak och försök igen!\r\n";
            }
            else if (ball == null)
            {
                textBoxActivities.Text += $"\r\nIngen boll vald! Välj en boll i listan och försök igen!\r\n";
            }
            else if (ball.Quality == 0)
            {
                textBoxActivities.Text += $"\r\nBollen är sönder och går ej att leka med! Plocka gärna bort den ur listan!\r\n";
                ActiveStatusChange();
            }
            else if (animal.EnergyLevel < 25)
            {
                textBoxActivities.Text += $"\r\n{animal.Name} är för trött för att leka!\r\n";
                ActiveStatusChange();
                InactiveStatusChange();
            }
            else if (animal.HungerLevel < 25)
            {
                textBoxActivities.Text += $"\r\n{animal.Name} är hungrig och vill inte leka!\r\n";
                ActiveStatusChange();
                InactiveStatusChange();
            }
            else
            {
                animal.HappinessLevel = animal.HappinessLevel + 15;
                animal.EnergyLevel = animal.EnergyLevel - 15;
                animal.HungerLevel = animal.HungerLevel - 15;
                StatusCheck();
                happinessBar.Value = animal.HappinessLevel;
                energyBar.Value = animal.EnergyLevel;
                hungerBar.Value = animal.HungerLevel;
                InactiveStatusChange();
                ball.LowerQuality(animal.Strength);
                if (ball.Quality < 0)
                {
                    ball.Quality = 0;
                }
                qualityBar.Value = ball.Quality;
            }
        }

        private void buttonFeed_Click(object sender, EventArgs e)
        {
            Animal animal = (Animal)animalList.SelectedItem;

            if (foodList.SelectedItem == null)
            {
                textBoxActivities.Text += $"\r\nDu måste välja mat i listan först!\r\n";
            }
            else if (animalList.Items.Count == 0)
            {
                textBoxActivities.Text += $"\r\nDet finns inga djur att mata, lägg till ett djur och försök igen!\r\n";
            }
            else if (animal == null)
            {
                textBoxActivities.Text += $"\r\nDu måste välja ett djur i listan först!\r\n";
            }
            else if (animal.HungerLevel > 75)
            {
                textBoxActivities.Text += $"\r\n{animal.Name} är inte hungrig och vill därför inte äta!\r\n";
                ActiveStatusChange();
                InactiveStatusChange();
            }
            else if (animal.FavoriteFood != foodList.SelectedItem.ToString())
            {
                textBoxActivities.Text += $"\r\n{animal.Name} tittar på maten med besvikelse och vill inte äta!\r\n";
                ActiveStatusChange();
                InactiveStatusChange();
            }
            else
            {
                textBoxActivities.Text += $"\r\n{animal.Name} äter glatt och blir väldigt mätt!\r\n";
                animal.HungerLevel = 100;
                hungerBar.Value = animal.HungerLevel;
                InactiveStatusChange();
            }
        }

        private void buttonSaveGame_Click(object sender, EventArgs e)
        {
            using (StreamWriter saveFile = new StreamWriter("SavedGame.txt", false))
            {
                saveFile.WriteLine("// DJUR //");
                saveFile.WriteLine();
                foreach (var entity in animalList.Items)
                {
                    Animal animal = (Animal)entity;

                    saveFile.WriteLine(animal.Type);
                    saveFile.WriteLine(animal.Name);
                    saveFile.WriteLine(animal.AgeYears);
                    saveFile.WriteLine(animal.AgeMonths);
                    saveFile.WriteLine(animal.FavoriteFood);
                    saveFile.WriteLine(animal.EnergyLevel);
                    saveFile.WriteLine(animal.HappinessLevel);
                    saveFile.WriteLine(animal.HungerLevel);
                    saveFile.WriteLine();
                }

                saveFile.WriteLine("// BOLLAR //");
                saveFile.WriteLine();
                foreach (var entity in toyList.Items)
                {
                    Ball ball = (Ball)entity;

                    saveFile.WriteLine(ball);
                    saveFile.WriteLine(ball.Quality);
                }

                textBoxActivities.Text += $"\r\nListorna är sparade i en textfil!\r\n";

                saveFile.Close();
            }
        }
    }
}
