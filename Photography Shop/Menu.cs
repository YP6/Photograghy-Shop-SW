using crystalReportPhotography;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Photography_Shop
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void MakeReservation_Click(object sender, EventArgs e)
        {
            MakeReservationForm f2 = new MakeReservationForm();
            Hide();
            f2.ShowDialog();
            Show();
        }

        private void takeReservation_Click(object sender, EventArgs e)
        {
            TakeReservationform form = new TakeReservationform();
            Hide();
            form.ShowDialog();
            Show();
        }

        private void selectClientInfos_Click(object sender, EventArgs e)
        {
            SelectUserFormcs f2 = new SelectUserFormcs();
            Hide();
            f2.ShowDialog();
            Show();
        }

        private void selectPhotoGrapherInfos_Click(object sender, EventArgs e)
        {
            ViewAllPhotographersForm f2 = new ViewAllPhotographersForm();
            Hide();
            f2.ShowDialog();
            Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewReservationsForm f2 = new ViewReservationsForm();
            Hide();
            f2.ShowDialog();
            Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void CrystalReservationReport_Click(object sender, EventArgs e)
        {
            ClientsReservationReportForm f2 = new ClientsReservationReportForm();
            Hide();
            f2.ShowDialog();
            Show();
        }

        private void ShiftsReport_Click(object sender, EventArgs e)
        {
            shiftsReportForm f2 = new shiftsReportForm();
            Hide();
            f2.ShowDialog();
            Show();
        }
    }
}
