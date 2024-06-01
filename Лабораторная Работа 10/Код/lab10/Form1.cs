namespace lab10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBoxA.Text);
            int b = int.Parse(textBoxB.Text);
            int c = int.Parse(textBoxC.Text);
            int d = int.Parse(textBoxD.Text);

            int result = findMin(a, b, c, d);

            labelResult.Text = "Минимальное значение: " + result.ToString();
        }
        private int min(int x, int y)
        {
            return x < y ? x : y;
        }

        private int findMin(int a, int b, int c, int d)
        {
            int minAB = min(a, b);
            int minCD = min(c, d);
            return min(minAB, minCD);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
