using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoListExampleForm_28_12_21.Database;
using ToDoListExampleForm_28_12_21.Entities;

namespace ToDoListExampleForm_28_12_21.BusinessServices
{
    public class TodoServices
    {
        public int KayitKontrol()
        {
            return SanalDB.todoTablo.Count;
        }

        public List<Todo> kayitListele()
        {
            return SanalDB.todoTablo;
        }

        //public int KayitYeni(Todo data)
        //{

        //}
    }
}
