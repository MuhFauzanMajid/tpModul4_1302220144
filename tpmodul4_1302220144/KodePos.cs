using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul4_1302220144
{
    class KodePos
    {
        private static Dictionary<string, int> tabelKodePos = new Dictionary<string, int>
    {
        {"Batununggal", 40266},
        {"Kujangsar", 40287},
        {"Mengger", 40267},
        {"Wales", 40256},
        {"Cijaura", 40287},
        {"Jatisari", 40286},
        {"Margasari", 40286},
        {"Sekejati", 40286},
        {"Kebonwaru", 40272},
        {"Maleer", 40274},
        {"Samoja", 40273}
    };

        public int getKodePos(string lokasi)
        {
            if (tabelKodePos.ContainsKey(lokasi))
            {
                return tabelKodePos[lokasi];
            }
            else
            {
                return 0; // atau bisa mengembalikan nilai lain jika kode pos tidak ditemukan
            }
        }
    }
}
