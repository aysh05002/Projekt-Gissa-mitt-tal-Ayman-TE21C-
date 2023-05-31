namespace Projekt_Gissa_mitt_tal__Ayman_TE21C_
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

        private void button1_Click(object sender, EventArgs e)
        {
            Random slump = new Random();
            int stöstatal = Convert.ToInt32 (textBox1.Text);
            int slumptal = slump.Next(1,stöstatal + 1);
            int gissatal = Convert.ToInt32(textBox2.Text);
            string dator = slumptal.ToString();
            textBox3.Text = dator;
            if (slumptal == gissatal)
            {
                label4.Text = "Du har gissat rätt!!!!";
            }
            else
            {
                label4.Text = "Du har gissat fel! \nProva igen";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            label4.Text = "";
        }
    }
}