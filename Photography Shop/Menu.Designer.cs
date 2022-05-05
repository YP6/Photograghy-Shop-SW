
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
            this.SuspendLayout();
            // 
            // MakeReservation
            // 
            this.MakeReservation.BackColor = System.Drawing.Color.Transparent;
            this.MakeReservation.Location = new System.Drawing.Point(308, 165);
            this.MakeReservation.Name = "MakeReservation";
            this.MakeReservation.Size = new System.Drawing.Size(146, 47);
            this.MakeReservation.TabIndex = 0;
            this.MakeReservation.Text = "Make Reservation";
            this.MakeReservation.UseVisualStyleBackColor = false;
            this.MakeReservation.Click += new System.EventHandler(this.MakeReservation_Click);
            // 
            // takeReservation
            // 
            this.takeReservation.BackColor = System.Drawing.Color.Transparent;
            this.takeReservation.Location = new System.Drawing.Point(308, 248);
            this.takeReservation.Name = "takeReservation";
            this.takeReservation.Size = new System.Drawing.Size(146, 47);
            this.takeReservation.TabIndex = 1;
            this.takeReservation.Text = "Take Reservation";
            this.takeReservation.UseVisualStyleBackColor = false;
            this.takeReservation.Click += new System.EventHandler(this.takeReservation_Click);
            // 
            // selectClientInfos
            // 
            this.selectClientInfos.BackColor = System.Drawing.Color.Transparent;
            this.selectClientInfos.Location = new System.Drawing.Point(308, 317);
            this.selectClientInfos.Name = "selectClientInfos";
            this.selectClientInfos.Size = new System.Drawing.Size(146, 47);
            this.selectClientInfos.TabIndex = 2;
            this.selectClientInfos.Text = "Select Client information";
            this.selectClientInfos.UseVisualStyleBackColor = false;
            this.selectClientInfos.Click += new System.EventHandler(this.selectClientInfos_Click);
            // 
            // selectPhotoGrapherInfos
            // 
            this.selectPhotoGrapherInfos.BackColor = System.Drawing.Color.Transparent;
            this.selectPhotoGrapherInfos.Location = new System.Drawing.Point(308, 400);
            this.selectPhotoGrapherInfos.Name = "selectPhotoGrapherInfos";
            this.selectPhotoGrapherInfos.Size = new System.Drawing.Size(146, 47);
            this.selectPhotoGrapherInfos.TabIndex = 3;
            this.selectPhotoGrapherInfos.Text = "Select Photographer information";
            this.selectPhotoGrapherInfos.UseVisualStyleBackColor = false;
            this.selectPhotoGrapherInfos.Click += new System.EventHandler(this.selectPhotoGrapherInfos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(595, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "Welcome to YP7 photography shop";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Photography_Shop.Properties.Resources.MakeReservationBackGround;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selectPhotoGrapherInfos);
            this.Controls.Add(this.selectClientInfos);
            this.Controls.Add(this.takeReservation);
            this.Controls.Add(this.MakeReservation);
            this.Name = "Menu";
            this.Text = "Menu";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MakeReservation;
        private System.Windows.Forms.Button takeReservation;
        private System.Windows.Forms.Button selectClientInfos;
        private System.Windows.Forms.Button selectPhotoGrapherInfos;
        private System.Windows.Forms.Label label1;
    }
}