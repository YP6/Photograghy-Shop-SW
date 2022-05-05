using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Types;
using Oracle.DataAccess.Client;

namespace Photography_Shop
{
    public partial class TakeReservationform : Form
    {
        string ordb = "Data Source=orcl;User id = scott;Password=tiger;";
        OracleConnection conn;
        public TakeReservationform()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ClientIDs ComboBox
             OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = @"select name
                                from users
                                join clients
                                on users.id = clients.userid
                                and clientid = :id";
            cmd.Parameters.Add("id", clientsIDs.SelectedItem.ToString());
            OracleDataReader dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                clientName.Text = dr[0].ToString();
            }
            dr.Close();
            cmd.CommandText = @"select datetime
                                from newreservation
                                where clientid = :id";
            dr = cmd.ExecuteReader();
            DateComboBox.Items.Clear();
            while(dr.Read())
            {
                DateComboBox.Items.Add(dr[0].ToString());
            }

        }

        private void TakeReservationform_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = @"select userid
                               from photographers";
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                photoGrapherIDs.Items.Add(dr[0].ToString());
            }
            dr.Close();

            cmd.CommandText = @"select clientid
                                from newreservation";
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
               if (!clientsIDs.Items.Contains(dr[0].ToString()))
                {
                    clientsIDs.Items.Add(dr[0].ToString());
                }
              

            }
            dr.Close();

        }

        private void TakeReservationform_FormClosed(object sender, FormClosedEventArgs e)
        {
            conn.Dispose();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void photoGrapherIDs_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = @"select name
                                from users
                                where id = :id";
            cmd.Parameters.Add("id", photoGrapherIDs.SelectedItem.ToString());
            OracleDataReader dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                photoGrapherName.Text = dr[0].ToString();
            }
            dr.Close();
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TakeReservationbtn_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(photoGrapherIDs.SelectedItem.ToString())|| string.IsNullOrEmpty(clientsIDs.SelectedItem.ToString())||
                string.IsNullOrEmpty(DateComboBox.SelectedItem.ToString())|| string.IsNullOrEmpty(cost.Text))
            {
                MessageBox.Show("Please Enter All data");
                return;
            }
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = @"select max(id)
                                from reservation";
            OracleDataReader dr = cmd.ExecuteReader();
            int id = 1;
            if (dr.Read())
            {
                int maxID = Convert.ToInt32(dr[0].ToString());
                id = ++maxID;
            }
            dr.Close();

            cmd.CommandText = @"insert into reservation
                                values(:MaxID , :DateTime , :cost , 'PAID' , :photographerid , :clientid)";
            cmd.Parameters.Add("MaxID", id);
            cmd.Parameters.Add("DateTime", Convert.ToDateTime(DateComboBox.SelectedItem.ToString()));
            cmd.Parameters.Add("cost", Convert.ToInt32(cost.Text));
            cmd.Parameters.Add("photographerid", photoGrapherIDs.SelectedItem.ToString());
            cmd.Parameters.Add("clientid", clientsIDs.SelectedItem.ToString());

            int done = cmd.ExecuteNonQuery();
            if (done == -1)
            {
                MessageBox.Show("Reservation take failed");
                return;
            }
            cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = @"delete 
                                from newreservation
                                where clientid = :clientid
                                and
                                DateTime = :DateTime";
            cmd.Parameters.Add("clientid", clientsIDs.SelectedItem.ToString());
            cmd.Parameters.Add("DateTime", Convert.ToDateTime(DateComboBox.SelectedItem.ToString()));

            done = cmd.ExecuteNonQuery();
            if (done != -1)
            {
                MessageBox.Show("Reservation took succssfully");
            }
            if (DateComboBox.Items.Count == 1)
            {
                clientsIDs.Items.Remove(clientsIDs.SelectedItem);
                DateComboBox.Items.Remove(DateComboBox.SelectedItem);
            }
            clientsIDs.ResetText();
        
            DateComboBox.ResetText();
      
            cost.Text = "";
            clientName.Text = "";


        }
    }
}
