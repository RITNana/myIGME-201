using System;
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
    public partial class KakashiForm : Form
    {
        public KakashiForm()
        {
            InitializeComponent();


            this.timer1.Tick += new EventHandler(Timer1__Tick);
            this.timer1.Interval = 3000;
            this.toolStripProgressBar1.Value = 3000;
            this.textBox1.Click += new EventHandler(TextBox1__Click);
          
        }

        private void TextBox1__Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Timer1__Tick(object sender, EventArgs e)
        {
            --this.toolStripProgressBar1.Value;
            if(this.toolStripProgressBar1.Value == 0)
            {
                MessageBox.Show("Too Slow!");
            }
        }
    }
}
