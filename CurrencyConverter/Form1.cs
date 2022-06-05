namespace CurrencyConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int Dollar = 65;
        int Euro = 68;
        int Frank = 66;
        int x;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked) convert(Dollar);
            else if (radioButton2.Checked) convert(Euro);
            else if (radioButton3.Checked) convert(Frank);
            else MessageBox.Show("Вы не выбрали валюту для перевода");
        }
        private void convert(int Kurs)
        {
            if (int.TryParse(textBox1.Text, out x))
                textBox2.Text = (Kurs * x).ToString();
            else
                MessageBox.Show("Вы не указали сумму в рублях");
        }
    }
}