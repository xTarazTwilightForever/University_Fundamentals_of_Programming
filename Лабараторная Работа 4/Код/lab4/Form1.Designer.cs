namespace lab4
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panel1 = new Panel();
            SuspendLayout();



            panel1.BackColor = System.Drawing.Color.LightBlue;
            panel1.Location = new Point((ClientSize.Width - 200) / 2, (ClientSize.Height - 100) / 2); 
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 100);
            panel1.TabIndex = 0;
            panel1.Anchor = AnchorStyles.None; 



            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Никита Алимбаев"; 
            MouseClick += new MouseEventHandler(this.Form1_MouseClick); 
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
    }
}
