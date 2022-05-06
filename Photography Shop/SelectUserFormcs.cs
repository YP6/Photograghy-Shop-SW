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
    public partial class SelectUserFormcs : Form
    {
        string ordb = "Data Source=orcl;User id = scott;Password=tiger;";
        OracleConnection conn;
        public SelectUserFormcs()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void SelectUserFormcs_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = @"select clientid
                                from clients";
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                clientID.Items.Add(dr[0]);
            }
            dr.Close();

        }

        private void clientID_SelectedIndexChanged(object sender, EventArgs e)
        {
           OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "selectUserData";

            cmd.Parameters.Add("c_id", Convert.ToInt32(clientID.SelectedItem.ToString()));

            cmd.Parameters.Add("c_name", OracleDbType.Varchar2, 32767).Direction = ParameterDirection.Output;
            cmd.Parameters.Add("c_gender", OracleDbType.Varchar2 , 32767).Direction = ParameterDirection.Output;
            cmd.Parameters.Add("c_email", OracleDbType.Varchar2, 32767).Direction = ParameterDirection.Output;
            cmd.Parameters.Add("c_phone", OracleDbType.Varchar2, 32767).Direction = ParameterDirection.Output;
            cmd.Parameters.Add("c_age", OracleDbType.Int32, ParameterDirection.Output);

            int done = cmd.ExecuteNonQuery();
          
            if (done == -1)
            {
                name.Text = cmd.Parameters["c_name"].Value.ToString();
                gender.Text = cmd.Parameters["c_gender"].Value.ToString();
                Emailtxtbox.Text = cmd.Parameters["c_email"].Value.ToString();
                phoneNumber.Text = cmd.Parameters["c_phone"].Value.ToString();
                age.Text = cmd.Parameters["c_age"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Something Went wrong please don't cry");
            }
        }

        private void SelectUserFormcs_FormClosed(object sender, FormClosedEventArgs e)
        {
            conn.Dispose();
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
