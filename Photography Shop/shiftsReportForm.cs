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
using CrystalDecisions.Shared;

namespace crystalReportPhotography
{
    public partial class shiftsReportForm : System.Windows.Forms.Form
    {
        shiftsReport CR;
        public shiftsReportForm()
        {
            InitializeComponent();
        }

        private void shiftsReportForm_Load(object sender, EventArgs e)
        {
            CR = new shiftsReport();
            foreach (ParameterDiscreteValue v in CR.ParameterFields[0].DefaultValues)
            {
                comboBox1.Items.Add(v.Value);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CR.SetParameterValue(0, comboBox1.Text);
            CR.SetParameterValue(1, "");

            crystalReportViewer1.ReportSource = CR;
        }



        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           /* textBox1.Text = "";
            textBox1.Enabled = false;
            comboBox1.Enabled = true;*/
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

            /*comboBox1.Text = "";
            comboBox1.Enabled = false;
            textBox1.Enabled = true;*/
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
