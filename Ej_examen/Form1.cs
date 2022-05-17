namespace Ej_examen
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
            label1.Text = "Hola "+textBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
        }
    }
}