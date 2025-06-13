namespace DovizKurTakip
{
    partial class BASLIK
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.miktarlbl = new System.Windows.Forms.Label();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.cmbKaynakKur = new System.Windows.Forms.ComboBox();
            this.cmbHedefKur = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sonuçyazıLBL = new System.Windows.Forms.Label();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.cevirBtn = new System.Windows.Forms.Button();
            this.btnKurGüncelle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lstKurlar = new System.Windows.Forms.ListBox();
            this.lblSonGuncelleme = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(153, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(587, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Döviz Takip ve Kur Çevirici";
            // 
            // miktarlbl
            // 
            this.miktarlbl.Font = new System.Drawing.Font("Bookman Old Style", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miktarlbl.Location = new System.Drawing.Point(57, 130);
            this.miktarlbl.Name = "miktarlbl";
            this.miktarlbl.Size = new System.Drawing.Size(96, 28);
            this.miktarlbl.TabIndex = 1;
            this.miktarlbl.Text = "MİKTAR :";
            // 
            // txtMiktar
            // 
            this.txtMiktar.Location = new System.Drawing.Point(159, 127);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(100, 28);
            this.txtMiktar.TabIndex = 2;
            // 
            // cmbKaynakKur
            // 
            this.cmbKaynakKur.FormattingEnabled = true;
            this.cmbKaynakKur.Location = new System.Drawing.Point(420, 130);
            this.cmbKaynakKur.Name = "cmbKaynakKur";
            this.cmbKaynakKur.Size = new System.Drawing.Size(115, 28);
            this.cmbKaynakKur.TabIndex = 3;
            // 
            // cmbHedefKur
            // 
            this.cmbHedefKur.FormattingEnabled = true;
            this.cmbHedefKur.Location = new System.Drawing.Point(703, 130);
            this.cmbHedefKur.Name = "cmbHedefKur";
            this.cmbHedefKur.Size = new System.Drawing.Size(106, 28);
            this.cmbHedefKur.TabIndex = 4;
            this.cmbHedefKur.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(312, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kaynak :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(607, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hedef :";
            // 
            // sonuçyazıLBL
            // 
            this.sonuçyazıLBL.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sonuçyazıLBL.Location = new System.Drawing.Point(57, 226);
            this.sonuçyazıLBL.Name = "sonuçyazıLBL";
            this.sonuçyazıLBL.Size = new System.Drawing.Size(76, 27);
            this.sonuçyazıLBL.TabIndex = 7;
            this.sonuçyazıLBL.Text = "Sonuç:";
            // 
            // lblSonuc
            // 
            this.lblSonuc.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblSonuc.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSonuc.Location = new System.Drawing.Point(148, 226);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(290, 40);
            this.lblSonuc.TabIndex = 8;
            // 
            // cevirBtn
            // 
            this.cevirBtn.BackColor = System.Drawing.Color.LawnGreen;
            this.cevirBtn.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cevirBtn.Location = new System.Drawing.Point(572, 226);
            this.cevirBtn.Name = "cevirBtn";
            this.cevirBtn.Size = new System.Drawing.Size(125, 40);
            this.cevirBtn.TabIndex = 9;
            this.cevirBtn.Text = "Cevir";
            this.cevirBtn.UseVisualStyleBackColor = false;
            this.cevirBtn.Click += new System.EventHandler(this.cevirBtn_Click);
            // 
            // btnKurGüncelle
            // 
            this.btnKurGüncelle.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKurGüncelle.Location = new System.Drawing.Point(52, 414);
            this.btnKurGüncelle.Name = "btnKurGüncelle";
            this.btnKurGüncelle.Size = new System.Drawing.Size(169, 34);
            this.btnKurGüncelle.TabIndex = 10;
            this.btnKurGüncelle.Text = "Kur Güncelle";
            this.btnKurGüncelle.UseVisualStyleBackColor = true;
            this.btnKurGüncelle.Click += new System.EventHandler(this.btnKurGüncelle_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 353);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(291, 26);
            this.label4.TabIndex = 11;
            this.label4.Text = "Kur Güncellene Menüsü";
            // 
            // lstKurlar
            // 
            this.lstKurlar.FormattingEnabled = true;
            this.lstKurlar.ItemHeight = 20;
            this.lstKurlar.Location = new System.Drawing.Point(52, 482);
            this.lstKurlar.Name = "lstKurlar";
            this.lstKurlar.Size = new System.Drawing.Size(159, 164);
            this.lstKurlar.TabIndex = 12;
            // 
            // lblSonGuncelleme
            // 
            this.lblSonGuncelleme.BackColor = System.Drawing.SystemColors.Info;
            this.lblSonGuncelleme.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSonGuncelleme.Location = new System.Drawing.Point(474, 419);
            this.lblSonGuncelleme.Name = "lblSonGuncelleme";
            this.lblSonGuncelleme.Size = new System.Drawing.Size(210, 34);
            this.lblSonGuncelleme.TabIndex = 13;
            this.lblSonGuncelleme.Text = "Son Gümcelleme";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(52, 715);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 28);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(61, 767);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 33);
            this.button1.TabIndex = 15;
            this.button1.Text = "Geçmiş Kurlar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(375, 621);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(300, 166);
            this.chart1.TabIndex = 16;
            this.chart1.Text = "chart1";
            // 
            // BASLIK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 830);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblSonGuncelleme);
            this.Controls.Add(this.lstKurlar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnKurGüncelle);
            this.Controls.Add(this.cevirBtn);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.sonuçyazıLBL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbHedefKur);
            this.Controls.Add(this.cmbKaynakKur);
            this.Controls.Add(this.txtMiktar);
            this.Controls.Add(this.miktarlbl);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Bodoni MT Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "BASLIK";
            this.Text = "MİKTAR";
            this.Load += new System.EventHandler(this.BASLIK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label miktarlbl;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.ComboBox cmbKaynakKur;
        private System.Windows.Forms.ComboBox cmbHedefKur;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label sonuçyazıLBL;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.Button cevirBtn;
        private System.Windows.Forms.Button btnKurGüncelle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstKurlar;
        private System.Windows.Forms.Label lblSonGuncelleme;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

