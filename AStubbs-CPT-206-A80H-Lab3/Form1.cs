using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AStubbs_CPT_206_A80H_Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aStubbsStateDatabaseDataSet.States' table. You can move, or remove it, as needed.
            this.statesTableAdapter.Fill(this.aStubbsStateDatabaseDataSet.States);

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            DataRowView row = cbStatePicked.SelectedItem as DataRowView;
            if (row != null)
            {
                Report window = new Report();
                window.lblState.Text = row["States"].ToString();
                window.lblCapital.Text = row["Capital"].ToString();
                window.lblThree.Text = row["Largest Three Cities"].ToString();
                window.lblBird.Text = row["Bird"].ToString();
                window.lblFlower.Text = row["Flower"].ToString();
                window.lblPop.Text = row["Population"].ToString();
                window.lblIncome.Text = "$"+row["Median Income"].ToString();
                window.lblDesc.Text = row["Flag Description"].ToString();
                window.lblPercent.Text = row["% of Tech Jobs"].ToString();
                window.Show();
            }
        }
    }
}
