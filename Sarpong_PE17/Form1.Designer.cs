namespace Sarpong_PE17
{
    partial class GuessingGameForm
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
            this.questionLabel = new System.Windows.Forms.Label();
            this.lowNumberLabel = new System.Windows.Forms.Label();
            this.highNumberLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.Location = new System.Drawing.Point(45, 32);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(159, 13);
            this.questionLabel.TabIndex = 0;
            this.questionLabel.Text = "Enter Range of Values to Guess";
            this.questionLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // lowNumberLabel
            // 
            this.lowNumberLabel.AutoSize = true;
            this.lowNumberLabel.Location = new System.Drawing.Point(23, 66);
            this.lowNumberLabel.Name = "lowNumberLabel";
            this.lowNumberLabel.Size = new System.Drawing.Size(70, 13);
            this.lowNumberLabel.TabIndex = 1;
            this.lowNumberLabel.Text = "Low Number:";
            // 
            // highNumberLabel
            // 
            this.highNumberLabel.AutoSize = true;
            this.highNumberLabel.Location = new System.Drawing.Point(23, 98);
            this.highNumberLabel.Name = "highNumberLabel";
            this.highNumberLabel.Size = new System.Drawing.Size(72, 13);
            this.highNumberLabel.TabIndex = 2;
            this.highNumberLabel.Text = "High Number:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(115, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(115, 98);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(82, 145);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 5;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            // 
            // GuessingGameForm
            // 
            this.AcceptButton = this.startButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 189);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.highNumberLabel);
            this.Controls.Add(this.lowNumberLabel);
            this.Controls.Add(this.questionLabel);
            this.Name = "GuessingGameForm";
            this.Text = "Guessing Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Label lowNumberLabel;
        private System.Windows.Forms.Label highNumberLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button startButton;
    }
}

