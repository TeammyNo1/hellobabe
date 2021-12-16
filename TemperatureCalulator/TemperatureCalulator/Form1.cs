namespace TemperatureCalulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // get input form textbox
            string input = textBoxC.Text;
            // convert to f
            // f = c x 9/5 + 32
            double c = Convert.ToDouble(input);
            double f = c * 9 / 5 + 32;

            // show input to textbox
            textBoxF.Text = f.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
      
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1Convert_Click(object sender, EventArgs e)
        {
            // get input form textbox
            string input = textBoxF.Text;

            // convert to c
            // f = c - 32 * 5/9
            double f = Convert.ToDouble(input);
            double c = (f - 32) * 5 / 9;

            // show input to textbox
            textBoxC.Text = c.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBoxC.Text = "";
            textBoxF.Text = "";
        }
    }
}