namespace lab3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            dataGridView = new DataGridView();
            x = new DataGridViewTextBoxColumn();
            y = new DataGridViewTextBoxColumn();
            calculateButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold);
            label1.Location = new Point(76, 9);
            label1.Name = "label1";
            label1.Size = new Size(202, 19);
            label1.TabIndex = 0;
            label1.Text = "Табуляция функции y(x)";
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { x, y });
            dataGridView.Location = new Point(12, 40);
            dataGridView.Name = "dataGridView";
            dataGridView.Size = new Size(343, 220);
            dataGridView.TabIndex = 1;
            dataGridView.CellContentClick += dataGridView_CellContentClick;
            // 
            // x
            // 
            x.HeaderText = "x";
            x.Name = "x";
            x.Width = 150;
            // 
            // y
            // 
            y.HeaderText = "y(x)";
            y.Name = "y";
            y.Width = 150;
            // 
            // calculateButton
            // 
            calculateButton.Font = new Font("Arial", 10F);
            calculateButton.Location = new Point(120, 275);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(120, 30);
            calculateButton.TabIndex = 2;
            calculateButton.Text = "Вычислить";
            calculateButton.UseVisualStyleBackColor = true;
            calculateButton.Click += calculateButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(367, 317);
            Controls.Add(calculateButton);
            Controls.Add(dataGridView);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Лабораторная работа 3 - Алимбаев Никита";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn x;
        private DataGridViewTextBoxColumn y;
        private Button calculateButton;
    }
}
