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
    public partial class KayitListesi : Form
    {
        TodoServices todoservice;
        public KayitListesi()
        {
            InitializeComponent();
            todoservice = new TodoServices();
        }
        private List<Todo> TumListe()
        {
            return todoservice.kayitListele();
        }
        private void KayitListesi_Load(object sender, EventArgs e)
        {
            dgv.DataSource = TumListe();
            dgv.Columns["ID"].Visible = false;
        }
        private void btntumListe_Click(object sender, EventArgs e)
        {
            dgv.DataSource = TumListe();
            dgv.Columns["ID"].Visible = false;
        }

        private void btntamamlandi_Click(object sender, EventArgs e)
        {
            dgv.DataSource = TumListe().Where(x => x.DurumAciklama == "Tamamlandı").ToList();
            dgv.Columns["ID"].Visible = false;
        }

        private void btntamamlanamadi_Click(object sender, EventArgs e)
        {
            dgv.DataSource = TumListe().Where(x => x.DurumAciklama == "Tamamlanmadı").ToList();
            dgv.Columns["ID"].Visible = false;
        }

        private void btniptaledildi_Click(object sender, EventArgs e)
        {
            dgv.DataSource = TumListe().Where(x => x.DurumAciklama == "İptal Edildi").ToList();
            dgv.Columns["ID"].Visible = false;
        }

        private void btnertelendi_Click(object sender, EventArgs e)
        {
            dgv.DataSource = TumListe().Where(x => x.DurumAciklama == "Ertelendi").ToList();
            dgv.Columns["ID"].Visible = false;
        }

        private void btnbeklemede_Click(object sender, EventArgs e)
        {
            dgv.DataSource = TumListe().Where(x => x.DurumAciklama == "Beklemede").ToList();
            dgv.Columns["ID"].Visible = false;
        }
    }
}
