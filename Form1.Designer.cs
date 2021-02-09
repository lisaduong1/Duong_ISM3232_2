namespace Duong_2
{
    partial class Form1
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.termGroupBox = new System.Windows.Forms.GroupBox();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.springRadioButton = new System.Windows.Forms.RadioButton();
            this.fallRadioButton = new System.Windows.Forms.RadioButton();
            this.studentGroupBox = new System.Windows.Forms.GroupBox();
            this.outOfStateRadioButton = new System.Windows.Forms.RadioButton();
            this.inStateRadioButton = new System.Windows.Forms.RadioButton();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.idMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.courseOrderInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.spanishCheckBox = new System.Windows.Forms.CheckBox();
            this.russianCheckBox = new System.Windows.Forms.CheckBox();
            this.italianCheckBox = new System.Windows.Forms.CheckBox();
            this.germanCheckBox = new System.Windows.Forms.CheckBox();
            this.frenchCheckBox = new System.Windows.Forms.CheckBox();
            this.coursesLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.paymentInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.expDateLabel = new System.Windows.Forms.Label();
            this.dateTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cardNumberLabel = new System.Windows.Forms.Label();
            this.cardTextBox = new System.Windows.Forms.TextBox();
            this.visaRadioButton = new System.Windows.Forms.RadioButton();
            this.masterCardRadioButton = new System.Windows.Forms.RadioButton();
            this.saveButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.termGroupBox.SuspendLayout();
            this.studentGroupBox.SuspendLayout();
            this.courseOrderInfoGroupBox.SuspendLayout();
            this.paymentInfoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::Duong_2.Properties.Resources.lang03_628px_ch;
            this.pictureBox.Location = new System.Drawing.Point(83, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(539, 69);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // termGroupBox
            // 
            this.termGroupBox.Controls.Add(this.comboBox);
            this.termGroupBox.Controls.Add(this.springRadioButton);
            this.termGroupBox.Controls.Add(this.fallRadioButton);
            this.termGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.termGroupBox.Location = new System.Drawing.Point(12, 87);
            this.termGroupBox.Name = "termGroupBox";
            this.termGroupBox.Size = new System.Drawing.Size(680, 69);
            this.termGroupBox.TabIndex = 1;
            this.termGroupBox.TabStop = false;
            this.termGroupBox.Text = "Term Information";
            // 
            // comboBox
            // 
            this.comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023"});
            this.comboBox.Location = new System.Drawing.Point(509, 31);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(101, 28);
            this.comboBox.TabIndex = 2;
            // 
            // springRadioButton
            // 
            this.springRadioButton.AutoSize = true;
            this.springRadioButton.Location = new System.Drawing.Point(303, 32);
            this.springRadioButton.Name = "springRadioButton";
            this.springRadioButton.Size = new System.Drawing.Size(78, 24);
            this.springRadioButton.TabIndex = 1;
            this.springRadioButton.Text = "Spring";
            this.springRadioButton.UseVisualStyleBackColor = true;
            // 
            // fallRadioButton
            // 
            this.fallRadioButton.AutoSize = true;
            this.fallRadioButton.Checked = true;
            this.fallRadioButton.Location = new System.Drawing.Point(106, 32);
            this.fallRadioButton.Name = "fallRadioButton";
            this.fallRadioButton.Size = new System.Drawing.Size(57, 24);
            this.fallRadioButton.TabIndex = 0;
            this.fallRadioButton.TabStop = true;
            this.fallRadioButton.Text = "Fall";
            this.fallRadioButton.UseVisualStyleBackColor = true;
            // 
            // studentGroupBox
            // 
            this.studentGroupBox.Controls.Add(this.outOfStateRadioButton);
            this.studentGroupBox.Controls.Add(this.inStateRadioButton);
            this.studentGroupBox.Controls.Add(this.emailTextBox);
            this.studentGroupBox.Controls.Add(this.emailLabel);
            this.studentGroupBox.Controls.Add(this.lastNameTextBox);
            this.studentGroupBox.Controls.Add(this.firstNameTextBox);
            this.studentGroupBox.Controls.Add(this.lastNameLabel);
            this.studentGroupBox.Controls.Add(this.firstNameLabel);
            this.studentGroupBox.Controls.Add(this.label1);
            this.studentGroupBox.Controls.Add(this.idMaskedTextBox);
            this.studentGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentGroupBox.Location = new System.Drawing.Point(12, 162);
            this.studentGroupBox.Name = "studentGroupBox";
            this.studentGroupBox.Size = new System.Drawing.Size(680, 135);
            this.studentGroupBox.TabIndex = 3;
            this.studentGroupBox.TabStop = false;
            this.studentGroupBox.Text = "Student Information";
            // 
            // outOfStateRadioButton
            // 
            this.outOfStateRadioButton.AutoSize = true;
            this.outOfStateRadioButton.Location = new System.Drawing.Point(339, 99);
            this.outOfStateRadioButton.Name = "outOfStateRadioButton";
            this.outOfStateRadioButton.Size = new System.Drawing.Size(126, 24);
            this.outOfStateRadioButton.TabIndex = 9;
            this.outOfStateRadioButton.Text = "Out-Of-State";
            this.outOfStateRadioButton.UseVisualStyleBackColor = true;
            this.outOfStateRadioButton.CheckedChanged += new System.EventHandler(this.CheckChange);
            // 
            // inStateRadioButton
            // 
            this.inStateRadioButton.AutoSize = true;
            this.inStateRadioButton.Checked = true;
            this.inStateRadioButton.Location = new System.Drawing.Point(339, 66);
            this.inStateRadioButton.Name = "inStateRadioButton";
            this.inStateRadioButton.Size = new System.Drawing.Size(88, 24);
            this.inStateRadioButton.TabIndex = 8;
            this.inStateRadioButton.TabStop = true;
            this.inStateRadioButton.Text = "In-State";
            this.inStateRadioButton.UseVisualStyleBackColor = true;
            this.inStateRadioButton.CheckedChanged += new System.EventHandler(this.CheckChange);
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(408, 32);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(232, 27);
            this.emailTextBox.TabIndex = 7;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(335, 35);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(56, 20);
            this.emailLabel.TabIndex = 6;
            this.emailLabel.Text = "Email:";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(152, 98);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(128, 27);
            this.lastNameTextBox.TabIndex = 5;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(152, 65);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(128, 27);
            this.firstNameTextBox.TabIndex = 4;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(35, 101);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(96, 20);
            this.lastNameLabel.TabIndex = 3;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(35, 68);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(97, 20);
            this.firstNameLabel.TabIndex = 2;
            this.firstNameLabel.Text = "First Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Student ID:";
            // 
            // idMaskedTextBox
            // 
            this.idMaskedTextBox.Location = new System.Drawing.Point(152, 32);
            this.idMaskedTextBox.Mask = "000-00-0000";
            this.idMaskedTextBox.Name = "idMaskedTextBox";
            this.idMaskedTextBox.Size = new System.Drawing.Size(128, 27);
            this.idMaskedTextBox.TabIndex = 0;
            this.idMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // courseOrderInfoGroupBox
            // 
            this.courseOrderInfoGroupBox.Controls.Add(this.spanishCheckBox);
            this.courseOrderInfoGroupBox.Controls.Add(this.russianCheckBox);
            this.courseOrderInfoGroupBox.Controls.Add(this.italianCheckBox);
            this.courseOrderInfoGroupBox.Controls.Add(this.germanCheckBox);
            this.courseOrderInfoGroupBox.Controls.Add(this.frenchCheckBox);
            this.courseOrderInfoGroupBox.Controls.Add(this.coursesLabel);
            this.courseOrderInfoGroupBox.Controls.Add(this.totalLabel);
            this.courseOrderInfoGroupBox.Controls.Add(this.priceLabel);
            this.courseOrderInfoGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseOrderInfoGroupBox.Location = new System.Drawing.Point(12, 303);
            this.courseOrderInfoGroupBox.Name = "courseOrderInfoGroupBox";
            this.courseOrderInfoGroupBox.Size = new System.Drawing.Size(680, 193);
            this.courseOrderInfoGroupBox.TabIndex = 4;
            this.courseOrderInfoGroupBox.TabStop = false;
            this.courseOrderInfoGroupBox.Text = "Course Order Information";
            this.courseOrderInfoGroupBox.Enter += new System.EventHandler(this.courseOrderInfoGroupBox_Enter);
            // 
            // spanishCheckBox
            // 
            this.spanishCheckBox.AutoSize = true;
            this.spanishCheckBox.Location = new System.Drawing.Point(38, 151);
            this.spanishCheckBox.Name = "spanishCheckBox";
            this.spanishCheckBox.Size = new System.Drawing.Size(170, 24);
            this.spanishCheckBox.TabIndex = 8;
            this.spanishCheckBox.Text = "Beginning Spanish";
            this.spanishCheckBox.UseVisualStyleBackColor = true;
            this.spanishCheckBox.CheckedChanged += new System.EventHandler(this.CheckChange);
            // 
            // russianCheckBox
            // 
            this.russianCheckBox.AutoSize = true;
            this.russianCheckBox.Location = new System.Drawing.Point(38, 121);
            this.russianCheckBox.Name = "russianCheckBox";
            this.russianCheckBox.Size = new System.Drawing.Size(171, 24);
            this.russianCheckBox.TabIndex = 7;
            this.russianCheckBox.Text = "Beginning Russian";
            this.russianCheckBox.UseVisualStyleBackColor = true;
            this.russianCheckBox.CheckedChanged += new System.EventHandler(this.CheckChange);
            // 
            // italianCheckBox
            // 
            this.italianCheckBox.AutoSize = true;
            this.italianCheckBox.Location = new System.Drawing.Point(38, 91);
            this.italianCheckBox.Name = "italianCheckBox";
            this.italianCheckBox.Size = new System.Drawing.Size(154, 24);
            this.italianCheckBox.TabIndex = 6;
            this.italianCheckBox.Text = "Beginning Italian";
            this.italianCheckBox.UseVisualStyleBackColor = true;
            this.italianCheckBox.CheckedChanged += new System.EventHandler(this.CheckChange);
            // 
            // germanCheckBox
            // 
            this.germanCheckBox.AutoSize = true;
            this.germanCheckBox.Location = new System.Drawing.Point(38, 61);
            this.germanCheckBox.Name = "germanCheckBox";
            this.germanCheckBox.Size = new System.Drawing.Size(170, 24);
            this.germanCheckBox.TabIndex = 5;
            this.germanCheckBox.Text = "Beginning German";
            this.germanCheckBox.UseVisualStyleBackColor = true;
            this.germanCheckBox.CheckedChanged += new System.EventHandler(this.CheckChange);
            // 
            // frenchCheckBox
            // 
            this.frenchCheckBox.AutoSize = true;
            this.frenchCheckBox.Location = new System.Drawing.Point(38, 31);
            this.frenchCheckBox.Name = "frenchCheckBox";
            this.frenchCheckBox.Size = new System.Drawing.Size(162, 24);
            this.frenchCheckBox.TabIndex = 4;
            this.frenchCheckBox.Text = "Beginning French";
            this.frenchCheckBox.UseVisualStyleBackColor = true;
            this.frenchCheckBox.CheckedChanged += new System.EventHandler(this.CheckChange);
            // 
            // coursesLabel
            // 
            this.coursesLabel.AutoSize = true;
            this.coursesLabel.Location = new System.Drawing.Point(340, 110);
            this.coursesLabel.Name = "coursesLabel";
            this.coursesLabel.Size = new System.Drawing.Size(0, 20);
            this.coursesLabel.TabIndex = 3;
            this.coursesLabel.Click += new System.EventHandler(this.coursesLabel_Click);
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(340, 151);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(0, 20);
            this.totalLabel.TabIndex = 2;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(335, 25);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(290, 60);
            this.priceLabel.TabIndex = 1;
            this.priceLabel.Text = "In-state students: $49 per course\r\nOut-of-state students: $99 per course\r\n3 cours" +
    "es max per order";
            // 
            // paymentInfoGroupBox
            // 
            this.paymentInfoGroupBox.Controls.Add(this.expDateLabel);
            this.paymentInfoGroupBox.Controls.Add(this.dateTextBox);
            this.paymentInfoGroupBox.Controls.Add(this.cardNumberLabel);
            this.paymentInfoGroupBox.Controls.Add(this.cardTextBox);
            this.paymentInfoGroupBox.Controls.Add(this.visaRadioButton);
            this.paymentInfoGroupBox.Controls.Add(this.masterCardRadioButton);
            this.paymentInfoGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentInfoGroupBox.Location = new System.Drawing.Point(12, 502);
            this.paymentInfoGroupBox.Name = "paymentInfoGroupBox";
            this.paymentInfoGroupBox.Size = new System.Drawing.Size(680, 130);
            this.paymentInfoGroupBox.TabIndex = 5;
            this.paymentInfoGroupBox.TabStop = false;
            this.paymentInfoGroupBox.Text = "Payment Information";
            // 
            // expDateLabel
            // 
            this.expDateLabel.AutoSize = true;
            this.expDateLabel.Location = new System.Drawing.Point(523, 30);
            this.expDateLabel.Name = "expDateLabel";
            this.expDateLabel.Size = new System.Drawing.Size(129, 20);
            this.expDateLabel.TabIndex = 6;
            this.expDateLabel.Text = "Expiration Date:";
            // 
            // dateTextBox
            // 
            this.dateTextBox.Location = new System.Drawing.Point(527, 77);
            this.dateTextBox.Mask = "00/00/0000";
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(110, 27);
            this.dateTextBox.TabIndex = 5;
            this.dateTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dateTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // cardNumberLabel
            // 
            this.cardNumberLabel.AutoSize = true;
            this.cardNumberLabel.Location = new System.Drawing.Point(255, 32);
            this.cardNumberLabel.Name = "cardNumberLabel";
            this.cardNumberLabel.Size = new System.Drawing.Size(164, 20);
            this.cardNumberLabel.TabIndex = 4;
            this.cardNumberLabel.Text = "Credit Card Number:";
            // 
            // cardTextBox
            // 
            this.cardTextBox.Location = new System.Drawing.Point(259, 77);
            this.cardTextBox.MaxLength = 16;
            this.cardTextBox.Name = "cardTextBox";
            this.cardTextBox.Size = new System.Drawing.Size(206, 27);
            this.cardTextBox.TabIndex = 3;
            // 
            // visaRadioButton
            // 
            this.visaRadioButton.AutoSize = true;
            this.visaRadioButton.Location = new System.Drawing.Point(15, 78);
            this.visaRadioButton.Name = "visaRadioButton";
            this.visaRadioButton.Size = new System.Drawing.Size(154, 24);
            this.visaRadioButton.TabIndex = 1;
            this.visaRadioButton.Text = "Visa Credit Card";
            this.visaRadioButton.UseVisualStyleBackColor = true;
            // 
            // masterCardRadioButton
            // 
            this.masterCardRadioButton.AutoSize = true;
            this.masterCardRadioButton.Checked = true;
            this.masterCardRadioButton.Location = new System.Drawing.Point(15, 30);
            this.masterCardRadioButton.Name = "masterCardRadioButton";
            this.masterCardRadioButton.Size = new System.Drawing.Size(209, 24);
            this.masterCardRadioButton.TabIndex = 0;
            this.masterCardRadioButton.TabStop = true;
            this.masterCardRadioButton.Text = "MasterCard Credit Card";
            this.masterCardRadioButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(88, 645);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(107, 39);
            this.saveButton.TabIndex = 6;
            this.saveButton.Text = "&Save";
            this.toolTip1.SetToolTip(this.saveButton, "Click to display entire order in a message box.");
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(296, 645);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(107, 39);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "&Clear";
            this.toolTip2.SetToolTip(this.clearButton, "Click to clear all data on form.");
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(515, 645);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(107, 39);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "&Exit";
            this.toolTip3.SetToolTip(this.exitButton, "Click to exit form.");
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 689);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.paymentInfoGroupBox);
            this.Controls.Add(this.courseOrderInfoGroupBox);
            this.Controls.Add(this.studentGroupBox);
            this.Controls.Add(this.termGroupBox);
            this.Controls.Add(this.pictureBox);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LAI Order Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.termGroupBox.ResumeLayout(false);
            this.termGroupBox.PerformLayout();
            this.studentGroupBox.ResumeLayout(false);
            this.studentGroupBox.PerformLayout();
            this.courseOrderInfoGroupBox.ResumeLayout(false);
            this.courseOrderInfoGroupBox.PerformLayout();
            this.paymentInfoGroupBox.ResumeLayout(false);
            this.paymentInfoGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.GroupBox termGroupBox;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.RadioButton springRadioButton;
        private System.Windows.Forms.RadioButton fallRadioButton;
        private System.Windows.Forms.GroupBox studentGroupBox;
        private System.Windows.Forms.MaskedTextBox idMaskedTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.RadioButton outOfStateRadioButton;
        private System.Windows.Forms.RadioButton inStateRadioButton;
        private System.Windows.Forms.GroupBox courseOrderInfoGroupBox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.GroupBox paymentInfoGroupBox;
        private System.Windows.Forms.RadioButton visaRadioButton;
        private System.Windows.Forms.RadioButton masterCardRadioButton;
        private System.Windows.Forms.Label cardNumberLabel;
        private System.Windows.Forms.TextBox cardTextBox;
        private System.Windows.Forms.Label expDateLabel;
        private System.Windows.Forms.MaskedTextBox dateTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label coursesLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.CheckBox spanishCheckBox;
        private System.Windows.Forms.CheckBox russianCheckBox;
        private System.Windows.Forms.CheckBox italianCheckBox;
        private System.Windows.Forms.CheckBox germanCheckBox;
        private System.Windows.Forms.CheckBox frenchCheckBox;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
    }
}

