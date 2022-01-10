namespace lab2_for
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //считывем значения из настроек
            txtStartSum.Text = Properties.Settings.Default.startSum.ToString();
            txtMonthSum.Text = Properties.Settings.Default.monthSum.ToString();
            txtTotalSum.Text = Properties.Settings.Default.totalSum.ToString();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //проверка ввода
            double startSum;
            double monthSum;
            double totalSum;
            try
            {
                startSum = double.Parse(this.txtStartSum.Text);
                monthSum = double.Parse(this.txtMonthSum.Text);
                totalSum = double.Parse(this.txtTotalSum.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите число от 1 до 9999.", "Ошибка ввода!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Properties.Settings.Default.startSum = startSum;
            Properties.Settings.Default.monthSum = monthSum;
            Properties.Settings.Default.totalSum = totalSum;
            Properties.Settings.Default.Save(); // сохраняем переданные значения, чтобы они восстановились пре очередном запуске

            MessageBox.Show(Logic.Compare(startSum, monthSum, totalSum), "Рассчет по вкладу", MessageBoxButtons.OK);

        }
    }
    public class Logic
    {
        public static int exB(double startSum, double monthSum)
        {
            int monthB;
            double monthUp = 0;
            for (monthB = 0; monthUp < monthSum; monthB++)
            {
                monthUp = startSum * 0.02;
                startSum += monthUp;
            }
            return monthB;
        }
        //вычисление конечного вклада
        public static int exC(double startSum, double totalSum)
        {
            int monthC;
            for (monthC = 0; startSum < totalSum; monthC++)
            {
                startSum += startSum * 0.02;
            }
            return monthC;
        }

        public static string Compare(double startSum, double monthSum, double totalSum)
        {
            string outMessage = "";
            if (startSum < 1)
            {
                outMessage = "Введите целое положительное число.";
                return outMessage;
            }
            //ввод ежемесячного вклада
            else if (monthSum < 1)
            {
                outMessage = "Введите целое положительное число.";
                return outMessage;
            }
            //ввод конечного вклада
            else if (totalSum <= startSum)
            {
                outMessage = "Введите целое положительное число, большее начального вклада.";
                return outMessage;
            }
            else
            {
                outMessage = "За " + Logic.exB(startSum, monthSum) + " мес. величина ежемесячного увеличения вклада превысит " + monthSum + " руб.\n"
                           + "Размер вклада превысит " + totalSum + " руб. через " + Logic.exC(startSum, totalSum) + " мес.";
                return outMessage;
            }
        }
    }
}