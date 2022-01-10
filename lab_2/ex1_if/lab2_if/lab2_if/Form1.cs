namespace lab2_if
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // считывем значения из настроек
            txtStartSum.Text = Properties.Settings.Default.startSum.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //проверка ввода
            int startSum;
            try
            {
                startSum = int.Parse(this.txtStartSum.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите число от 1 до 9999.", "Ошибка ввода!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show(Logic.Compare(startSum));

            // сохраняем переданные значения, чтобы они восстановились пре очередном запуске
            Properties.Settings.Default.startSum = startSum;
            Properties.Settings.Default.Save();
        }
    }

    public class Logic
    {
        public static string Compare(int startSum)
        {
            string outMessage = "";
            if (startSum > 0 && startSum < 10000)
            {
                int rub = startSum / 100;
                int kop = startSum % 100;
                string textrub = "";
                if (rub == 1)
                    textrub = "рубль";
                else if (rub >= 2 && rub <= 4)
                    textrub = "рубля";
                else if (rub >= 5 && rub <= 20)
                    textrub = "рублей";
                else if (rub % 10 == 1)
                    textrub = "рубль";
                else if (rub % 10 >= 2 && rub % 10 <= 4)
                    textrub = "рубля";
                else textrub = "рублей";
                string textkop = "";
                if (kop == 1)
                    textkop = "копейка";
                else if (kop == 0)
                    textkop = "ровно";
                else if (kop > 9 && kop < 21 || kop % 10 > 4 && kop % 10 < 10 || kop % 10 == 0)
                    textkop = "копеек";
                else if (kop >= 2 & kop <= 4)
                    textkop = "копейки";
                else if (kop % 10 == 1)
                    textkop = "копейка";
                else if (kop % 10 >= 2 & kop % 10 <= 4)
                    textkop = "копейки";
                if (kop == 0)
                    outMessage = "Стоимость: " + rub + " " + textrub + " " + textkop;
                else
                    outMessage = "Стоимость: " + rub + " " + textrub + " " + kop + " " + textkop;
                return outMessage;
            }
            else
            {
                outMessage = "Введите число от 1 до 9999.";
                return outMessage;
            }
        }
    }
}