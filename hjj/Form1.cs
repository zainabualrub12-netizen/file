namespace hjj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog myf = new OpenFileDialog();
            myf.ShowDialog();
            textBox1.Text = myf.FileName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(textBox1.Text);
            richTextBox1.Text = sr.ReadToEnd();
            sr.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(textBox1.Text, true);
            sw.WriteLine(textBox2.Text);
            sw.Close();
        }
    }
}
