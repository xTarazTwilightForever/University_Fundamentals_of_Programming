namespace lab5
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
            listBoxInput = new ListBox();
            buttonClear = new Button();
            labelResult = new Label();
            textBoxInput = new TextBox();
            buttonAdd = new Button();
            button1 = new Button();
            SuspendLayout();



            listBoxInput.FormattingEnabled = true;
            listBoxInput.ItemHeight = 15;
            listBoxInput.Location = new Point(29, 78);
            listBoxInput.Name = "listBoxInput";
            listBoxInput.Size = new Size(120, 94);
            listBoxInput.TabIndex = 0;



            buttonClear.Location = new Point(154, 137);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(75, 23);
            buttonClear.TabIndex = 1;
            buttonClear.Text = "Очистить";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonCount_Click;
 


            labelResult.AutoSize = true;
            labelResult.Location = new Point(50, 242);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(60, 15);
            labelResult.TabIndex = 2;
            labelResult.Text = "Результат";



            textBoxInput.Location = new Point(29, 24);
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(120, 23);
            textBoxInput.TabIndex = 3;



            buttonAdd.Location = new Point(155, 24);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(75, 23);
            buttonAdd.TabIndex = 4;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click_1;
 


            button1.Location = new Point(154, 96);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "Посчитать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;



            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(241, 280);
            Controls.Add(button1);
            Controls.Add(buttonAdd);
            Controls.Add(textBoxInput);
            Controls.Add(labelResult);
            Controls.Add(buttonClear);
            Controls.Add(listBoxInput);
            Name = "Form1";
            Text = "Никита Алимбаев";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxInput;
        private Button buttonClear;
        private Label labelResult;
        private TextBox textBoxInput;
        private Button buttonAdd;
        private Button button1;
    }
}
