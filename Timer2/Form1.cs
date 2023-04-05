namespace Timer2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Bt_stop.Enabled = false;

        }
        int i;
        private void timer1_Tick(object sender, EventArgs e)
        {

            label1.Text = i.ToString();
            if (i == 0)
            {
                timer1.Stop();
                Bt_stop.Enabled = false;
                MessageBox.Show("Время вышло", "Таймер");
            }
            i--;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            i = (int)numericUp.Value;
            if (i < 0) { MessageBox.Show("Заданное время недопустимо", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            timer1.Enabled = true;
            Bt_stop.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            Bt_stop.Enabled = false;
            MessageBox.Show($"Таймер остановлен, осталось {i} секунд");
        }
    }
}