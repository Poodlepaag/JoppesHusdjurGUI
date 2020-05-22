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
        List<Animal> pets = new List<Animal>();
        Print print = new Print();
        string[] food = new string[3];

        int ballCount = 0;

        public JoppesHusdjurGUI()
        {
            InitializeComponent();
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
            textBoxActivities.Text = $"{ball} tillagd!";

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
                textBoxActivities.Text = "Det finns inga bollar i listan";
            }
            else if (toyList.SelectedItem == null)
            {
                textBoxActivities.Text = "Ingen boll är vald! Markera en boll i listan och försök igen!";
            }
            else
            {
                qualityBar.Value = 0;
                toyList.Items.Remove(toyList.SelectedItem);
                textBoxActivities.Text += $"\r\n{ball} borttagen ur listan!";
            }
        }

        private void textBoxActivities_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonAddAnimal_Click(object sender, EventArgs e)
        {
            
        }
    }
}
