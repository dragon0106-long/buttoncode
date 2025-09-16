namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "y";
            pictureBox1.BackColor = Color.Yellow;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "g";
            pictureBox1.BackColor
                = Color.Green;
            pictureBox1.BackgroundImage = Properties.Resources.¦W;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "r";
            pictureBox1.BackColor= Color.Red;
            pictureBox1.BackgroundImage = Properties.Resources.°ê;
        }
    }
}
