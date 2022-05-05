using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace Photography_Shop
{
    public partial class MakeReservationForm : Form
    {
        string ordb = "Data Source=orcl;User id = scott;Password=tiger;";
        OracleConnection conn;
        public MakeReservationForm()
        {
            InitializeComponent();
        }

        private void MakeReservationForm_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = @"select clientid
                                from clients";
            OracleDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                ClientIDsComboBox.Items.Add(dr[0]);
            }
            dr.Close();

            
        }

        private void MakeReservationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            conn.Dispose();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = @"insert into newreservation
                                values(:id, :dateTime)";
            cmd.Parameters.Add("id", Convert.ToInt32(ClientIDsComboBox.SelectedItem.ToString()));
            cmd.Parameters.Add("dateTime", Convert.ToDateTime(dateTimePicker.Value));
            int r = cmd.ExecuteNonQuery();
            if (r!= -1)
            {
                MessageBox.Show("Reservation is done sussccuffuly");
            }
            else
            {
                MessageBox.Show("Reservation is not done");
            }

        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
