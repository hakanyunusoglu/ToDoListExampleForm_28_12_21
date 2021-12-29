using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListExampleForm_28_12_21.Entities
{
    public class Todo
    {
        [DisplayName("ID")]
        public Guid ID { get; set; }
        [DisplayName("Başlık")]
        public string Baslik { get; set; }
        [DisplayName("Kısa Açıklama")]
        public string KisaAciklama { get; set; }
        [DisplayName("Açıklama")]
        public string Aciklama { get; set; }
        [DisplayName("Önem Derecesi")]
        public int OnemDerecesi { get; set; }
        [DisplayName("Durum")]
        public string DurumAciklama { get; set; }
        [DisplayName("Oluşturma Tarihi")]
        public DateTime OlusturmaTarihi { get; set; }

    }
}
