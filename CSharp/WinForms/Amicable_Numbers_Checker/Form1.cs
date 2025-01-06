namespace Amicable_Numbers_Checker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Text = "number comparison app";
        }

        public int Dzielniki(int number)
        {

            int suma = 0;
            for (int i = 1; i < number / 2 + 1; i++)
            {
                if (number % i == 0)
                {
                    suma += i;
                }
            }
            return suma;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number1 = int.Parse(textBox1.Text);
            int number2 = int.Parse(textBox2.Text);
            if (Dzielniki(number1) == number2 && Dzielniki(number2) == number1)
            {
                MessageBox.Show("These numbers are amicable!");
            }
            else
            {
                MessageBox.Show("These numbers are not amicable.");
            }
        }
    }
}

