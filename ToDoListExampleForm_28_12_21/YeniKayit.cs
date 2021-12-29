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
    public partial class YeniKayit : Form
    {
        public YeniKayit()
        {
            InitializeComponent();

            cbbDurum.SelectedIndex = 1;
        }

        private void txtBaslik_Enter(object sender, EventArgs e)
        {
            TextBox T = (TextBox)sender;
            T.BackColor = Color.Yellow;
        }

        private void txtBaslik_Leave(object sender, EventArgs e)
        {
            TextBox T = (TextBox)sender;
            T.BackColor = Color.White;
        }

        private void cbbDurum_Enter(object sender, EventArgs e)
        {
            ComboBox C = (ComboBox)sender;
            C.BackColor = Color.Yellow;
        }

        private void cbbDurum_Leave(object sender, EventArgs e)
        {
            ComboBox C = (ComboBox)sender;
            C.BackColor = Color.White;
        }
        private void btnYeniKayit_KeyUp(object sender, KeyEventArgs e)
        {
            btnYeniKayit.BackColor = Color.AliceBlue;
        }

        private void btnYeniKayit_Click(object sender, EventArgs e)
        {
            TodoServices todoservice = new TodoServices();
            int sonuc = todoservice.KayitYeni(new Todo()
            {
                ID= Guid.NewGuid(),
                Baslik = txtBaslik.Text,
                KisaAciklama = txtKisaAciklama.Text,
                Aciklama = txtAciklama.Text,
                DurumAciklama = cbbDurum.SelectedItem.ToString(),
                OnemDerecesi = int.Parse(txtOnemDerecesi.Text),
                OlusturmaTarihi = DateTime.Now

            });

            if(sonuc > 0)
            {                
                MessageBox.Show("Kayıt ekleme işlemi başarılı!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult result = MessageBox.Show("Kayıt eklemeye devam etmek istiyor musunuz?","Soru",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if(result == DialogResult.Yes)
                {
                    foreach (Control item in this.Controls)
                    {
                        if(item is TextBox)
                        {
                            ((TextBox)item).Clear();
                        }
                        if(item is ComboBox)
                        {
                            ((ComboBox)item).SelectedIndex = 1;
                        }
                        txtBaslik.Focus();

                    }

                }
                else
                {
                    Form kayitListesi = Application.OpenForms["KayitListesi"];
                    if(kayitListesi == null)
                    { 
                    kayitListesi = new KayitListesi();
                    kayitListesi.MdiParent = Application.OpenForms["Anasayfa"];
                    kayitListesi.StartPosition = FormStartPosition.CenterScreen;
                    kayitListesi.Show();
                    this.Close();
                    }
                    else
                    {
                        GroupBox liste = (GroupBox)kayitListesi.Controls["gbListe"];
                        DataGridView dgvList = (DataGridView)liste.Controls["dgv"];
                        List<Todo> guncelListe = todoservice.kayitListele();
                        dgvList.DataSource = null;
                        
                        dgvList.DataSource = guncelListe;
                        dgvList.Columns["ID"].Visible = false;
                        this.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Kayıt ekleme işleminde hata oluştu","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        
    }
}
