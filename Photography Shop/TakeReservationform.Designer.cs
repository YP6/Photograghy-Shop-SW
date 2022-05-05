
namespace Photography_Shop
{
    partial class TakeReservationform
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
            this.photoGrapherIDs = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.clientsIDs = new System.Windows.Forms.ComboBox();
            this.DateComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.photoGrapherName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.clientName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Backbtn = new System.Windows.Forms.Button();
            this.TakeReservationbtn = new System.Windows.Forms.Button();
            this.cost = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // photoGrapherIDs
            // 
            this.photoGrapherIDs.FormattingEnabled = true;
            this.photoGrapherIDs.Location = new System.Drawing.Point(166, 66);
            this.photoGrapherIDs.Name = "photoGrapherIDs";
            this.photoGrapherIDs.Size = new System.Drawing.Size(156, 24);
            this.photoGrapherIDs.TabIndex = 0;
            this.photoGrapherIDs.SelectedIndexChanged += new System.EventHandler(this.photoGrapherIDs_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(25, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "PhotoGrapher ID";
            // 
            // clientsIDs
            // 
            this.clientsIDs.FormattingEnabled = true;
            this.clientsIDs.Location = new System.Drawing.Point(166, 144);
            this.clientsIDs.Name = "clientsIDs";
            this.clientsIDs.Size = new System.Drawing.Size(156, 24);
            this.clientsIDs.TabIndex = 2;
            this.clientsIDs.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // DateComboBox
            // 
            this.DateComboBox.FormattingEnabled = true;
            this.DateComboBox.Location = new System.Drawing.Point(166, 228);
            this.DateComboBox.Name = "DateComboBox";
            this.DateComboBox.Size = new System.Drawing.Size(156, 24);
            this.DateComboBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(25, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Client ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(15, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Reservation Dates";
            // 
            // photoGrapherName
            // 
            this.photoGrapherName.Location = new System.Drawing.Point(547, 64);
            this.photoGrapherName.Name = "photoGrapherName";
            this.photoGrapherName.Size = new System.Drawing.Size(163, 22);
            this.photoGrapherName.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(368, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "PhotoGrapher Name";
            // 
            // clientName
            // 
            this.clientName.Location = new System.Drawing.Point(547, 151);
            this.clientName.Name = "clientName";
            this.clientName.Size = new System.Drawing.Size(163, 22);
            this.clientName.TabIndex = 8;
            this.clientName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(423, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Client Name";
            // 
            // Backbtn
            // 
            this.Backbtn.BackColor = System.Drawing.Color.Transparent;
            this.Backbtn.Location = new System.Drawing.Point(649, 496);
            this.Backbtn.Name = "Backbtn";
            this.Backbtn.Size = new System.Drawing.Size(121, 45);
            this.Backbtn.TabIndex = 10;
            this.Backbtn.Text = "Back";
            this.Backbtn.UseVisualStyleBackColor = false;
            this.Backbtn.Click += new System.EventHandler(this.Backbtn_Click);
            // 
            // TakeReservationbtn
            // 
            this.TakeReservationbtn.BackColor = System.Drawing.Color.Transparent;
            this.TakeReservationbtn.Location = new System.Drawing.Point(28, 487);
            this.TakeReservationbtn.Name = "TakeReservationbtn";
            this.TakeReservationbtn.Size = new System.Drawing.Size(121, 45);
            this.TakeReservationbtn.TabIndex = 11;
            this.TakeReservationbtn.Text = "Take";
            this.TakeReservationbtn.UseVisualStyleBackColor = false;
            this.TakeReservationbtn.Click += new System.EventHandler(this.TakeReservationbtn_Click);
            // 
            // cost
            // 
            this.cost.Location = new System.Drawing.Point(547, 235);
            this.cost.Name = "cost";
            this.cost.Size = new System.Drawing.Size(163, 22);
            this.cost.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(471, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Cost";
            // 
            // TakeReservationform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Photography_Shop.Properties.Resources.MakeReservationBackGround;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cost);
            this.Controls.Add(this.TakeReservationbtn);
            this.Controls.Add(this.Backbtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.clientName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.photoGrapherName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DateComboBox);
            this.Controls.Add(this.clientsIDs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.photoGrapherIDs);
            this.Name = "TakeReservationform";
            this.Text = "TakeReservationform";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TakeReservationform_FormClosed);
            this.Load += new System.EventHandler(this.TakeReservationform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox photoGrapherIDs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox clientsIDs;
        private System.Windows.Forms.ComboBox DateComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox photoGrapherName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox clientName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Backbtn;
        private System.Windows.Forms.Button TakeReservationbtn;
        private System.Windows.Forms.TextBox cost;
        private System.Windows.Forms.Label label6;
    }
}