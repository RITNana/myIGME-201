namespace Sarpong_PE17
{
    partial class GameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guessLabel = new System.Windows.Forms.Label();
            this.currentGuessTextBox = new System.Windows.Forms.TextBox();
            this.guessButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // guessLabel
            // 
            this.guessLabel.AutoSize = true;
            this.guessLabel.Location = new System.Drawing.Point(199, 45);
            this.guessLabel.Name = "guessLabel";
            this.guessLabel.Size = new System.Drawing.Size(49, 16);
            this.guessLabel.TabIndex = 0;
            this.guessLabel.Text = "Guess:";
            this.guessLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // currentGuessTextBox
            // 
            this.currentGuessTextBox.Location = new System.Drawing.Point(268, 45);
            this.currentGuessTextBox.Name = "currentGuessTextBox";
            this.currentGuessTextBox.Size = new System.Drawing.Size(59, 22);
            this.currentGuessTextBox.TabIndex = 1;
            // 
            // guessButton
            // 
            this.guessButton.Location = new System.Drawing.Point(225, 100);
            this.guessButton.Name = "guessButton";
            this.guessButton.Size = new System.Drawing.Size(75, 23);
            this.guessButton.TabIndex = 2;
            this.guessButton.Text = "Guess";
            this.guessButton.UseVisualStyleBackColor = true;
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.ForeColor = System.Drawing.Color.Red;
            this.outputLabel.Location = new System.Drawing.Point(237, 142);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(44, 16);
            this.outputLabel.TabIndex = 3;
            this.outputLabel.Text = "label1";
            this.outputLabel.Visible = false;
            this.outputLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 175);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(580, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // timer
            // 
            this.timer.Interval = 500;
            this.timer.Tick += new System.EventHandler(this.Timer__Tick);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(0, 175);
            this.progressBar.Maximum = 45;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(482, 23);
            this.progressBar.TabIndex = 5;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 197);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.guessButton);
            this.Controls.Add(this.currentGuessTextBox);
            this.Controls.Add(this.guessLabel);
            this.Name = "GameForm";
            this.Text = "Guesses";
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label guessLabel;
        private System.Windows.Forms.TextBox currentGuessTextBox;
        private System.Windows.Forms.Button guessButton;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}