using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sarpong_PE17
{
    public partial class GameForm : Form
    {
        private int nRandom;
        public GameForm(int lowNumber, int highNumber)
        {

            InitializeComponent();

            Random rand = new Random();
            nRandom = rand.Next(lowNumber, highNumber + 1);

            this.timer.Interval = 500;
            this.progressBar.Value = 90;



            this.guessButton.Click += new EventHandler(GuessButton__Click);
            this.guessButton.KeyDown += new KeyEventHandler(GuessButton__KeyDown);
            

            timer.Start();




        }


        private int nGuesses;

        private void GuessButton__KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = false;
            }
        }
        private void GuessButton__Click(object sender, EventArgs e)
        {
            int userGuess;
            if (!Int32.TryParse(guessTextBox.Text, out userGuess))
            {
                return;
            }

            nGuesses++;
            if(userGuess < nRandom)
            {
                this.guessTextBox.Clear();
                this.outputLabel.Text = $"{userGuess} is too low";
            } else if 
                (userGuess > nRandom)
            {
                this.guessTextBox.Clear();
                this.outputLabel.Text = $"{userGuess} is too high";
            } else if (userGuess == nRandom  && this.progressBar.Value > 0)
            {
                timer.Stop();
                MessageBox.Show($"Woohoo, you got it in {nGuesses} guesses!");
                this.Close();
               
            } else
            {
                MessageBox.Show($"Out of Time! The correct answer was {nRandom}");
                this.Close();
            }
            
        }

        private void Timer__Tick(object sender, EventArgs e)
        {
            

            --this.progressBar.Value;
            if (this.progressBar.Value == 0)
            {
                timer.Stop();
                MessageBox.Show($"Out of Time! The correct answer was {nRandom}");
                this.Close();


            }
        }




        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void GameForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void toolStripProgressBar1_Click(object sender, EventArgs e)
        {

        }


    }
}
