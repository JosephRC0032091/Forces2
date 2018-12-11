using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forces2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double Angle = double.Parse(textBox2.Text);
                double Force = double.Parse(textBox1.Text);
                double ans = Force * Cos(Angle);
                double ans2 = Force * sin(Angle);
                label5.Text = ans2.ToString();
                label4.Text = ans.ToString();
            }

            catch
            {
                MessageBox.Show("Enter an integer please.");
            }
        }


        double sin(double Angle)
        {
            double rad = Angle * Math.PI/ 180.0 ;
            return Math.Sin(rad);
        }


        double Cos(double Angle)
        {
            double rad = Angle * Math.PI / 180.0;
            return Math.Cos(rad);
        }










    }
}
