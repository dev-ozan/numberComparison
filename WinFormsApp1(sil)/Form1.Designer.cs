namespace WinFormsApp1_sil_
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
            firstText = new TextBox();
            label1 = new Label();
            secondText = new Label();
            krsLbl = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // firstText
            // 
            firstText.Location = new Point(60, 100);
            firstText.Margin = new Padding(4, 4, 4, 4);
            firstText.Name = "firstText";
            firstText.Size = new Size(303, 29);
            firstText.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 48);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(113, 21);
            label1.TabIndex = 2;
            label1.Text = "Girilecek Sayi";
            // 
            // secondText
            // 
            secondText.AutoSize = true;
            secondText.Location = new Point(60, 151);
            secondText.Margin = new Padding(4, 0, 4, 0);
            secondText.Name = "secondText";
            secondText.Size = new Size(157, 21);
            secondText.TabIndex = 3;
            secondText.Text = "Karşılaştırılcak Sayı";
            // 
            // krsLbl
            // 
            krsLbl.AutoSize = true;
            krsLbl.Location = new Point(60, 248);
            krsLbl.Margin = new Padding(4, 0, 4, 0);
            krsLbl.Name = "krsLbl";
            krsLbl.Size = new Size(85, 21);
            krsLbl.TabIndex = 4;
            krsLbl.Text = "Karşılaştır";
            krsLbl.Click += krsLbl_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(60, 191);
            textBox1.Margin = new Padding(4, 4, 4, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(303, 29);
            textBox1.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(413, 354);
            Controls.Add(textBox1);
            Controls.Add(krsLbl);
            Controls.Add(secondText);
            Controls.Add(label1);
            Controls.Add(firstText);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Form1";
            Text = "Number Comparison";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox firstText;
        private Label label1;
        private Label secondText;
        private Label krsLbl;
        private TextBox textBox1;
    }
}