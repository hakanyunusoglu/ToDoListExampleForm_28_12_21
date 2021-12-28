namespace ToDoListExampleForm_28_12_21
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {
            lblsaat.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            timer1.Interval = 7000;
            timer1.Tick += tm_zamanla_tick;
            timer1.Start();

            ButonAcKapat(false);

            SistemGiris kullanicikontrol = new SistemGiris();
            kullanicikontrol.MdiParent = this;
            kullanicikontrol.StartPosition = FormStartPosition.CenterScreen;
            kullanicikontrol.Show();
        }

        private void ButonAcKapat(bool kontrol)
        {
           foreach(Control item in gbislemlistesi.Controls)
            {
                if(item is Button)
                {
                  ((Button)item).Enabled = kontrol;
                }
            }
        }

        private void tm_zamanla_tick(object? sender, EventArgs e)
        {
            lblsaat.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}