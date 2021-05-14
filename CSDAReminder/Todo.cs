using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSDAReminder
{
    //kelas todo untuk menaruh list yang ingin dilakukan
    //tanpa memberi waktu pengingat
    //[Serializable]
    public class Todo
    {
        public string nama { get; set; }
        public Todo(string nama)
        {
            this.nama = nama;
        }
        public override string ToString()
        {
            return nama;
        }
    }
}
