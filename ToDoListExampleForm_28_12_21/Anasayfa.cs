using ToDoListExampleForm_28_12_21.BusinessServices;

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
            timer1.Interval = 15000;
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

        Form T;
        private void btnyenikayit_Click(object sender, EventArgs e)
        {
            if(Application.OpenForms["YeniKayit"] != null)
            {
                T = Application.OpenForms["YeniKayit"];
                T.Focus();
            }
            else { 
            T = new YeniKayit();
            T.MdiParent = this;
            T.Show();
            }
        }

        private void btnkayitlist_Click(object sender, EventArgs e)
        {
            TodoServices todoservice = new TodoServices();
            KayitListesi kayitList = new KayitListesi();

            if (todoservice.KayitKontrol() > 0)
            {
                if (Application.OpenForms["KayitListesi"] != null)
                {
                    T = Application.OpenForms["KayitListesi"];
                    T.Focus();
                }
                else
                {
                    kayitList.MdiParent = this;
                    kayitList.Show();
                }
            }
            else
            {
                MessageBox.Show("Herhangi bir kayıt bulunamadı!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}