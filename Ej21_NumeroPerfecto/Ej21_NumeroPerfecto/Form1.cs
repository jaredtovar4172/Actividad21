using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej21_NumeroPerfecto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number, sum = 0;
            string divisors = "";
            number = int.Parse(textBox1.Text);

            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum += i;
                    divisors += i.ToString() + "+";
                }
            }
            divisors = divisors.Remove(divisors.Length - 1, 1);
            MessageBox.Show(divisors + " = " + sum);
            if (sum == number)
            {
                MessageBox.Show("Por lo tanto ," + number + " Es un numero perfecto");
            }
            else
                MessageBox.Show("Por lo tanto ," + number + " No es un numero perfecto");
        }
    }
}
