using Photography_Shop;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crystalReportPhotography
{
    public partial class ClientsReservationReportForm : System.Windows.Forms.Form
    {
        ClientReservationReport CR;
        public ClientsReservationReportForm()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void ClientsReservationReportForm_Load(object sender, EventArgs e)
        {
            CR = new ClientReservationReport();
        }

        private void DisplayButton_Click(object sender, EventArgs e)
        {
            ClientsReservationsViewer.ReportSource = CR;
        }
    }
}
