
namespace crystalReportPhotography
{
    partial class ClientsReservationReportForm
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
            this.ClientsReservationsViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.DisplayButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ClientsReservationsViewer
            // 
            this.ClientsReservationsViewer.ActiveViewIndex = -1;
            this.ClientsReservationsViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ClientsReservationsViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.ClientsReservationsViewer.Location = new System.Drawing.Point(12, 13);
            this.ClientsReservationsViewer.Name = "ClientsReservationsViewer";
            this.ClientsReservationsViewer.Size = new System.Drawing.Size(982, 436);
            this.ClientsReservationsViewer.TabIndex = 0;
            this.ClientsReservationsViewer.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // DisplayButton
            // 
            this.DisplayButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DisplayButton.Location = new System.Drawing.Point(0, 456);
            this.DisplayButton.Name = "DisplayButton";
            this.DisplayButton.Size = new System.Drawing.Size(1006, 33);
            this.DisplayButton.TabIndex = 1;
            this.DisplayButton.Text = "Display Clients Reservations";
            this.DisplayButton.UseVisualStyleBackColor = true;
            this.DisplayButton.Click += new System.EventHandler(this.DisplayButton_Click);
            // 
            // ClientsReservationReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Photography_Shop.Properties.Resources.MakeReservationBackGround;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1006, 489);
            this.Controls.Add(this.DisplayButton);
            this.Controls.Add(this.ClientsReservationsViewer);
            this.Name = "ClientsReservationReportForm";
            this.Text = "ClientsReservationReportForm";
            this.Load += new System.EventHandler(this.ClientsReservationReportForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer ClientsReservationsViewer;
        private System.Windows.Forms.Button DisplayButton;
    }
}