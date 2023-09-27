using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hometask2
{
    public partial class Form1 : Form
    {
        public int priceA = 15;
        public int priceB = 12;
        public int priceC = 9;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string classAstr = textBox1.Text;
            string classBstr = textBox2.Text;
            string classCstr = textBox3.Text;


            try
            {
                int classA = int.Parse(classAstr);
                int classB = int.Parse(classBstr);
                int classC = int.Parse(classCstr);

                if(classA >= 0 && classB >= 0 && classC >= 0)
                {
                    int resultA = classA * priceA;
                    int resultB = classB * priceB;
                    int resultC = classC * priceC;

                    int total = resultA + resultB + resultC;

                    textBox4.Text = resultA.ToString();
                    textBox5.Text = resultB.ToString();
                    textBox6.Text = resultC.ToString();
                    textBox7.Text = total.ToString();
                }

            }
            catch (FormatException)
            {
               
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
