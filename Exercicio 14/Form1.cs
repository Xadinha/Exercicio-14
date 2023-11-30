namespace Exercicio_14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        static class class_VG
        {
            public static int resultado;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 F2 = new Form2();
            this.Hide();
            F2.Show();
        }
    }
}