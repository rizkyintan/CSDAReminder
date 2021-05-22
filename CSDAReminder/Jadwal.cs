using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSDAReminder
{
    //kelas jadwal berisi jadwal kuliah atau kegiatan rutin
    //yang dilakukan sama setiap minggu
    //seperti jadwal kuliah

    [Serializable]
    public class Jadwal
    {
        public String deskripsi { get; set; }
        public DateTime tanggalJadwal { get; set; }

        public Jadwal(String deskripsi, DateTime tanggalJadwal)
        {
            this.deskripsi = deskripsi;
            this.tanggalJadwal = tanggalJadwal;
        }

        public override String ToString()
        {
            return deskripsi + " \t" + tanggalJadwal.ToString("dddd" + " HH:mm");
        }

    }
}
