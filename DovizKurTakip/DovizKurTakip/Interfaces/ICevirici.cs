namespace DovizCeviriciApp.Interfaces
{
    public interface ICevirici
    {
        decimal Cevir(decimal miktar, string kaynakKur, string hedefKur);
    }
}
