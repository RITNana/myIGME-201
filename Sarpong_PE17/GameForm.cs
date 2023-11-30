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

            this.progressBar.Value = 45;



            timer.Start();




        }



        private void Timer__Tick(object sender, EventArgs e)
        {


            --this.progressBar.Value;
            if (this.progressBar.Value <= 0)
            {
                timer.Stop();
                MessageBox.Show("Time's Up!");
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
