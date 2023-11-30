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
            this.lowTextBox = new System.Windows.Forms.TextBox();
            this.highTextBox = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.Location = new System.Drawing.Point(60, 39);
            this.questionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(197, 16);
            this.questionLabel.TabIndex = 0;
            this.questionLabel.Text = "Enter Range of Values to Guess";
            // 
            // lowNumberLabel
            // 
            this.lowNumberLabel.AutoSize = true;
            this.lowNumberLabel.Location = new System.Drawing.Point(31, 81);
            this.lowNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lowNumberLabel.Name = "lowNumberLabel";
            this.lowNumberLabel.Size = new System.Drawing.Size(85, 16);
            this.lowNumberLabel.TabIndex = 1;
            this.lowNumberLabel.Text = "Low Number:";
            // 
            // highNumberLabel
            // 
            this.highNumberLabel.AutoSize = true;
            this.highNumberLabel.Location = new System.Drawing.Point(31, 121);
            this.highNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.highNumberLabel.Name = "highNumberLabel";
            this.highNumberLabel.Size = new System.Drawing.Size(89, 16);
            this.highNumberLabel.TabIndex = 2;
            this.highNumberLabel.Text = "High Number:";
            // 
            // lowTextBox
            // 
            this.lowTextBox.Location = new System.Drawing.Point(153, 78);
            this.lowTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lowTextBox.Name = "lowTextBox";
            this.lowTextBox.Size = new System.Drawing.Size(132, 22);
            this.lowTextBox.TabIndex = 3;
            this.lowTextBox.Text = "1";
            // 
            // highTextBox
            // 
            this.highTextBox.Location = new System.Drawing.Point(153, 121);
            this.highTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.highTextBox.Name = "highTextBox";
            this.highTextBox.Size = new System.Drawing.Size(132, 22);
            this.highTextBox.TabIndex = 4;
            this.highTextBox.Text = "100";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(109, 178);
            this.startButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(100, 28);
            this.startButton.TabIndex = 5;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            // 
            // GuessingGameForm
            // 
            this.AcceptButton = this.startButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 233);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.highTextBox);
            this.Controls.Add(this.lowTextBox);
            this.Controls.Add(this.highNumberLabel);
            this.Controls.Add(this.lowNumberLabel);
            this.Controls.Add(this.questionLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GuessingGameForm";
            this.Text = "Guessing Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Label lowNumberLabel;
        private System.Windows.Forms.Label highNumberLabel;
        private System.Windows.Forms.TextBox lowTextBox;
        private System.Windows.Forms.TextBox highTextBox;
        private System.Windows.Forms.Button startButton;
    }
}

