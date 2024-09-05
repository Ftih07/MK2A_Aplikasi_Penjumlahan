namespace penjumlahan
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
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 29);
            label1.Name = "label1";
            label1.Size = new Size(123, 20);
            label1.TabIndex = 0;
            label1.Text = "Masukkan Nilai A";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 73);
            label2.Name = "label2";
            label2.Size = new Size(122, 20);
            label2.TabIndex = 1;
            label2.Text = "Masukkan Nilai B";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 118);
            label3.Name = "label3";
            label3.Size = new Size(132, 20);
            label3.TabIndex = 2;
            label3.Text = "Hasil A + B adalah";
            label3.Click += label3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(190, 26);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(220, 27);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(190, 73);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(220, 27);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.White;
            textBox3.Location = new Point(190, 118);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(220, 27);
            textBox3.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(458, 26);
            button1.Name = "button1";
            button1.Size = new Size(100, 96);
            button1.TabIndex = 6;
            button1.Text = "Jumlahkan";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(65, 28);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(613, 164);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private GroupBox groupBox1;
    }
}
