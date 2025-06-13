using System;
using System.Collections.Generic;

namespace DovizKurTakip.Models
{
    public class Kur
    {
        public string KurKodu { get; set; }
        public decimal Deger { get; set; }
        public DateTime Tarih { get; set; }
    }

    public static class KurGecmisi
    {
        public static List<Kur> GecmisKurlar = new List<Kur>();

        public static void Ekle(string kurKodu, decimal deger)
        {
            GecmisKurlar.Add(new Kur
            {
                KurKodu = kurKodu,
                Deger = deger,
                Tarih = DateTime.Now
            });
        }
    }
}
