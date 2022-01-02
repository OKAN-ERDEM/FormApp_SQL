using DAL;
using MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class OgrenciBL
    {
        public bool OgrenciEkle(Ogrenci ogr)
        {
            Helper hlp = new Helper();
            int sonuc = hlp.ExecuteNonQuery($"Insert into Ogrenci (Ad,Soyad,Numara,TC_No,Sinif_ID)VALUES('{ogr.Ad}','{ogr.Soyad}','{ogr.Numara}','{ogr.TC_No}',{ogr.Sinif_ID})");
            return sonuc > 0;

        }
    }
}
