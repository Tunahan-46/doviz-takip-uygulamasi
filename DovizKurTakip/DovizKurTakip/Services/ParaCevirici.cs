using System.Collections.Generic;

namespace DovizKurTakip.Services
{
    public interface ICevirici
    {
        decimal Cevir(decimal miktar, string kaynakKur, string hedefKur);
    }

    public class ParaCevirici : ICevirici
    {
        private readonly Dictionary<string, decimal> kurlar;

        public ParaCevirici(Dictionary<string, decimal> kurlar)
        {
            this.kurlar = kurlar;
        }

        public decimal Cevir(decimal miktar, string kaynakKur, string hedefKur)
        {
            if (kurlar.TryGetValue(kaynakKur, out decimal kaynakDeger) &&
                kurlar.TryGetValue(hedefKur, out decimal hedefDeger))
            {
                decimal tryMiktar = miktar * kaynakDeger;
                return tryMiktar / hedefDeger;
            }

            return 0;
        }
    }
}
