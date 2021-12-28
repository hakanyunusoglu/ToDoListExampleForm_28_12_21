using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoListExampleForm_28_12_21.Database;
using ToDoListExampleForm_28_12_21.Entities;

namespace ToDoListExampleForm_28_12_21.BusinessServices
{
    public class KullaniciServices
    {
        public Kullanici kullanicikontrol(string kullaniciadi,string sifre)
        {
            return SanalDB.kullaniciTablo.Where(x=>x.KullaniciAdi == kullaniciadi && x.Sifre == sifre).FirstOrDefault();
        }
    }
}
