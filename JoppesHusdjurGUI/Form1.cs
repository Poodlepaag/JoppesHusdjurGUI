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

            try
            {
                qualityBar.Value = ball.Quality();
            }
            catch { }
            
            
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
                textBoxActivities.Text = "Ingen boll är vald! \r\n" +
                                         "Markera en boll i listan och försök igen!";
            }
            else
            {
                qualityBar.Value = 0;
                toyList.Items.Remove(toyList.SelectedItem);
                textBoxActivities.Text = $"{ball} borttagen ur listan!";
            }
        }

        private void toyList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
