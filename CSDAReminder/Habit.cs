using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSDAReminder
{
    //kelas habit untuk menyimpan jadwal yang bersifat harian seperti makan, mandi
    //waktu habit akan di set secara default dari program
    //habit akan di reset setiap harinya
    //akan memberikan notifikasi pengingat

    [Serializable]

    public class Habit
    {
        public String name { get; set; }
        public DateTime habitTime { get; set; }
        public Habit(String name, DateTime habitTime)
        {
            this.name = name;
            this.habitTime = habitTime;
        }
        public override String ToString()
        {
            return name;
        }
    }
}
