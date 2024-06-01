using System;
using System.Windows.Forms;

namespace lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox("Введите строку с нулями и единицами:", "Добавить строку", "");

            if (!string.IsNullOrEmpty(input))
            {
                listBoxInput.Items.Add(input);
            }
        }

        private void buttonCount_Click(object sender, EventArgs e)
        {
            listBoxInput.Items.Clear();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click_1(object sender, EventArgs e)
        {
            string input = textBoxInput.Text.Trim();
            if (!string.IsNullOrEmpty(input))
            {
                listBoxInput.Items.Add(input);
                textBoxInput.Clear();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int zeroCount = 0;
            int oneCount = 0;

            foreach (string item in listBoxInput.Items)
            {
                foreach (char c in item)
                {
                    if (c == '0')
                    {
                        zeroCount++;
                    }
                    else if (c == '1')
                    {
                        oneCount++;
                    }
                }
            }

            labelResult.Text = $"Нулей: {zeroCount}, Единиц: {oneCount}";
        }
    }
}
