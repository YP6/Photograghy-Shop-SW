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
    public partial class ViewReservationsForm : Form
    {
        string ordb = "Data Source=orcl;User id = scott;Password=tiger;";
        OracleDataAdapter adapter;
        OracleCommandBuilder builder;
        DataSet ds;
        public ViewReservationsForm()
        {
            InitializeComponent();
        }

        private void ViewReservationsForm_Load(object sender, EventArgs e)
        {
           
            string cmdstr = "SELECT unique(datetime) FROM reservation";
            adapter = new OracleDataAdapter(cmdstr, ordb);
            DataSet ds1 = new DataSet();
            adapter.Fill(ds1);
            int i = -1;
            try
            {
                while (ds1.Tables[0].Rows[++i] != null)
                {
                    comboBox1.Items.Add(ds1.Tables[0].Rows[i][0]);
                }
            }catch(Exception ex)
            {
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            builder = new OracleCommandBuilder(adapter);
            adapter.Update(ds.Tables[0]);
        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex < 0)
            {
                MessageBox.Show("Please Select A Date", "Error 400 Bad Request", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string cmdstr = @"SELECT * FROM reservation WHERE datetime = :d";

            adapter = new OracleDataAdapter(cmdstr, ordb);
            DateTime date = DateTime.Parse(comboBox1.SelectedItem.ToString());
            adapter.SelectCommand.Parameters.Add("d", date);
            Console.WriteLine(DateTime.Parse(comboBox1.SelectedItem.ToString()));
            ds = new DataSet();
            adapter.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
