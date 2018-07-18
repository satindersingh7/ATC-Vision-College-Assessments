using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace btn_calculate
{
    public partial class Form1 : Form
    {
        private Single Grade, Max, Min;
        private int Count = 0;
        float GradeAverage =0, GradeAverageTotal;
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Convert.ToSingle(txtGrade.Text) < 50)
            {
                lblGrade.Text = "Fail";
                lbxGrade.Items.Add(txtGrade.Text + " Fail");
            }
            else
            {
                lblGrade.Text = "Pass";
                lbxGrade.Items.Add(txtGrade.Text + " Pass");
            }
            }

        private void button1_Click_1(object sender, EventArgs e)
        {
            {
                try
                {
                    Grade = Convert.ToSingle(txtGrade.Text);
                    GradeAverage = GradeAverage + Grade; //add grade to the variable and get a running total
                    Count = Count + 1; //count how many times the button is clicked
                    GradeAverageTotal = GradeAverage / Count;
                    lblAverage.Text = Convert.ToString(GradeAverageTotal);
                }
        } }
    }
}

