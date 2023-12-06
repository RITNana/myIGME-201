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
    public partial class Singing : Form
    {
       private readonly Random random = new Random();
        private int buttonCounter = 0;
        private Timer timer;
        public Singing()
        {
            InitializeComponent();

            try
            {
                // Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 6.2; WOW64; Trident / 7.0; .NET4.0C; .NET4.0E; .NET CLR 2.0.50727; .NET CLR 3.0.30729; .NET CLR 3.5.30729; wbx 1.0.0)
                Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(
                    @"SOFTWARE\\WOW6432Node\\Microsoft\\Internet Explorer\\MAIN\\FeatureControl\\FEATURE_BROWSER_EMULATION",
                    true);
                key.SetValue(Application.ExecutablePath.Replace(Application.StartupPath + "\\", ""), 12001, Microsoft.Win32.RegistryValueKind.DWord);
                key.Close();
            }
            catch
            {

            }

            this.groupBox1.Text = "Monkey D. Luffy Singing";
            this.webBrowser1.Navigate ("https://www.youtube.com/watch?v=Ohu4qKi6a0c");
            this.webBrowser1.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(WebBrowser1__DocumentCompleted);

            Timer timer = new Timer();
            timer.Interval = 5000; // Set the interval in milliseconds (e.g., 5000ms = 5 seconds)
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Start();

        }

        private void WebBrowser1__DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            
            webBrowser1.ScriptErrorsSuppressed = true;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (buttonCounter < 10)
            {
                // Create a new Button
                Button randomButton = new Button();
                randomButton.Text = "Random Button";
                randomButton.Size = new Size(100, 50); // Set the button size
                randomButton.Location = new Point(random.Next(this.ClientSize.Width - randomButton.Width), random.Next(this.ClientSize.Height - randomButton.Height));
                // Generate random position within the form

                randomButton.Click += RandomButton_Click;

                this.Controls.Add(randomButton); // Add the button to the form

                randomButton.BringToFront(); // Bring the button to the front

                buttonCounter++;

                if (buttonCounter == 10)
                {
                    timer.Stop(); // Stop the timer when 10 buttons are created
                }
            }
            else
            {
                timer.Stop(); // Stop the timer if already 10 buttons
            }
        }

        private void RandomButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button Clicked!");
        }
    }




}

