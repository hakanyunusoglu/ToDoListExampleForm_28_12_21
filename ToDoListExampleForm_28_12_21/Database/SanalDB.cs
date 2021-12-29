using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoListExampleForm_28_12_21.Entities;

namespace ToDoListExampleForm_28_12_21.Database
{
    public static class SanalDB
    {
        public static List<Kullanici> kullaniciTablo;
        public static List<Todo> todoTablo;

        static SanalDB()
        {
            kullaniciTablo = new List<Kullanici>();
            kullaniciTablo.Add(new Kullanici()
            {
                ID = Guid.NewGuid(),
                KullaniciAdi = "hakan",
                Sifre = "123"
            });
            todoTablo = new List<Todo>();
            //todoTablo.Add(new Todo()
            //{

            //});
        }
    }
}
