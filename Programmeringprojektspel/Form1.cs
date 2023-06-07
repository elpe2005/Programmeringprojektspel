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
            tal = rand.Next(int.Parse(textBox3.Text)); //Det här gör så att i textbox tre så skriver vi största talet som random kan vara
            textBox2.Clear(); //den här clearar datorns tal och ditt tal när man klickar på starta spelet
            textBox1.Clear(); //den här clearar datorns tal och ditt tal när man klickar på starta spelet
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tal == int.Parse(textBox1.Text))  // Den här if satsen gör så att jag har en poäng lista då jag har i som plusar 1 om mitt tal är lika med textbox2.Text
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