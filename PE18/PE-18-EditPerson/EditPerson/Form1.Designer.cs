namespace EditPerson
{
    partial class PersonEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonEditForm));
            this.typeLabel = new System.Windows.Forms.Label();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameText = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.emailText = new System.Windows.Forms.TextBox();
            this.ageLabel = new System.Windows.Forms.Label();
            this.ageText = new System.Windows.Forms.TextBox();
            this.licLabel = new System.Windows.Forms.Label();
            this.licText = new System.Windows.Forms.TextBox();
            this.specialtyLabel = new System.Windows.Forms.Label();
            this.specText = new System.Windows.Forms.TextBox();
            this.gpaLabel = new System.Windows.Forms.Label();
            this.gpaText = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.himRadioButton = new System.Windows.Forms.RadioButton();
            this.herRadioButton = new System.Windows.Forms.RadioButton();
            this.themRadioButton = new System.Windows.Forms.RadioButton();
            this.froshRadioButton = new System.Windows.Forms.RadioButton();
            this.sophRadioButton = new System.Windows.Forms.RadioButton();
            this.juniorRadioButton = new System.Windows.Forms.RadioButton();
            this.seniorRadioButton = new System.Windows.Forms.RadioButton();
            this.genderGroupBox = new System.Windows.Forms.GroupBox();
            this.classGroupBox = new System.Windows.Forms.GroupBox();
            this.classOfLabel = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.genderGroupBox.SuspendLayout();
            this.classGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // typeLabel
            // 
            this.typeLabel.BackColor = System.Drawing.Color.Transparent;
            this.typeLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(71)))), ((int)(((byte)(73)))));
            this.typeLabel.Location = new System.Drawing.Point(11, 30);
            this.typeLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(94, 19);
            this.typeLabel.TabIndex = 0;
            this.typeLabel.Text = "Person type:";
            // 
            // typeComboBox
            // 
            this.typeComboBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.typeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Items.AddRange(new object[] {
            "Student",
            "Teacher"});
            this.typeComboBox.Location = new System.Drawing.Point(106, 26);
            this.typeComboBox.Margin = new System.Windows.Forms.Padding(5);
            this.typeComboBox.MaxDropDownItems = 2;
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(157, 30);
            this.typeComboBox.TabIndex = 0;
            // 
            // nameLabel
            // 
            this.nameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(71)))), ((int)(((byte)(73)))));
            this.nameLabel.Location = new System.Drawing.Point(11, 81);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(94, 19);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name:";
            // 
            // nameText
            // 
            this.nameText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.nameText.Location = new System.Drawing.Point(106, 77);
            this.nameText.Margin = new System.Windows.Forms.Padding(5);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(275, 29);
            this.nameText.TabIndex = 1;
            // 
            // emailLabel
            // 
            this.emailLabel.BackColor = System.Drawing.Color.Transparent;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(71)))), ((int)(((byte)(73)))));
            this.emailLabel.Location = new System.Drawing.Point(11, 134);
            this.emailLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(94, 19);
            this.emailLabel.TabIndex = 2;
            this.emailLabel.Text = "Email:";
            // 
            // emailText
            // 
            this.emailText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.emailText.Location = new System.Drawing.Point(106, 131);
            this.emailText.Margin = new System.Windows.Forms.Padding(5);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(468, 29);
            this.emailText.TabIndex = 2;
            // 
            // ageLabel
            // 
            this.ageLabel.BackColor = System.Drawing.Color.Transparent;
            this.ageLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(71)))), ((int)(((byte)(73)))));
            this.ageLabel.Location = new System.Drawing.Point(11, 191);
            this.ageLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(94, 19);
            this.ageLabel.TabIndex = 3;
            this.ageLabel.Text = "Age:";
            // 
            // ageText
            // 
            this.ageText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ageText.Location = new System.Drawing.Point(106, 188);
            this.ageText.Margin = new System.Windows.Forms.Padding(5);
            this.ageText.Name = "ageText";
            this.ageText.Size = new System.Drawing.Size(78, 29);
            this.ageText.TabIndex = 3;
            // 
            // licLabel
            // 
            this.licLabel.BackColor = System.Drawing.Color.Transparent;
            this.licLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.licLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(71)))), ((int)(((byte)(73)))));
            this.licLabel.Location = new System.Drawing.Point(11, 249);
            this.licLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.licLabel.Name = "licLabel";
            this.licLabel.Size = new System.Drawing.Size(94, 19);
            this.licLabel.TabIndex = 4;
            this.licLabel.Text = "License Id:";
            this.licLabel.Click += new System.EventHandler(this.licLabel_Click);
            // 
            // licText
            // 
            this.licText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.licText.Location = new System.Drawing.Point(106, 247);
            this.licText.Margin = new System.Windows.Forms.Padding(5);
            this.licText.Name = "licText";
            this.licText.Size = new System.Drawing.Size(157, 29);
            this.licText.TabIndex = 4;
            // 
            // specialtyLabel
            // 
            this.specialtyLabel.BackColor = System.Drawing.Color.Transparent;
            this.specialtyLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(71)))), ((int)(((byte)(73)))));
            this.specialtyLabel.Location = new System.Drawing.Point(11, 306);
            this.specialtyLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.specialtyLabel.Name = "specialtyLabel";
            this.specialtyLabel.Size = new System.Drawing.Size(94, 19);
            this.specialtyLabel.TabIndex = 5;
            this.specialtyLabel.Text = "Specialty:";
            // 
            // specText
            // 
            this.specText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.specText.Location = new System.Drawing.Point(106, 303);
            this.specText.Margin = new System.Windows.Forms.Padding(5);
            this.specText.Name = "specText";
            this.specText.Size = new System.Drawing.Size(468, 29);
            this.specText.TabIndex = 5;
            // 
            // gpaLabel
            // 
            this.gpaLabel.BackColor = System.Drawing.Color.Transparent;
            this.gpaLabel.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpaLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(13)))), ((int)(((byte)(48)))));
            this.gpaLabel.Location = new System.Drawing.Point(11, 306);
            this.gpaLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.gpaLabel.Name = "gpaLabel";
            this.gpaLabel.Size = new System.Drawing.Size(80, 19);
            this.gpaLabel.TabIndex = 6;
            this.gpaLabel.Text = "GPA:";
            // 
            // gpaText
            // 
            this.gpaText.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.gpaText.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpaText.ForeColor = System.Drawing.SystemColors.WindowText;
            this.gpaText.Location = new System.Drawing.Point(106, 303);
            this.gpaText.Margin = new System.Windows.Forms.Padding(5);
            this.gpaText.Name = "gpaText";
            this.gpaText.Size = new System.Drawing.Size(78, 29);
            this.gpaText.TabIndex = 5;
            // 
            // okButton
            // 
            this.okButton.ForeColor = System.Drawing.Color.Green;
            this.okButton.Location = new System.Drawing.Point(375, 355);
            this.okButton.Margin = new System.Windows.Forms.Padding(5);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(74, 36);
            this.okButton.TabIndex = 6;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.CausesValidation = false;
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(590, 355);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(5);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(74, 36);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // himRadioButton
            // 
            this.himRadioButton.AutoSize = true;
            this.himRadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(71)))), ((int)(((byte)(73)))));
            this.himRadioButton.Location = new System.Drawing.Point(7, 27);
            this.himRadioButton.Margin = new System.Windows.Forms.Padding(5);
            this.himRadioButton.Name = "himRadioButton";
            this.himRadioButton.Size = new System.Drawing.Size(67, 28);
            this.himRadioButton.TabIndex = 8;
            this.himRadioButton.TabStop = true;
            this.himRadioButton.Text = "Him";
            this.himRadioButton.UseVisualStyleBackColor = true;
            // 
            // herRadioButton
            // 
            this.herRadioButton.AutoSize = true;
            this.herRadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(71)))), ((int)(((byte)(73)))));
            this.herRadioButton.Location = new System.Drawing.Point(7, 57);
            this.herRadioButton.Margin = new System.Windows.Forms.Padding(5);
            this.herRadioButton.Name = "herRadioButton";
            this.herRadioButton.Size = new System.Drawing.Size(62, 28);
            this.herRadioButton.TabIndex = 9;
            this.herRadioButton.TabStop = true;
            this.herRadioButton.Text = "Her";
            this.herRadioButton.UseVisualStyleBackColor = true;
            this.herRadioButton.CheckedChanged += new System.EventHandler(this.herRadioButton_CheckedChanged);
            // 
            // themRadioButton
            // 
            this.themRadioButton.AutoSize = true;
            this.themRadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(71)))), ((int)(((byte)(73)))));
            this.themRadioButton.Location = new System.Drawing.Point(7, 87);
            this.themRadioButton.Margin = new System.Windows.Forms.Padding(5);
            this.themRadioButton.Name = "themRadioButton";
            this.themRadioButton.Size = new System.Drawing.Size(80, 28);
            this.themRadioButton.TabIndex = 10;
            this.themRadioButton.TabStop = true;
            this.themRadioButton.Text = "Them";
            this.themRadioButton.UseVisualStyleBackColor = true;
            this.themRadioButton.CheckedChanged += new System.EventHandler(this.themRadioButton_CheckedChanged);
            // 
            // froshRadioButton
            // 
            this.froshRadioButton.AutoSize = true;
            this.froshRadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(71)))), ((int)(((byte)(73)))));
            this.froshRadioButton.Location = new System.Drawing.Point(8, 24);
            this.froshRadioButton.Margin = new System.Windows.Forms.Padding(5);
            this.froshRadioButton.Name = "froshRadioButton";
            this.froshRadioButton.Size = new System.Drawing.Size(114, 28);
            this.froshRadioButton.TabIndex = 11;
            this.froshRadioButton.TabStop = true;
            this.froshRadioButton.Text = "Freshman";
            this.froshRadioButton.UseVisualStyleBackColor = true;
            // 
            // sophRadioButton
            // 
            this.sophRadioButton.AutoSize = true;
            this.sophRadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(71)))), ((int)(((byte)(73)))));
            this.sophRadioButton.Location = new System.Drawing.Point(8, 57);
            this.sophRadioButton.Margin = new System.Windows.Forms.Padding(5);
            this.sophRadioButton.Name = "sophRadioButton";
            this.sophRadioButton.Size = new System.Drawing.Size(130, 28);
            this.sophRadioButton.TabIndex = 12;
            this.sophRadioButton.TabStop = true;
            this.sophRadioButton.Text = "Sophomore";
            this.sophRadioButton.UseVisualStyleBackColor = true;
            // 
            // juniorRadioButton
            // 
            this.juniorRadioButton.AutoSize = true;
            this.juniorRadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(71)))), ((int)(((byte)(73)))));
            this.juniorRadioButton.Location = new System.Drawing.Point(8, 90);
            this.juniorRadioButton.Margin = new System.Windows.Forms.Padding(5);
            this.juniorRadioButton.Name = "juniorRadioButton";
            this.juniorRadioButton.Size = new System.Drawing.Size(84, 28);
            this.juniorRadioButton.TabIndex = 13;
            this.juniorRadioButton.TabStop = true;
            this.juniorRadioButton.Text = "Junior";
            this.juniorRadioButton.UseVisualStyleBackColor = true;
            this.juniorRadioButton.CheckedChanged += new System.EventHandler(this.juniorRadioButton_CheckedChanged);
            // 
            // seniorRadioButton
            // 
            this.seniorRadioButton.AutoSize = true;
            this.seniorRadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(71)))), ((int)(((byte)(73)))));
            this.seniorRadioButton.Location = new System.Drawing.Point(8, 125);
            this.seniorRadioButton.Margin = new System.Windows.Forms.Padding(5);
            this.seniorRadioButton.Name = "seniorRadioButton";
            this.seniorRadioButton.Size = new System.Drawing.Size(85, 28);
            this.seniorRadioButton.TabIndex = 14;
            this.seniorRadioButton.TabStop = true;
            this.seniorRadioButton.Text = "Senior";
            this.seniorRadioButton.UseVisualStyleBackColor = true;
            // 
            // genderGroupBox
            // 
            this.genderGroupBox.Controls.Add(this.themRadioButton);
            this.genderGroupBox.Controls.Add(this.himRadioButton);
            this.genderGroupBox.Controls.Add(this.herRadioButton);
            this.genderGroupBox.Location = new System.Drawing.Point(606, 77);
            this.genderGroupBox.Margin = new System.Windows.Forms.Padding(5);
            this.genderGroupBox.Name = "genderGroupBox";
            this.genderGroupBox.Padding = new System.Windows.Forms.Padding(5);
            this.genderGroupBox.Size = new System.Drawing.Size(120, 132);
            this.genderGroupBox.TabIndex = 6;
            this.genderGroupBox.TabStop = false;
            this.genderGroupBox.Text = "Gender";
            // 
            // classGroupBox
            // 
            this.classGroupBox.Controls.Add(this.classOfLabel);
            this.classGroupBox.Controls.Add(this.sophRadioButton);
            this.classGroupBox.Controls.Add(this.froshRadioButton);
            this.classGroupBox.Controls.Add(this.seniorRadioButton);
            this.classGroupBox.Controls.Add(this.juniorRadioButton);
            this.classGroupBox.Location = new System.Drawing.Point(768, 77);
            this.classGroupBox.Margin = new System.Windows.Forms.Padding(5);
            this.classGroupBox.Name = "classGroupBox";
            this.classGroupBox.Padding = new System.Windows.Forms.Padding(5);
            this.classGroupBox.Size = new System.Drawing.Size(207, 198);
            this.classGroupBox.TabIndex = 7;
            this.classGroupBox.TabStop = false;
            this.classGroupBox.Text = "Class";
            this.classGroupBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // classOfLabel
            // 
            this.classOfLabel.AutoSize = true;
            this.classOfLabel.Location = new System.Drawing.Point(57, 160);
            this.classOfLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.classOfLabel.Name = "classOfLabel";
            this.classOfLabel.Size = new System.Drawing.Size(120, 24);
            this.classOfLabel.TabIndex = 15;
            this.classOfLabel.Text = "Class of 9999";
            this.classOfLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.classOfLabel.Click += new System.EventHandler(this.classOfLabel_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // PersonEditForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(234)))), ((int)(((byte)(212)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(1093, 625);
            this.Controls.Add(this.classGroupBox);
            this.Controls.Add(this.genderGroupBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.gpaText);
            this.Controls.Add(this.specText);
            this.Controls.Add(this.specialtyLabel);
            this.Controls.Add(this.licText);
            this.Controls.Add(this.licLabel);
            this.Controls.Add(this.ageText);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.emailText);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.gpaLabel);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(13)))), ((int)(((byte)(48)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1115, 677);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(610, 444);
            this.Name = "PersonEditForm";
            this.Text = "Edit Person";
            this.Load += new System.EventHandler(this.PersonEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.genderGroupBox.ResumeLayout(false);
            this.genderGroupBox.PerformLayout();
            this.classGroupBox.ResumeLayout(false);
            this.classGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox emailText;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.TextBox ageText;
        private System.Windows.Forms.Label licLabel;
        private System.Windows.Forms.TextBox licText;
        private System.Windows.Forms.Label specialtyLabel;
        private System.Windows.Forms.TextBox specText;
        private System.Windows.Forms.Label gpaLabel;
        private System.Windows.Forms.TextBox gpaText;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.RadioButton juniorRadioButton;
        private System.Windows.Forms.RadioButton sophRadioButton;
        private System.Windows.Forms.RadioButton froshRadioButton;
        private System.Windows.Forms.RadioButton themRadioButton;
        private System.Windows.Forms.RadioButton herRadioButton;
        private System.Windows.Forms.RadioButton himRadioButton;
        private System.Windows.Forms.RadioButton seniorRadioButton;
        private System.Windows.Forms.GroupBox genderGroupBox;
        private System.Windows.Forms.GroupBox classGroupBox;
        private System.Windows.Forms.Label classOfLabel;
        private System.Windows.Forms.ImageList imageList1;
    }
}

