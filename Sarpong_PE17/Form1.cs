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
    public partial class GuessingGameForm : Form
    {
        public GuessingGameForm()
        {
            InitializeComponent();
            this.startButton.Click += new EventHandler(StartButton_Click);
            this.lowTextBox.KeyPress += new KeyPressEventHandler(TxtBoxNum__KeyPress);
            this.highTextBox.KeyPress += new KeyPressEventHandler(TxtBoxNum__KeyPress);
         
        }

        private void TxtBoxNum__KeyPress(object sender, KeyPressEventArgs e)
        {
           

            if (!Char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                
            }
            else
            {
                e.Handled = false;
            }
        }
        private void StartButton_Click(object sender, EventArgs e)
        {
            bool bConv;
            int lowNumber = 0;
            int highNumber = 0;

            // convert the strings entered in lowTextBox and highTextBox
            // to lowNumber and highNumber Int32.Parse
            bConv = Int32.TryParse(lowTextBox.Text, out lowNumber);
            bConv &= Int32.TryParse(highTextBox.Text, out highNumber);

            // if not a valid range
            if (lowNumber >= highNumber)
            {
                // show a dialog that the numbers are not valid
                MessageBox.Show("The numbers are invalid.");
            }
            else
            {
                // otherwise we're good
                // create a form object of the second form 
                // passing in the number range
                GameForm gameForm = new GameForm(lowNumber, highNumber);

                // display the form as a modal dialog, 
                // which makes the first form inactive
                gameForm.ShowDialog();
            }

           

            
        }

        



    }

}
