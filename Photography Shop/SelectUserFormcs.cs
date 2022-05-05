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
            cmd.CommandText = "SelectUserData";
            cmd.Parameters.Add("clientID", Convert.ToInt32(clientID.SelectedItem.ToString()));
            cmd.Parameters.Add("out", OracleDbType.RefCursor,ParameterDirection.Output);
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                name.Text = dr[0].ToString();
                gender.Text = dr[1].ToString();
                Emailtxtbox.Text = dr[2].ToString();
                phoneNumber.Text = dr[3].ToString();
                age.Text = dr[4].ToString();
            }
            dr.Close();
        }

        private void SelectUserFormcs_FormClosed(object sender, FormClosedEventArgs e)
        {
            conn.Dispose();
        }
    }
}
