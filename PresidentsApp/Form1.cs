using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace PresidentsApp
{
    public partial class PresidentsForm : Form
    {
        public PresidentsForm()
        {
            /******************************************************************************************
               **************THIS MUST BE THE FIRST FUNCTION CALL IN YOUR FORM CONSTRUCTOR **************
               ******************************************************************************************/
            InitializeComponent();

            try
            {
                // Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 6.2; WOW64; Trident /7.0; .NET4.0C; .NET4.0E; .NET CLR 2.0.50727; .NET CLR 3.0.30729; .NET CLR 3.5.30729; wbx1.0.0)
                Microsoft.Win32.RegistryKey key =
                Microsoft.Win32.Registry.LocalMachine.OpenSubKey(@"SOFTWARE\\WOW6432Node\\Microsoft\\Internet Explorer\\MAIN\\FeatureControl\\FEATURE_BROWSER_EMULATION", true);
                key.SetValue(Application.ExecutablePath.Replace(Application.StartupPath + "\\", ""), 12001,
                Microsoft.Win32.RegistryValueKind.DWord);
                key.Close();
            }
            catch
            {

            }
            
            // 1) Create our Form controls for the president radio buttons
            // Because they are all radio buttons we wil put them in the same Delegate Method

            //Benjamin Harrison
            this.bhRadioButton.CheckedChanged += new EventHandler(this.PresidentRadioButton__CheckedChanged);

            // Franklin D.Roosevelt
            this.fdrRadioButton.CheckedChanged += new EventHandler(this.PresidentRadioButton__CheckedChanged);

            // William J. Clinton (Bill Clinton)
            this.wjcRadioButton.CheckedChanged += new EventHandler(this.PresidentRadioButton__CheckedChanged);

            // James Buchanan
            this.jbRadioButton.CheckedChanged += new EventHandler(this.PresidentRadioButton__CheckedChanged);

            // Franklin Pierce
            this.fpRadioButton.CheckedChanged += new EventHandler(this.PresidentRadioButton__CheckedChanged);

            // George W. Bush
            this.gwbRadioButton.CheckedChanged += new EventHandler(this.PresidentRadioButton__CheckedChanged);

            // Barrack Obama
            this.boRadioButton.CheckedChanged += new EventHandler(this.PresidentRadioButton__CheckedChanged);

            // John F. Kennedy
            this.jfkRadioButton.CheckedChanged += new EventHandler(this.PresidentRadioButton__CheckedChanged);

            // WWilliam McKinley
            this.wmkRadioButton.CheckedChanged += new EventHandler(this.PresidentRadioButton__CheckedChanged);

            // Ronald Reagen
            this.rrRadioButton.CheckedChanged += new EventHandler(this.PresidentRadioButton__CheckedChanged);

            // Dwight D. Eisenhower
            this.ddeRadioButton.CheckedChanged += new EventHandler(this.PresidentRadioButton__CheckedChanged);

            // Martin VanBuren
            this.mvbRadioButton.CheckedChanged += new EventHandler(this.PresidentRadioButton__CheckedChanged);

            // George Washington
            this.gwRadioButton.CheckedChanged += new EventHandler(this.PresidentRadioButton__CheckedChanged);

            // John Adams
            this.jaRadioButton.CheckedChanged += new EventHandler(this.PresidentRadioButton__CheckedChanged);

            // Theodore Roosevelt
            this.trRadioButton.CheckedChanged += new EventHandler(this.PresidentRadioButton__CheckedChanged);

            // Thomas Jefferson
            this.tjRadioButton.CheckedChanged += new EventHandler(this.PresidentRadioButton__CheckedChanged);

            this.bhTextBox.TextChanged += new EventHandler(TxtBoxEmpty__TextChanged);
            this.fdrTextBox.TextChanged += new EventHandler(TxtBoxEmpty__TextChanged);
            this.wjcTextBox.TextChanged += new EventHandler(TxtBoxEmpty__TextChanged);
            this.jbTextBox.TextChanged += new EventHandler(TxtBoxEmpty__TextChanged);
            this.fpTextBox.TextChanged += new EventHandler(TxtBoxEmpty__TextChanged);
            this.gwbTextBox.TextChanged += new EventHandler(TxtBoxEmpty__TextChanged);
            this.boTextBox.TextChanged += new EventHandler(TxtBoxEmpty__TextChanged);
            this.jfkTextBox.TextChanged += new EventHandler(TxtBoxEmpty__TextChanged);
            this.wmkTextBox.TextChanged += new EventHandler(TxtBoxEmpty__TextChanged);
            this.rrTextBox.TextChanged += new EventHandler(TxtBoxEmpty__TextChanged);
            this.ddeTextBox.TextChanged += new EventHandler(TxtBoxEmpty__TextChanged);
            this.mvbTextBox.TextChanged += new EventHandler(TxtBoxEmpty__TextChanged);
            this.gwTextBox.TextChanged += new EventHandler(TxtBoxEmpty__TextChanged);
            this.jaTextBox.TextChanged += new EventHandler(TxtBoxEmpty__TextChanged);
            this.trTextBox.TextChanged += new EventHandler(TxtBoxEmpty__TextChanged);
            this.tjTextBox.TextChanged += new EventHandler(TxtBoxEmpty__TextChanged);


            this.bhTextBox.KeyPress += new KeyPressEventHandler(TxtBoxNum__KeyPress);
            this.fdrTextBox.KeyPress += new KeyPressEventHandler(TxtBoxNum__KeyPress);
            this.wjcTextBox.KeyPress += new KeyPressEventHandler(TxtBoxNum__KeyPress);
            this.jbTextBox.KeyPress += new KeyPressEventHandler(TxtBoxNum__KeyPress);
            this.fpTextBox.KeyPress += new KeyPressEventHandler(TxtBoxNum__KeyPress);
            this.gwbTextBox.KeyPress += new KeyPressEventHandler(TxtBoxNum__KeyPress);
            this.boTextBox.KeyPress += new KeyPressEventHandler(TxtBoxNum__KeyPress);
            this.jfkTextBox.KeyPress += new KeyPressEventHandler(TxtBoxNum__KeyPress);
            this.wmkTextBox.KeyPress += new KeyPressEventHandler(TxtBoxNum__KeyPress);
            this.rrTextBox.KeyPress += new KeyPressEventHandler(TxtBoxNum__KeyPress);
            this.ddeTextBox.KeyPress += new KeyPressEventHandler(TxtBoxNum__KeyPress);
            this.mvbTextBox.KeyPress += new KeyPressEventHandler(TxtBoxNum__KeyPress);
            this.gwTextBox.KeyPress += new KeyPressEventHandler(TxtBoxNum__KeyPress);
            this.jaTextBox.KeyPress += new KeyPressEventHandler(TxtBoxNum__KeyPress);
            this.trTextBox.KeyPress += new KeyPressEventHandler(TxtBoxNum__KeyPress);
            this.tjTextBox.KeyPress += new KeyPressEventHandler(TxtBoxNum__KeyPress);

            this.bhTextBox.Validating += new CancelEventHandler(TxtBoxEmpty__Validating);
            this.fdrTextBox.Validating += new CancelEventHandler(TxtBoxEmpty__Validating);
            this.wjcTextBox.Validating += new CancelEventHandler(TxtBoxEmpty__Validating);
            this.jbTextBox.Validating += new CancelEventHandler(TxtBoxEmpty__Validating);
            this.fpTextBox.Validating += new CancelEventHandler(TxtBoxEmpty__Validating);
            this.gwbTextBox.Validating += new CancelEventHandler(TxtBoxEmpty__Validating);
            this.boTextBox.Validating += new CancelEventHandler(TxtBoxEmpty__Validating);
            this.jfkTextBox.Validating += new CancelEventHandler(TxtBoxEmpty__Validating);
            this.wmkTextBox.Validating += new CancelEventHandler(TxtBoxEmpty__Validating);
            this.rrTextBox.Validating += new CancelEventHandler(TxtBoxEmpty__Validating);
            this.ddeTextBox.Validating += new CancelEventHandler(TxtBoxEmpty__Validating);
            this.mvbTextBox.Validating += new CancelEventHandler(TxtBoxEmpty__Validating);
            this.gwTextBox.Validating += new CancelEventHandler(TxtBoxEmpty__Validating);
            this.jaTextBox.Validating += new CancelEventHandler(TxtBoxEmpty__Validating);
            this.trTextBox.Validating += new CancelEventHandler(TxtBoxEmpty__Validating);
            this.tjTextBox.Validating += new CancelEventHandler(TxtBoxEmpty__Validating);

            this.timer1.Tick += new EventHandler(Timer__Tick);

            this.wikiWebBrowser.ScriptErrorsSuppressed = true;
            this.wikiWebBrowser.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(WikiWebBrowser__DocumentCompleted);

            this.allRadioButton.CheckedChanged += new EventHandler(FilterRadioButton__CheckedChanged);
            this.democratRadioButton.CheckedChanged += new EventHandler(FilterRadioButton__CheckedChanged);
            this.republicanRadioButton.CheckedChanged += new EventHandler(FilterRadioButton__CheckedChanged);
            this.demorepRadioButton.CheckedChanged += new EventHandler(FilterRadioButton__CheckedChanged);
            this.federalistRadioButton.CheckedChanged += new EventHandler(FilterRadioButton__CheckedChanged);

            // after all contols are configured then we can manipulate the data
            this.wikiGroupBox.Text = "https://en.m.wikipedia.org/wiki/Benjamin_Harrison";
            this.wikiWebBrowser.Navigate("https://en.m.wikipedia.org/wiki/Benjamin_Harrison");
            this.photoPictureBox.ImageLocation = "http://people.rit.edu/dxsigm/BenjaminHarrison";
            this.exitButton.Enabled = false;
            this.allRadioButton.Checked = true;

            this.timer1.Interval = 1000;

        }

        private void PresidentRadioButton__CheckedChanged(object sender, EventArgs e)
        {
            if (fdrRadioButton.Checked)
            {
                this.photoPictureBox.ImageLocation = "http://people.rit.edu/dxsigm/FranklinDRoosevelt.jpeg";
                this.wikiGroupBox.Text = "https://en.m.wikipedia.org/wiki/Franklin_D_Roosevelt";
                this.wikiWebBrowser.Navigate("https://en.m.wikipedia.org/wiki/Franklin_D_Roosevelt");

            } else if (wjcRadioButton.Checked)
            {
                this.photoPictureBox.ImageLocation = "https://people.rit.edu/dxsigm/WilliamJClinton.jpeg";
                this.wikiGroupBox.Text = "https://en.m.wikipedia.org/wiki/William_J_Clinton";
                this.wikiWebBrowser.Navigate("https://en.m.wikipedia.org/wiki/William_J_Clinton");

            } else if (jbRadioButton.Checked)
            {
                this.photoPictureBox.ImageLocation = "https://people.rit.edu/dxsigm/JamesBuchanan.jpeg";
                this.wikiGroupBox.Text = "https://en.m.wikipedia.org/wiki/James_Buchanan";
                this.wikiWebBrowser.Navigate("https://en.m.wikipedia.org/wiki/James_Buchanan");

            } else if (fpRadioButton.Checked)
            {
                this.photoPictureBox.ImageLocation = "https://people.rit.edu/dxsigm/FranklinPierce.jpeg";
                this.wikiGroupBox.Text = "https://en.m.wikipedia.org/wiki/Franklin_Pierce";
                this.wikiWebBrowser.Navigate("https://en.m.wikipedia.org/wiki/Franklin_Pierce");

            } else if (gwbRadioButton.Checked)
            {
                this.photoPictureBox.ImageLocation = "https://people.rit.edu/dxsigm/GeorgeWBush.jpeg";
                this.wikiGroupBox.Text = "https://en.m.wikipedia.org/wiki/George_Bush";
                this.wikiWebBrowser.Navigate("https://en.m.wikipedia.org/wiki/George_Bush");

            } else if (boRadioButton.Checked)
            {
                this.photoPictureBox.ImageLocation = "https://people.rit.edu/dxsigm/BarackObama.png";
                this.wikiGroupBox.Text = "https://en.m.wikipedia.org/wiki/Barack_Obama";
                this.wikiWebBrowser.Navigate("https://en.m.wikipedia.org/wiki/Barack_Obama");

            } else if (jfkRadioButton.Checked)
            {
                this.photoPictureBox.ImageLocation = "https://people.rit.edu/dxsigm/JohnFKennedy.jpeg";
                this.wikiGroupBox.Text = "https://en.m.wikipedia.org/wiki/John_F_Kennedy";
                this.wikiWebBrowser.Navigate("https://en.m.wikipedia.org/wiki/John_F_Kennedy");

            } else if (wmkRadioButton.Checked)
            {
                this.photoPictureBox.ImageLocation = "https://people.rit.edu/dxsigm/WilliamMcKinley.jpeg";
                this.wikiGroupBox.Text = "https://en.m.wikipedia.org/wiki/William_McKinley";
                this.wikiWebBrowser.Navigate("https://en.m.wikipedia.org/wiki/William_McKinley");

            } else if (rrRadioButton.Checked)
            {
                this.photoPictureBox.ImageLocation = "https://people.rit.edu/dxsigm/RonaldReagan.jpeg";
                this.wikiGroupBox.Text = "https://en.m.wikipedia.org/wiki/Ronald_Reagan";
                this.wikiWebBrowser.Navigate("https://en.m.wikipedia.org/wiki/Ronald_Reagan");

            } else if (ddeRadioButton.Checked)
            {
                this.photoPictureBox.ImageLocation = "https://people.rit.edu/dxsigm/DwightDEisenhower.jpeg";
                this.wikiGroupBox.Text = "https://en.m.wikipedia.org/wiki/Dwight_D_Eisenhower";
                this.wikiWebBrowser.Navigate("https://en.m.wikipedia.org/wiki/Dwight_D_Eisenhower");

            } else if (mvbRadioButton.Checked)
            {
                this.photoPictureBox.ImageLocation = "https://people.rit.edu/dxsigm/MartinVanBuren.jpeg";
                this.wikiGroupBox.Text = "https://en.m.wikipedia.org/wiki/Martin_VanBuren";
                this.wikiWebBrowser.Navigate("https://en.m.wikipedia.org/wiki/Martin_VanBuren");

            } else if (gwRadioButton.Checked)
            {
                this.photoPictureBox.ImageLocation = "https://people.rit.edu/dxsigm/GeorgeWashington.jpeg";
                this.wikiGroupBox.Text = "https://en.m.wikipedia.org/wiki/George_Washington";
                this.wikiWebBrowser.Navigate("https://en.m.wikipedia.org/wiki/George_Washington");

            } else if (jaRadioButton.Checked)
            {
                this.photoPictureBox.ImageLocation = "https://people.rit.edu/dxsigm/JohnAdams.jpeg";
                this.wikiGroupBox.Text = "https://en.m.wikipedia.org/wiki/John_Adams";
                this.wikiWebBrowser.Navigate("https://en.m.wikipedia.org/wiki/John_Adams");

            } else if (trRadioButton.Checked)
            {
                this.photoPictureBox.ImageLocation = "https://people.rit.edu/dxsigm/TheodoreRoosevelt.jpeg";
                this.wikiGroupBox.Text = "https://en.m.wikipedia.org/wiki/Theodore_Roosevelt";
                this.wikiWebBrowser.Navigate("https://en.m.wikipedia.org/wiki/Theodore_Roosevelt");

            } else if (tjRadioButton.Checked)
            {
                this.photoPictureBox.ImageLocation = "https://people.rit.edu/dxsigm/ThomasJefferson.jpeg";
                this.wikiGroupBox.Text = "https://en.m.wikipedia.org/wiki/Thomas_Jefferson";
                this.wikiWebBrowser.Navigate("https://en.m.wikipedia.org/wiki/Thomas_Jefferson");

            } else  
            {
                bhRadioButton.Checked = true;
                this.wikiGroupBox.Text = "https://en.m.wikipedia.org/wiki/Benjamin_Harrison";
                this.wikiWebBrowser.Navigate("https://en.m.wikipedia.org/wiki/Benjamin_Harrison");
                this.photoPictureBox.ImageLocation = "http://people.rit.edu/dxsigm/BenjaminHarrison";
            }
        }

        private void FilterRadioButton__CheckedChanged(object sender, EventArgs e)
        {

            RadioButton rb = (RadioButton)sender;
            if (rb.Checked)
            {
                if (rb == this.allRadioButton)
                {
                    this.bhRadioButton.Checked = true;
                    this.tjRadioButton.Show();
                    this.bhRadioButton.Show();
                    this.gwbRadioButton.Show();
                    this.wmkRadioButton.Show();
                    this.rrRadioButton.Show();
                    this.ddeRadioButton.Show();
                    this.gwRadioButton.Show();
                    this.jaRadioButton.Show();
                    this.trRadioButton.Show();
                    this.fdrRadioButton.Show();
                    this.wjcRadioButton.Show();
                    this.jbRadioButton.Show();
                    this.fpRadioButton.Show();
                    this.boRadioButton.Show();
                    this.jfkRadioButton.Show();
                    this.mvbRadioButton.Show();
                    this.gwRadioButton.Show();
                    this.jaRadioButton.Show();
                } if (rb == this.democratRadioButton)
                {
                    this.fdrRadioButton.Checked = true;
                    this.fdrRadioButton.Show();
                    this.wjcRadioButton.Show();
                    this.jbRadioButton.Show();
                    this.fpRadioButton.Show();
                    this.boRadioButton.Show();
                    this.jfkRadioButton.Show();
                    this.mvbRadioButton.Show();




                    this.bhRadioButton.Hide();
                    this.gwbRadioButton.Hide();
                    this.wmkRadioButton.Hide();
                    this.rrRadioButton.Hide();
                    this.ddeRadioButton.Hide();
                    this.gwRadioButton.Hide();
                    this.jaRadioButton.Hide();
                    this.trRadioButton.Hide();
                    this.tjRadioButton.Hide();
                } if (rb == this.republicanRadioButton)
                {
                    this.bhRadioButton.Checked = true;
                    this.bhRadioButton.Show();
                    this.gwbRadioButton.Show();
                    this.wmkRadioButton.Show();
                    this.rrRadioButton.Show();
                    this.ddeRadioButton.Show();
                    this.trRadioButton.Show();

                    this.fdrRadioButton.Hide();
                    this.wjcRadioButton.Hide();
                    this.jbRadioButton.Hide();
                    this.fpRadioButton.Hide();
                    this.boRadioButton.Hide();
                    this.jfkRadioButton.Hide();
                    this.mvbRadioButton.Hide();
                    this.gwRadioButton.Hide();
                    this.jaRadioButton.Hide();
                    this.tjRadioButton.Hide();
                } if (rb == this.demorepRadioButton)
                {
                    this.tjRadioButton.Checked = true;
                    this.tjRadioButton.Show();

                    this.bhRadioButton.Hide();
                    this.gwbRadioButton.Hide();
                    this.wmkRadioButton.Hide();
                    this.rrRadioButton.Hide();
                    this.ddeRadioButton.Hide();
                    this.gwRadioButton.Hide();
                    this.jaRadioButton.Hide();
                    this.trRadioButton.Hide();
                    this.fdrRadioButton.Hide();
                    this.wjcRadioButton.Hide();
                    this.jbRadioButton.Hide();
                    this.fpRadioButton.Hide();
                    this.boRadioButton.Hide();
                    this.jfkRadioButton.Hide();
                    this.mvbRadioButton.Hide();
                    this.gwRadioButton.Hide();
                    this.jaRadioButton.Hide();

                } if (rb == this.federalistRadioButton)
                {
                    this.gwRadioButton.Checked = true;
                    this.gwRadioButton.Show();
                    this.jaRadioButton.Show();

                    this.tjRadioButton.Hide();
                    this.bhRadioButton.Hide();
                    this.gwbRadioButton.Hide();
                    this.wmkRadioButton.Hide();
                    this.rrRadioButton.Hide();
                    this.ddeRadioButton.Hide();
                    this.trRadioButton.Hide();
                    this.fdrRadioButton.Hide();
                    this.wjcRadioButton.Hide();
                    this.jbRadioButton.Hide();
                    this.fpRadioButton.Hide();
                    this.boRadioButton.Hide();
                    this.jfkRadioButton.Hide();
                    this.mvbRadioButton.Hide();
                }
            }
        

        }

        private void Timer__Tick(object sender, EventArgs e)
        {

        }

        private void TxtBoxNum__KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void TxtBoxEmpty__TextChanged(object sender, EventArgs e)
        {

        }
        private void TxtBoxEmpty__Validating(object sender, CancelEventArgs e)
        {

        }

        private void WikiWebBrowser__DocumentCompleted(object sender, EventArgs e)
        {

        }

            private void filterGroupBox_Enter(object sender, EventArgs e)
            {

            }

            private void button1_Click(object sender, EventArgs e)
            {

            }

            private void textBox3_TextChanged(object sender, EventArgs e)
            {

            }

            private void fpRadioButton_CheckedChanged(object sender, EventArgs e)
            {

            }

        private void toolStripProgressBar1_Click(object sender, EventArgs e)
        {

        }

     
    }
    }

