namespace lab7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        int[,] matrix = {
        { 5, 8, 3, 2 },
        { 9, 4, 7, 1 },
        { 6, 0, 2, 11 }
    };

            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                dataGridView1.Columns.Add($"Column{i}", $"Column {i + 1}");
            }

            string[] rows = new string[matrix.GetLength(0)];

            int[] minElements = new int[matrix.GetLength(0)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int min = matrix[i, 0];
                for (int j = 1; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] < min)
                    {
                        min = matrix[i, j];
                    }
                }
                minElements[i] = min;
                rows[i] = string.Join(" ", matrix.Cast<int>().Skip(i * matrix.GetLength(1)).Take(matrix.GetLength(1)));
            }

            dataGridView1.Rows.Clear();
            foreach (string row in rows)
            {
                dataGridView1.Rows.Add(row.Split(' '));
            }

            labelResults.Text = "Наименьшие элементы в каждой строке матрицы:\n";
            for (int i = 0; i < minElements.Length; i++)
            {
                labelResults.Text += $"Строка {i + 1}: {minElements[i]}\n";
            }
        }
    }
}
