
namespace Photography_Shop
{
    partial class MakeReservationForm
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
            this.ClientIDsComboBox = new System.Windows.Forms.ComboBox();
            this.ClientIdLabel = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.datelabel = new System.Windows.Forms.Label();
            this.btn_insert = new System.Windows.Forms.Button();
            this.back_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ClientIDsComboBox
            // 
            this.ClientIDsComboBox.FormattingEnabled = true;
            this.ClientIDsComboBox.Location = new System.Drawing.Point(285, 117);
            this.ClientIDsComboBox.Name = "ClientIDsComboBox";
            this.ClientIDsComboBox.Size = new System.Drawing.Size(200, 24);
            this.ClientIDsComboBox.TabIndex = 0;
            // 
            // ClientIdLabel
            // 
            this.ClientIdLabel.AutoSize = true;
            this.ClientIdLabel.Location = new System.Drawing.Point(176, 124);
            this.ClientIdLabel.Name = "ClientIdLabel";
            this.ClientIdLabel.Size = new System.Drawing.Size(60, 17);
            this.ClientIdLabel.TabIndex = 1;
            this.ClientIdLabel.Text = "Client ID";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(285, 198);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker.TabIndex = 2;
            // 
            // datelabel
            // 
            this.datelabel.AutoSize = true;
            this.datelabel.Location = new System.Drawing.Point(187, 203);
            this.datelabel.Name = "datelabel";
            this.datelabel.Size = new System.Drawing.Size(38, 17);
            this.datelabel.TabIndex = 3;
            this.datelabel.Text = "Date";
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(329, 287);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(89, 40);
            this.btn_insert.TabIndex = 4;
            this.btn_insert.Text = "Insert";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.back_btn.Location = new System.Drawing.Point(641, 489);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(129, 52);
            this.back_btn.TabIndex = 5;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // MakeReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Photography_Shop.Properties.Resources.MakeReservationBackGround;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.datelabel);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.ClientIdLabel);
            this.Controls.Add(this.ClientIDsComboBox);
            this.Name = "MakeReservationForm";
            this.Text = "MakeReservationForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MakeReservationForm_FormClosed);
            this.Load += new System.EventHandler(this.MakeReservationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ClientIDsComboBox;
        private System.Windows.Forms.Label ClientIdLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label datelabel;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Button back_btn;
    }
}

