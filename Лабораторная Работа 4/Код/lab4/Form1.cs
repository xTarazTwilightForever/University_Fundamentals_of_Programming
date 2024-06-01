namespace lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && !panel1.ClientRectangle.Contains(panel1.PointToClient(Cursor.Position)))
            {
                Button newButton = new Button();
                newButton.Location = new Point(e.X, e.Y);
                newButton.Size = new Size(100, 30);
                newButton.Text = $"X: {e.X}, Y: {e.Y}"; 
                this.Controls.Add(newButton); 
            }
        }
    }
}