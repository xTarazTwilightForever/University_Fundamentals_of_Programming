using System;
using System.Drawing;
using System.Windows.Forms;

namespace lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetupFormAppearance();
        }

        private void SetupFormAppearance()
        {
            this.Text = "Никита Алимбаев";
            this.BackColor = Color.LightGray;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            label1.Text = "Введите x:";
            label1.Font = new Font(label1.Font, FontStyle.Bold);
            label1.ForeColor = Color.Blue;

            label2.Text = "Введите y:";
            label2.Font = new Font(label2.Font, FontStyle.Bold);
            label2.ForeColor = Color.Green;

            label3.Text = "Введите z:";
            label3.Font = new Font(label3.Font, FontStyle.Bold);
            label3.ForeColor = Color.Red;

            textBoxX.BorderStyle = BorderStyle.FixedSingle;
            textBoxY.BorderStyle = BorderStyle.FixedSingle;
            textBoxZ.BorderStyle = BorderStyle.FixedSingle;

            button1.FlatStyle = FlatStyle.Flat;
            button1.BackColor = Color.DarkOrange;
            button1.ForeColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double x = double.Parse(textBoxX.Text);
                double y = double.Parse(textBoxY.Text);
                double z = double.Parse(textBoxZ.Text);

                double t = CalculateT(x, y, z);

                MessageBox.Show($"При x = {x}, y = {y}, z = {z} получается t = {t}");
            }
            catch (FormatException)
            {
                MessageBox.Show("Пожалуйста, введите корректные числовые значения.");
            }
        }

        private double CalculateT(double x, double y, double z)
        {
            double intermediate1 = 2 * Math.Cos(Math.PI * x / 6);
            double intermediate2 = 0.5 + Math.Pow(Math.Sin(y), 2);
            double intermediate3 = z * z;
            double intermediate4 = 3 - z * z / 5;

            return intermediate1 / intermediate2 * (1 + intermediate3 / intermediate4);
        }
    }
}
