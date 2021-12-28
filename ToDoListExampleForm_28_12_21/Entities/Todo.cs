using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListExampleForm_28_12_21.Entities
{
    public class Todo
    {
        public Guid ID { get; set; }
        public string Baslik { get; set; }
        public string KisaAciklama { get; set; }
        public string Aciklama { get; set; }
        public int OnemDerecesi { get; set; }
        public string DurumAciklama { get; set; }
        public DateTime OlusturmaTarihi { get; set; }

    }
}
