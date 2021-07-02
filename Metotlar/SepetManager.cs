using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    // manager, service , dal ,data access,controller gibi ifadeler bir operasyon tutuyor demektir.
    class SepetManager
    {
        //naming convention - metotlar ilk harfi büyük.
        //syntax yazım şekilleri
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Sepete eklendi! : "+urun.Adi);
        }

        public void Ekle2(string urunAdi,string aciklama,double fiyat,int stokAdedi)
        {
            Console.WriteLine("Sepete eklendi! : " + urunAdi);
        }
    }
}
