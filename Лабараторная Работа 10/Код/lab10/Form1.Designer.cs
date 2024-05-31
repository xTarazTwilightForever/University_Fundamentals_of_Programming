namespace lab10
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
            textBoxA = new TextBox();
            textBoxB = new TextBox();
            textBoxC = new TextBox();
            textBoxD = new TextBox();
            buttonCalculate = new Button();
            labelResult = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // textBoxA
            // 
            textBoxA.Location = new Point(96, 22);
            textBoxA.Name = "textBoxA";
            textBoxA.Size = new Size(100, 23);
            textBoxA.TabIndex = 0;
            // 
            // textBoxB
            // 
            textBoxB.Location = new Point(96, 68);
            textBoxB.Name = "textBoxB";
            textBoxB.Size = new Size(100, 23);
            textBoxB.TabIndex = 1;
            // 
            // textBoxC
            // 
            textBoxC.Location = new Point(96, 110);
            textBoxC.Name = "textBoxC";
            textBoxC.Size = new Size(100, 23);
            textBoxC.TabIndex = 2;
            // 
            // textBoxD
            // 
            textBoxD.Location = new Point(96, 154);
            textBoxD.Name = "textBoxD";
            textBoxD.Size = new Size(100, 23);
            textBoxD.TabIndex = 3;
            // 
            // buttonCalculate
            // 
            buttonCalculate.Location = new Point(36, 194);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(160, 23);
            buttonCalculate.TabIndex = 4;
            buttonCalculate.Text = "Вычислить";
            buttonCalculate.UseVisualStyleBackColor = true;
            buttonCalculate.Click += buttonCalculate_Click;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(3, 246);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(60, 15);
            labelResult.TabIndex = 5;
            labelResult.Text = "Результат";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 22);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 6;
            label1.Text = "Введите a:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 71);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 7;
            label2.Text = "Введите b:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 113);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 8;
            label3.Text = "Введите c:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 157);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 9;
            label4.Text = "Введите d:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(224, 280);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelResult);
            Controls.Add(buttonCalculate);
            Controls.Add(textBoxD);
            Controls.Add(textBoxC);
            Controls.Add(textBoxB);
            Controls.Add(textBoxA);
            Name = "Form1";
            Text = "Алимбаев Никита";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxA;
        private TextBox textBoxB;
        private TextBox textBoxC;
        private TextBox textBoxD;
        private Button buttonCalculate;
        private Label labelResult;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
