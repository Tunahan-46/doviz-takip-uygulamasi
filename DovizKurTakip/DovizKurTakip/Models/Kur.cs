using System;

namespace DovizCeviriciApp.Models
{
    public class Kur
    {
        public string DovizKodu { get; set; }      // Örn: USD
        public decimal Alis { get; set; }          // Alış kuru
        public decimal Satis { get; set; }         // Satış kuru
        public DateTime Tarih { get; set; }        // Kur tarihi
    }
}
