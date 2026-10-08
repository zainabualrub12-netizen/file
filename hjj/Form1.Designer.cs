namespace hjj
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
            button1 = new Button();
            label2 = new Label();
            textBox1 = new TextBox();
            richTextBox1 = new RichTextBox();
            textBox2 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            openFileDialog1 = new OpenFileDialog();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 44);
            label1.Name = "label1";
            label1.Size = new Size(92, 28);
            label1.TabIndex = 0;
            label1.Text = "file path";
            // 
            // button1
            // 
            button1.Location = new Point(468, 33);
            button1.Name = "button1";
            button1.Size = new Size(94, 36);
            button1.TabIndex = 1;
            button1.Text = ".....";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 328);
            label2.Name = "label2";
            label2.Size = new Size(67, 28);
            label2.TabIndex = 2;
            label2.Text = "write ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(131, 41);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(283, 34);
            textBox1.TabIndex = 3;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(57, 123);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(445, 189);
            richTextBox1.TabIndex = 4;
            richTextBox1.Text = "";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(131, 325);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(322, 34);
            textBox2.TabIndex = 5;
            // 
            // button2
            // 
            button2.Location = new Point(157, 81);
            button2.Name = "button2";
            button2.Size = new Size(257, 36);
            button2.TabIndex = 6;
            button2.Text = "reading data";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(483, 325);
            button3.Name = "button3";
            button3.Size = new Size(137, 36);
            button3.TabIndex = 7;
            button3.Text = "add to file";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(632, 378);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(richTextBox1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Label label2;
        private TextBox textBox1;
        private RichTextBox richTextBox1;
        private TextBox textBox2;
        private Button button2;
        private Button button3;
        private OpenFileDialog openFileDialog1;
    }
}
