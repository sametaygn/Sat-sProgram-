using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Web;

namespace SatısProgramı
{
    class MesajEkranı
    {
        public void mesaj_goster_olumlu( string mesaj,int time)
        {
            MesajBox ff = new MesajBox();
            ff.button1.ForeColor = Color.LimeGreen;
            ff.interval = time;
            ff.mesaj = mesaj;
            ff.ShowDialog();
        }
        public void mesaj_goster_olumsuz(string mesaj, int time)
        {
            MesajBox ff = new MesajBox();
            ff.button1.ForeColor = Color.Crimson;
            ff.interval = time;
            ff.mesaj = mesaj;
            ff.ShowDialog();
        }
    }
}
