using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9_statistic
{
    public partial class Form1 : Form
    {
        private int overall_coef;
        private int count_iter;
        private int[] elements = new int[5];
        private int[] elements_counter = new int[5];
        private int total_counter = 0;
        private Random random = new Random();

        private int ArrayNumber(int k)
        {
            int counter = 0;
            while (true)
            {
                k -= elements[counter];
                if (k < 0)
                    break;
                counter++;
            }
            return counter;
        }
        private void LabelStart()
        {
            label7.Text = $"Общий коэффицент:";
            overall_coef = 0;
            elements = new int[5];
            elements_counter = new int[5];
            total_counter = 0;

            count_iter = (int)numericUpDown6.Value;
            overall_coef += (int)numericUpDown1.Value;
            elements[0] = (int)numericUpDown1.Value;
            overall_coef += (int)numericUpDown2.Value;
            elements[1] = (int)numericUpDown2.Value;
            overall_coef += (int)numericUpDown3.Value;
            elements[2] = (int)numericUpDown3.Value;
            overall_coef += (int)numericUpDown4.Value;
            elements[3] = (int)numericUpDown4.Value;
            overall_coef += (int)numericUpDown5.Value;
            elements[4] = (int)numericUpDown5.Value;

            label7.Text = $"{label7.Text} {overall_coef}";
        }

        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LabelStart();
            for (int i = 0; i < count_iter; i++)
            {
                elements_counter[ArrayNumber(random.Next(0, overall_coef))]++;
                total_counter++;
                label8.Text = $"{(double)elements_counter[0] / total_counter}";
                label9.Text = $"{(double)elements_counter[1] / total_counter}";
                label10.Text = $"{(double)elements_counter[2] / total_counter}";
                label11.Text = $"{(double)elements_counter[3] / total_counter}";
                label12.Text = $"{(double)elements_counter[4] / total_counter}";
            }
        }
    }
}

