namespace Programmeringprojektspel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Random rand = new Random();
        
        public int tal;
        public int i = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            tal = rand.Next(int.Parse(textBox3.Text)); //Det h�r g�r s� att i textbox tre s� skriver vi st�rsta talet som random kan vara
            textBox2.Clear(); //den h�r clearar datorns tal och ditt tal n�r man klickar p� starta spelet
            textBox1.Clear(); //den h�r clearar datorns tal och ditt tal n�r man klickar p� starta spelet
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tal == int.Parse(textBox1.Text))  // Den h�r if satsen g�r s� att jag har en po�ng lista d� jag har i som plusar 1 om mitt tal �r lika med textbox2.Text
            {
                i++;
                listBox1.Items.Add(i);

            }
            textBox2.Text = tal.ToString();
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}