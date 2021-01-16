using System;
using System.Collections.Generic;
using System.Text;

namespace Methodlar
{
    class SepetManager
    {
        //name convention
        //syntax
        public void Ekle(Urun urun)//urun parametresi verildi
        {
            Console.WriteLine("Tebrikler.Sepete Eklendi!" + urun.Adi);

        }

        public void Ekle2(string urunAdi,string acıklama,double fiyat,int stokAdedi)
        {
            Console.WriteLine("Tebrikler.Sepete eklendi :" + urunAdi);
        }
    }

}
