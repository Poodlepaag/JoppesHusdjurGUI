using JoppesHusdjurGUI.Animals;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
                qualityBar.Value = ball.Quality();
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

        private void textBoxActivities_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonDog_Click(object sender, EventArgs e)
        {
            Animal dog = new Dog(chosenName);
            animalList.Items.Add(dog);
            textBoxActivities.Text = $"\r\n{dog.GetName()} är tillagd i listan\r\n";
            chosenName = null;
            textBoxNameInput.Text = null;
            buttonDog.Enabled = false;
            buttonPuppy.Enabled = false;
            buttonCat.Enabled = false;
            buttonKitten.Enabled = false;
            buttonBunny.Enabled = false;
            buttonBabyBunny.Enabled = false;
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
                energyBar.Value = animal.GetEnergyLevel();
                happinessBar.Value = animal.GetHappinessLevel();
                hungerBar.Value = animal.GetHungerLevel();
                labelDisplayType.Text = animal.GetType();
                labelDisplayName.Text = animal.GetName();
                labelDisplayAge.Text = animal.GetAge();
                labelDisplayFavoriteFood.Text = animal.GetFavoriteFood();
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
                textBoxActivities.Text += $"\r\n{animal.GetName()} borttagen ur listan\r\n";
            }
        }

        private void buttonPuppy_Click(object sender, EventArgs e)
        {
            Animal puppy = new Puppy(chosenName);
            animalList.Items.Add(puppy);
            textBoxActivities.Text = $"\r\n{puppy.GetName()} är tillagd i listan\r\n";
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
            textBoxActivities.Text = $"\r\n{cat.GetName()} är tillagd i listan\r\n";
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
            textBoxActivities.Text = $"\r\n{kitten.GetName()} är tillagd i listan\r\n";
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
            textBoxActivities.Text = $"\r\n{bunny.GetName()} är tillagd i listan\r\n";
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
            textBoxActivities.Text = $"\r\n{babyBunny.GetName()} är tillagd i listan\r\n";
            chosenName = null;
            textBoxNameInput.Text = null;
            buttonDog.Enabled = false;
            buttonPuppy.Enabled = false;
            buttonCat.Enabled = false;
            buttonKitten.Enabled = false;
            buttonBunny.Enabled = false;
            buttonBabyBunny.Enabled = false;
        }
    }
}
