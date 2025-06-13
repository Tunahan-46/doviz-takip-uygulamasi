using DovizKurTakip.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DovizKurTakip.Services;


namespace DovizKurTakip
{
    public partial class BASLIK: Form
    {

        private Dictionary<string, decimal> guncelKurlar = new Dictionary<string, decimal>();

        public BASLIK()
        {
            InitializeComponent();
            this.Shown += async (s, e) => await MainForm_Load();
        }

        private async Task MainForm_Load()
        {
            try
            {
                guncelKurlar = await KurServisi.KurGetirAsync("TRY");

                cmbKaynakKur.DataSource = guncelKurlar.Keys.ToList();
                cmbHedefKur.DataSource = guncelKurlar.Keys.ToList();

                cmbKaynakKur.SelectedItem = "USD";
                cmbHedefKur.SelectedItem = "TRY";

                lblSonGuncelleme.Text = $"Son Güncelleme: {DateTime.Now:dd.MM.yyyy}";

                ListeleKurlar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kur verisi alınamadı: " + ex.Message);
            }
        }


        private void ListeleKurlar()
        {
            lstKurlar.Items.Clear();
            foreach (var kur in guncelKurlar)
            {
                lstKurlar.Items.Add($"{kur.Key}: {kur.Value}");
            }
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BASLIK_Load(object sender, EventArgs e)
        {

        }

        private void cevirBtn_Click(object sender, EventArgs e)
        {
            if (cmbKaynakKur.SelectedItem == null || cmbHedefKur.SelectedItem == null)
            {
                MessageBox.Show("Lütfen döviz birimlerini seçin.");
                return;
            }

            if (!decimal.TryParse(txtMiktar.Text, out decimal miktar))
            {
                MessageBox.Show("Geçerli bir miktar girin.");
                return;
            }

            string kaynak = cmbKaynakKur.SelectedItem.ToString();
            string hedef = cmbHedefKur.SelectedItem.ToString();

            if (guncelKurlar.TryGetValue(kaynak, out decimal kaynakKur) &&
                guncelKurlar.TryGetValue(hedef, out decimal hedefKur))
            {
                decimal tryMiktar = miktar / kaynakKur;
                decimal sonuc = tryMiktar * hedefKur;
                lblSonuc.Text = $"{miktar} {kaynak} = {sonuc:F4} {hedef}";
            }
            else
            {
                MessageBox.Show("Seçilen para birimlerine ait kur bilgisi bulunamadı.");
            }
        }


        private async void btnKurGüncelle_Click(object sender, EventArgs e)
        {
            try
            {
                guncelKurlar = await KurServisi.KurGetirAsync("TRY");
                ListeleKurlar();

                cmbKaynakKur.DataSource = guncelKurlar.Keys.ToList();
                cmbHedefKur.DataSource = guncelKurlar.Keys.ToList();

                lblSonGuncelleme.Text = $"Son Güncelleme: {DateTime.Now:dd.MM.yyyy}";
                MessageBox.Show("Kur bilgileri API'den güncellendi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kur bilgileri alınamadı: " + ex.Message);
            }
        }


        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
