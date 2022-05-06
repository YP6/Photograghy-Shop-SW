using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
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
    public partial class ViewAllPhotographersForm : Form
    {
        string ordb = "Data Source=orcl;User id = scott;Password=tiger;";
        OracleConnection conn;
        public ViewAllPhotographersForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void ViewAllPhotographersForm_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "GETPHOTOGRAPHERS";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("Photographer", OracleDbType.RefCursor, ParameterDirection.Output);
            OracleDataReader dr = cmd.ExecuteReader();

            dataGridView1.Columns.Add("User ID", "User ID");
            dataGridView1.Columns.Add("Shift", "Shift");
            dataGridView1.Columns.Add("Salary", "Salary");
            dataGridView1.Columns.Add("Name", "Name");
            dataGridView1.Columns.Add("Gender", "Gender");
            dataGridView1.Columns.Add("Email", "Email");
            dataGridView1.Columns.Add("Phone Number", "Phone Number");



            //dataGridView1.Rows.Add("User Id", "Shift", "Salary", "Name", "Gender", "Email", "Phone Number");

            while (dr.Read())
            {
                dataGridView1.Rows.Add(dr[0], dr[1], dr[2], dr[4], dr[5], dr[6], dr[7]);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
