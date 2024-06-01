using System;
using System.Windows.Forms;

namespace lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView.ColumnCount = 2;
            dataGridView.Columns[0].Name = "x";
            dataGridView.Columns[0].HeaderText = "x";
            dataGridView.Columns[1].Name = "y(x)";
            dataGridView.Columns[1].HeaderText = "y(x)";
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double x0 = -1.5;
            double xk = 3.5;
            double dx = 0.5;
            double a = -1.25;
            double b = -1.5;
            double c = 0.75;

            dataGridView.Rows.Clear();

            for (double x = x0; x <= xk; x += dx)
            {
                double yValue = Math.Pow(10, -2) * b * c / x + Math.Cos(Math.Sqrt(a * x));
                dataGridView.Rows.Add(x.ToString(), yValue.ToString("F4")); 
            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
