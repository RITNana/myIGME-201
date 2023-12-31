﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Naruto
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
          

            this.hinataButton.Click += new EventHandler(HinataButton__Click);
            this.hinataButton.MouseHover += new EventHandler(HinataButton__MouseHover);
        }

        private void HinataButton__Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            MessageBox.Show("She doesn't! Baka Yaro!");

            MessageBox.Show("Let's go the next question");
            KakashiForm kakashiForm = new KakashiForm();
            kakashiForm.ShowDialog();
        }

        private void HinataButton__MouseHover(object sender, EventArgs e)
        {
            Random random = new Random();

            // Define the maximum X and Y positions within the form
            int maxX = this.ClientRectangle.Width - hinataButton.Width;
            int maxY = this.ClientRectangle.Height - hinataButton.Height;

            // Move the button to a random location 10 times
            for (int i = 0; i < 10; i++)
            {
                // Generate random X and Y coordinates within the form's boundaries
                int newX = random.Next(maxX);
                int newY = random.Next(maxY);

                // Set the button's new location
                hinataButton.Location = new Point(newX, newY);

                // Pause briefly to show the movement (optional)
              //  System.Threading.Thread.Sleep(100); // Adjust the duration as needed
                this.Refresh(); // Refresh the form to update the button's position visually
            }
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void hinataButton_Click(object sender, EventArgs e)
        {

        }

        private void questionLabel_Click(object sender, EventArgs e)
        {

        }
    }
    
}
