using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyManagerLibrary
{
    public class User
    {
        public string ID { get; set; }
        public string  Nama { get; set; }

        public User(string id, string nama)
        {
            ID = id;
            Nama = nama;
        }
    }
}
