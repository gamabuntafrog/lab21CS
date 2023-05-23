using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            double c = double.Parse(textBox3.Text);

            double[] roots = Discriminant(a, b, c);

            if (roots.Length == 0)
            {
                label4.Text = "Коренів немає";
            }
            else if (roots.Length == 1)
            {
                label4.Text = $"Корінь рівняння: {roots[0]}";
            }
            else
            {
                label4.Text = $"Корені рівняння: {roots[0]}, {roots[1]}";
            }
        }
        private double[] Discriminant(double a, double b, double c)
        {
            double discriminant = b * b - 4 * a * c;

            if (discriminant < 0)
            {

                return new double[0];
            }
            else if (discriminant == 0)
            {

                double root = -b / (2 * a);
                return new double[] { root };
            }
            else
            {

                double sqrtDiscriminant = Math.Sqrt(discriminant);
                double root1 = (-b + sqrtDiscriminant) / (2 * a);
                double root2 = (-b - sqrtDiscriminant) / (2 * a);
                return new double[] { root1, root2 };
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox4.Text);
            double b = double.Parse(textBox5.Text);
            double c = double.Parse(textBox6.Text);

            double[] roots = Discriminant(a, b, c);

            if (roots.Length == 0)
            {
                label9.Text = "Коренів немає";
            }
            else if (roots.Length == 1)
            {
                label9.Text = $"Корінь рівняння: {roots[0]}";
            }
            else
            {
                label9.Text = $"Корені рівняння: {roots[0]}, {roots[1]}";
            }
        }
    }
}
