namespace TempConversion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            float F = float.Parse(textBox1.Text);
            float C = (F - 32) * 5.0f / 9.0f;
            textBox2.Text = C.ToString();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            float C = float.Parse(textBox2.Text);
            float F =( C * 9.0f )/ 5.0f + 32;
            textBox1.Text = F.ToString();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0,0";
            textBox2.Text = "0,0";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            float F = float.Parse(textBox1.Text);
            float K = (F - 32) * 5.0f / 9.0f + 273;
            textBox2.Text = K.ToString();
        }
    }
}