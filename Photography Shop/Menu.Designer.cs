
namespace Photography_Shop
{
    partial class Menu
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
            this.MakeReservation = new System.Windows.Forms.Button();
            this.takeReservation = new System.Windows.Forms.Button();
            this.selectClientInfos = new System.Windows.Forms.Button();
            this.selectPhotoGrapherInfos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MakeReservation
            // 
            this.MakeReservation.BackColor = System.Drawing.Color.Transparent;
            this.MakeReservation.Location = new System.Drawing.Point(231, 134);
            this.MakeReservation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MakeReservation.Name = "MakeReservation";
            this.MakeReservation.Size = new System.Drawing.Size(110, 38);
            this.MakeReservation.TabIndex = 0;
            this.MakeReservation.Text = "Make Reservation";
            this.MakeReservation.UseVisualStyleBackColor = false;
            this.MakeReservation.Click += new System.EventHandler(this.MakeReservation_Click);
            // 
            // takeReservation
            // 
            this.takeReservation.BackColor = System.Drawing.Color.Transparent;
            this.takeReservation.Location = new System.Drawing.Point(231, 202);
            this.takeReservation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.takeReservation.Name = "takeReservation";
            this.takeReservation.Size = new System.Drawing.Size(110, 38);
            this.takeReservation.TabIndex = 1;
            this.takeReservation.Text = "Take Reservation";
            this.takeReservation.UseVisualStyleBackColor = false;
            this.takeReservation.Click += new System.EventHandler(this.takeReservation_Click);
            // 
            // selectClientInfos
            // 
            this.selectClientInfos.BackColor = System.Drawing.Color.Transparent;
            this.selectClientInfos.Location = new System.Drawing.Point(231, 258);
            this.selectClientInfos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.selectClientInfos.Name = "selectClientInfos";
            this.selectClientInfos.Size = new System.Drawing.Size(110, 38);
            this.selectClientInfos.TabIndex = 2;
            this.selectClientInfos.Text = "Select Client information";
            this.selectClientInfos.UseVisualStyleBackColor = false;
            this.selectClientInfos.Click += new System.EventHandler(this.selectClientInfos_Click);
            // 
            // selectPhotoGrapherInfos
            // 
            this.selectPhotoGrapherInfos.BackColor = System.Drawing.Color.Transparent;
            this.selectPhotoGrapherInfos.Location = new System.Drawing.Point(231, 325);
            this.selectPhotoGrapherInfos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.selectPhotoGrapherInfos.Name = "selectPhotoGrapherInfos";
            this.selectPhotoGrapherInfos.Size = new System.Drawing.Size(110, 43);
            this.selectPhotoGrapherInfos.TabIndex = 3;
            this.selectPhotoGrapherInfos.Text = "View Photographers";
            this.selectPhotoGrapherInfos.UseVisualStyleBackColor = false;
            this.selectPhotoGrapherInfos.Click += new System.EventHandler(this.selectPhotoGrapherInfos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(579, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = "Welcome to YP7 photography shop";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(231, 395);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 43);
            this.button1.TabIndex = 5;
            this.button1.Text = "View All Reservations";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Photography_Shop.Properties.Resources.MakeReservationBackGround;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(586, 468);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selectPhotoGrapherInfos);
            this.Controls.Add(this.selectClientInfos);
            this.Controls.Add(this.takeReservation);
            this.Controls.Add(this.MakeReservation);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Menu";
            this.Text = "Menu";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MakeReservation;
        private System.Windows.Forms.Button takeReservation;
        private System.Windows.Forms.Button selectClientInfos;
        private System.Windows.Forms.Button selectPhotoGrapherInfos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}