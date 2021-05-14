using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSDAReminder
{
    public class JadwalIbadah
    {
        public enum Sholat
        { 
            Subuh,
            Dzuhur,
            Ashar,
            Maghrib,
            Isyak
        }

        public String name = "";

        public string Lokasi { get; set; }
        public DateTime waktuIbadah{ get; set; }
        public bool doneToday { get; set; } = false;
        public Sholat sholat { get; }

        public JadwalIbadah(Sholat sholat, DateTime waktuIbadah)
        {
            this.sholat = sholat;
            this.waktuIbadah = waktuIbadah;
        }

        public override String ToString()
        {
            return sholat + " " + waktuIbadah.ToString();
        }

    }
}
