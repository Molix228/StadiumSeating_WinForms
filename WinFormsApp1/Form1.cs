namespace WinFormsApp1
{
    public partial class StadiumSeating : Form
    {
        public StadiumSeating()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            const decimal priceClassA = 15.00m;
            const decimal priceClassB = 12.00m;
            const decimal priceClassC = 9.00m;

            int ticketsA = int.Parse(textBoxA_tickets.Text);
            int ticketsB = int.Parse(textBoxB_tickets.Text);
            int ticketsC = int.Parse(textBoxC_tickets.Text);

            decimal revenueA = ticketsA * priceClassA;
            decimal revenueB = ticketsB * priceClassB;
            decimal revenueC = ticketsC * priceClassC;
            decimal totalRevenue = revenueA + revenueB + revenueC;

            textBox1.Text = revenueA.ToString();
            textBox2.Text = revenueB.ToString();
            textBox3.Text = revenueC.ToString();
            TotalValue.Text = totalRevenue.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxA_tickets.Clear();
            textBoxB_tickets.Clear();
            textBoxC_tickets.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            TotalValue.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
