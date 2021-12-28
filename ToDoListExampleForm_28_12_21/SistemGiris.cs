using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDoListExampleForm_28_12_21.BusinessServices;
using ToDoListExampleForm_28_12_21.Entities;

namespace ToDoListExampleForm_28_12_21
{
    public partial class SistemGiris : Form
    {
        public SistemGiris()
        {
            InitializeComponent();
        }

        private void tbkullaniciadi_Enter(object sender, EventArgs e)
        {
            TextBox T = (TextBox)sender;
            T.BackColor = Color.Yellow;
        }

        private void tbkullaniciadi_Leave(object sender, EventArgs e)
        {
            TextBox T = (TextBox)sender;
            T.BackColor = Color.White;
        }

        private void btngiris_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(tbkullaniciadi.Text) && !string.IsNullOrEmpty(tbsifre.Text))
            {
                KullaniciServices ks = new KullaniciServices();
                Kullanici kontrolkullanici = ks.kullanicikontrol(tbkullaniciadi.Text,tbsifre.Text);
                if(kontrolkullanici != null)
                {
                    Form anaform = Application.OpenForms["Anasayfa"];
                    Panel solpanel = (Panel)anaform.Controls["panelsol"];
                    GroupBox butongrup = (GroupBox)solpanel.Controls["gbislemlistesi"];
                    foreach(Control item in butongrup.Controls)
                    {
                        if(item is Button)
                        {
                            item.Enabled = true;
                        }
                    }
                }

            }
            else
            {
                //MessageBox.Show("Hatalı Kullanıcı Adı veya Şifre","HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Lütfen Giriş Bilgilerinizi Eksiksiz Giriniz!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            }
        }
    }
}
