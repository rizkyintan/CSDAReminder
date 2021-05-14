using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSDAReminder
{
    public class User
    {
        public string nama { get; set; }
        public User(string nama)
        {
            this.nama = nama;
        }
        public override string ToString()
        {
            return nama;
        }
    }
}
