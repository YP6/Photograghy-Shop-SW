
namespace Photography_Shop
{
    partial class SelectUserFormcs
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
            this.clientID = new System.Windows.Forms.ComboBox();
            this.clientIdLabel = new System.Windows.Forms.Label();
            this.phoneNumber = new System.Windows.Forms.TextBox();
            this.Emailtxtbox = new System.Windows.Forms.TextBox();
            this.gender = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.genderLabel = new System.Windows.Forms.Label();
            this.age = new System.Windows.Forms.TextBox();
            this.agelabel = new System.Windows.Forms.Label();
            this.Backbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clientID
            // 
            this.clientID.FormattingEnabled = true;
            this.clientID.Location = new System.Drawing.Point(135, 38);
            this.clientID.Name = "clientID";
            this.clientID.Size = new System.Drawing.Size(157, 24);
            this.clientID.TabIndex = 0;
            this.clientID.SelectedIndexChanged += new System.EventHandler(this.clientID_SelectedIndexChanged);
            // 
            // clientIdLabel
            // 
            this.clientIdLabel.AutoSize = true;
            this.clientIdLabel.BackColor = System.Drawing.Color.Transparent;
            this.clientIdLabel.Location = new System.Drawing.Point(31, 38);
            this.clientIdLabel.Name = "clientIdLabel";
            this.clientIdLabel.Size = new System.Drawing.Size(58, 17);
            this.clientIdLabel.TabIndex = 1;
            this.clientIdLabel.Text = "Client id";
            // 
            // phoneNumber
            // 
            this.phoneNumber.Location = new System.Drawing.Point(553, 135);
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.Size = new System.Drawing.Size(149, 22);
            this.phoneNumber.TabIndex = 2;
            // 
            // Emailtxtbox
            // 
            this.Emailtxtbox.Location = new System.Drawing.Point(553, 40);
            this.Emailtxtbox.Name = "Emailtxtbox";
            this.Emailtxtbox.Size = new System.Drawing.Size(149, 22);
            this.Emailtxtbox.TabIndex = 3;
            // 
            // gender
            // 
            this.gender.Location = new System.Drawing.Point(553, 91);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(149, 22);
            this.gender.TabIndex = 4;
            this.gender.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(135, 88);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(149, 22);
            this.name.TabIndex = 5;
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.BackColor = System.Drawing.Color.Transparent;
            this.PhoneNumberLabel.Location = new System.Drawing.Point(432, 140);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(103, 17);
            this.PhoneNumberLabel.TabIndex = 6;
            this.PhoneNumberLabel.Text = "Phone Number";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel.Location = new System.Drawing.Point(40, 91);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(49, 17);
            this.nameLabel.TabIndex = 7;
            this.nameLabel.Text = "Name ";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.BackColor = System.Drawing.Color.Transparent;
            this.emailLabel.Location = new System.Drawing.Point(438, 45);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(97, 17);
            this.emailLabel.TabIndex = 8;
            this.emailLabel.Text = "Email address";
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.BackColor = System.Drawing.Color.Transparent;
            this.genderLabel.Location = new System.Drawing.Point(479, 96);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(56, 17);
            this.genderLabel.TabIndex = 9;
            this.genderLabel.Text = "Gender";
            // 
            // age
            // 
            this.age.Location = new System.Drawing.Point(135, 135);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(149, 22);
            this.age.TabIndex = 10;
            // 
            // agelabel
            // 
            this.agelabel.AutoSize = true;
            this.agelabel.BackColor = System.Drawing.Color.Transparent;
            this.agelabel.Location = new System.Drawing.Point(56, 135);
            this.agelabel.Name = "agelabel";
            this.agelabel.Size = new System.Drawing.Size(33, 17);
            this.agelabel.TabIndex = 11;
            this.agelabel.Text = "Age";
            // 
            // Backbtn
            // 
            this.Backbtn.Location = new System.Drawing.Point(650, 492);
            this.Backbtn.Name = "Backbtn";
            this.Backbtn.Size = new System.Drawing.Size(120, 49);
            this.Backbtn.TabIndex = 12;
            this.Backbtn.Text = "Back";
            this.Backbtn.UseVisualStyleBackColor = true;
            this.Backbtn.Click += new System.EventHandler(this.Backbtn_Click);
            // 
            // SelectUserFormcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Photography_Shop.Properties.Resources.MakeReservationBackGround;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.Backbtn);
            this.Controls.Add(this.agelabel);
            this.Controls.Add(this.age);
            this.Controls.Add(this.genderLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.PhoneNumberLabel);
            this.Controls.Add(this.name);
            this.Controls.Add(this.gender);
            this.Controls.Add(this.Emailtxtbox);
            this.Controls.Add(this.phoneNumber);
            this.Controls.Add(this.clientIdLabel);
            this.Controls.Add(this.clientID);
            this.Name = "SelectUserFormcs";
            this.Text = "SelectUserFormcs";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SelectUserFormcs_FormClosed);
            this.Load += new System.EventHandler(this.SelectUserFormcs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox clientID;
        private System.Windows.Forms.Label clientIdLabel;
        private System.Windows.Forms.TextBox phoneNumber;
        private System.Windows.Forms.TextBox Emailtxtbox;
        private System.Windows.Forms.TextBox gender;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label PhoneNumberLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.TextBox age;
        private System.Windows.Forms.Label agelabel;
        private System.Windows.Forms.Button Backbtn;
    }
}