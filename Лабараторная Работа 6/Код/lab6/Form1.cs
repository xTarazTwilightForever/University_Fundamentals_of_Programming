using System;
using System.Windows.Forms;

namespace lab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] strNumbers = textBox1.Text.Split(',');
            int[] numbers = new int[strNumbers.Length];
            for (int i = 0; i < strNumbers.Length; i++)
            {
                if (!int.TryParse(strNumbers[i], out numbers[i]))
                {
                    MessageBox.Show("Ошибка ввода. Проверьте, что введены целые числа, разделенные запятой.");
                    return;
                }
            }

            int maxIndex = 0;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > numbers[maxIndex])
                {
                    maxIndex = i;
                }
            }

            int temp = numbers[0];
            numbers[0] = numbers[maxIndex];
            numbers[maxIndex] = temp;

            MessageBox.Show($"Наибольший элемент: {numbers[0]}\nИзмененный массив: {string.Join(", ", numbers)}");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
