namespace WindowsFormsApp1
{
    partial class FormGiris
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbRezervasyonTip = new System.Windows.Forms.ComboBox();
            this.btnBugunkuBosYerler = new System.Windows.Forms.Button();
            this.btnOtuzGunlukDoluluk = new System.Windows.Forms.Button();
            this.btnGunBazindaDolulukOranlari = new System.Windows.Forms.Button();
            this.btnBugunHizliRezervasyonTek = new System.Windows.Forms.Button();
            this.btnGunSonu = new System.Windows.Forms.Button();
            this.btnIkıTarihArasiIkiYer = new System.Windows.Forms.Button();
            this.btnBugunHizliRezervasyonIkiYer = new System.Windows.Forms.Button();
            this.btnIkıTarihArasiTek = new System.Windows.Forms.Button();
            this.lbSonuclar = new System.Windows.Forms.ListBox();
            this.dtpBaslangic = new System.Windows.Forms.DateTimePicker();
            this.dtpBitis = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(33, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rezervasyon Tipi";
            // 
            // cmbRezervasyonTip
            // 
            this.cmbRezervasyonTip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRezervasyonTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbRezervasyonTip.FormattingEnabled = true;
            this.cmbRezervasyonTip.Location = new System.Drawing.Point(220, 31);
            this.cmbRezervasyonTip.Name = "cmbRezervasyonTip";
            this.cmbRezervasyonTip.Size = new System.Drawing.Size(207, 30);
            this.cmbRezervasyonTip.TabIndex = 1;
            this.cmbRezervasyonTip.SelectedIndexChanged += new System.EventHandler(this.cmbRezervasyonTip_SelectedIndexChanged);
            // 
            // btnBugunkuBosYerler
            // 
            this.btnBugunkuBosYerler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBugunkuBosYerler.Location = new System.Drawing.Point(20, 116);
            this.btnBugunkuBosYerler.Name = "btnBugunkuBosYerler";
            this.btnBugunkuBosYerler.Size = new System.Drawing.Size(198, 65);
            this.btnBugunkuBosYerler.TabIndex = 2;
            this.btnBugunkuBosYerler.Text = "Bugünkü Boş Yerler";
            this.btnBugunkuBosYerler.UseVisualStyleBackColor = true;
            this.btnBugunkuBosYerler.Click += new System.EventHandler(this.btnBugunkuBosYerler_Click);
            // 
            // btnOtuzGunlukDoluluk
            // 
            this.btnOtuzGunlukDoluluk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOtuzGunlukDoluluk.Location = new System.Drawing.Point(239, 116);
            this.btnOtuzGunlukDoluluk.Name = "btnOtuzGunlukDoluluk";
            this.btnOtuzGunlukDoluluk.Size = new System.Drawing.Size(198, 65);
            this.btnOtuzGunlukDoluluk.TabIndex = 3;
            this.btnOtuzGunlukDoluluk.Text = "30 Günlük Doluluk Durumu";
            this.btnOtuzGunlukDoluluk.UseVisualStyleBackColor = true;
            this.btnOtuzGunlukDoluluk.Click += new System.EventHandler(this.btnOtuzGunlukDoluluk_Click);
            // 
            // btnGunBazindaDolulukOranlari
            // 
            this.btnGunBazindaDolulukOranlari.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGunBazindaDolulukOranlari.Location = new System.Drawing.Point(458, 116);
            this.btnGunBazindaDolulukOranlari.Name = "btnGunBazindaDolulukOranlari";
            this.btnGunBazindaDolulukOranlari.Size = new System.Drawing.Size(198, 65);
            this.btnGunBazindaDolulukOranlari.TabIndex = 4;
            this.btnGunBazindaDolulukOranlari.Text = "Gün Bazında Doluluk Oranları";
            this.btnGunBazindaDolulukOranlari.UseVisualStyleBackColor = true;
            this.btnGunBazindaDolulukOranlari.Click += new System.EventHandler(this.btnGunBazindaDolulukOranlari_Click);
            // 
            // btnBugunHizliRezervasyonTek
            // 
            this.btnBugunHizliRezervasyonTek.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBugunHizliRezervasyonTek.Location = new System.Drawing.Point(677, 205);
            this.btnBugunHizliRezervasyonTek.Name = "btnBugunHizliRezervasyonTek";
            this.btnBugunHizliRezervasyonTek.Size = new System.Drawing.Size(198, 82);
            this.btnBugunHizliRezervasyonTek.TabIndex = 5;
            this.btnBugunHizliRezervasyonTek.Text = "Bugün İçin Hızlı Rezervasyon";
            this.btnBugunHizliRezervasyonTek.UseVisualStyleBackColor = true;
            this.btnBugunHizliRezervasyonTek.Click += new System.EventHandler(this.btnBugunHizliRezervasyonTek_Click);
            // 
            // btnGunSonu
            // 
            this.btnGunSonu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGunSonu.Location = new System.Drawing.Point(677, 116);
            this.btnGunSonu.Name = "btnGunSonu";
            this.btnGunSonu.Size = new System.Drawing.Size(198, 65);
            this.btnGunSonu.TabIndex = 9;
            this.btnGunSonu.Text = "Gün Sonu";
            this.btnGunSonu.UseVisualStyleBackColor = true;
            this.btnGunSonu.Click += new System.EventHandler(this.btnGunSonu_Click);
            // 
            // btnIkıTarihArasiIkiYer
            // 
            this.btnIkıTarihArasiIkiYer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIkıTarihArasiIkiYer.Location = new System.Drawing.Point(458, 205);
            this.btnIkıTarihArasiIkiYer.Name = "btnIkıTarihArasiIkiYer";
            this.btnIkıTarihArasiIkiYer.Size = new System.Drawing.Size(198, 82);
            this.btnIkıTarihArasiIkiYer.TabIndex = 8;
            this.btnIkıTarihArasiIkiYer.Text = "Iki Tarih Arasi Rezervasyon (Yan Yana Iki Yer)";
            this.btnIkıTarihArasiIkiYer.UseVisualStyleBackColor = true;
            this.btnIkıTarihArasiIkiYer.Click += new System.EventHandler(this.btnIkıTarihArasiIkiYer_Click);
            // 
            // btnBugunHizliRezervasyonIkiYer
            // 
            this.btnBugunHizliRezervasyonIkiYer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBugunHizliRezervasyonIkiYer.Location = new System.Drawing.Point(239, 205);
            this.btnBugunHizliRezervasyonIkiYer.Name = "btnBugunHizliRezervasyonIkiYer";
            this.btnBugunHizliRezervasyonIkiYer.Size = new System.Drawing.Size(198, 82);
            this.btnBugunHizliRezervasyonIkiYer.TabIndex = 7;
            this.btnBugunHizliRezervasyonIkiYer.Text = "Bugün için Hızlı Rezervasyon (Yan Yana iki Yer";
            this.btnBugunHizliRezervasyonIkiYer.UseVisualStyleBackColor = true;
            this.btnBugunHizliRezervasyonIkiYer.Click += new System.EventHandler(this.btnBugunHizliRezervasyonIkiYer_Click);
            // 
            // btnIkıTarihArasiTek
            // 
            this.btnIkıTarihArasiTek.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIkıTarihArasiTek.Location = new System.Drawing.Point(20, 205);
            this.btnIkıTarihArasiTek.Name = "btnIkıTarihArasiTek";
            this.btnIkıTarihArasiTek.Size = new System.Drawing.Size(198, 82);
            this.btnIkıTarihArasiTek.TabIndex = 6;
            this.btnIkıTarihArasiTek.Text = "Iki tarih arasi rezervasyon";
            this.btnIkıTarihArasiTek.UseVisualStyleBackColor = true;
            this.btnIkıTarihArasiTek.Click += new System.EventHandler(this.btnIkıTarihArasiTek_Click);
            // 
            // lbSonuclar
            // 
            this.lbSonuclar.FormattingEnabled = true;
            this.lbSonuclar.ItemHeight = 16;
            this.lbSonuclar.Location = new System.Drawing.Point(20, 383);
            this.lbSonuclar.Name = "lbSonuclar";
            this.lbSonuclar.Size = new System.Drawing.Size(928, 388);
            this.lbSonuclar.TabIndex = 10;
            // 
            // dtpBaslangic
            // 
            this.dtpBaslangic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpBaslangic.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBaslangic.Location = new System.Drawing.Point(239, 334);
            this.dtpBaslangic.Name = "dtpBaslangic";
            this.dtpBaslangic.Size = new System.Drawing.Size(250, 27);
            this.dtpBaslangic.TabIndex = 11;
            // 
            // dtpBitis
            // 
            this.dtpBitis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpBitis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBitis.Location = new System.Drawing.Point(570, 334);
            this.dtpBitis.Name = "dtpBitis";
            this.dtpBitis.Size = new System.Drawing.Size(200, 27);
            this.dtpBitis.TabIndex = 12;
            // 
            // FormGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 786);
            this.Controls.Add(this.dtpBitis);
            this.Controls.Add(this.dtpBaslangic);
            this.Controls.Add(this.lbSonuclar);
            this.Controls.Add(this.btnGunSonu);
            this.Controls.Add(this.btnIkıTarihArasiIkiYer);
            this.Controls.Add(this.btnBugunHizliRezervasyonIkiYer);
            this.Controls.Add(this.btnIkıTarihArasiTek);
            this.Controls.Add(this.btnBugunHizliRezervasyonTek);
            this.Controls.Add(this.btnGunBazindaDolulukOranlari);
            this.Controls.Add(this.btnOtuzGunlukDoluluk);
            this.Controls.Add(this.btnBugunkuBosYerler);
            this.Controls.Add(this.cmbRezervasyonTip);
            this.Controls.Add(this.label1);
            this.Name = "FormGiris";
            this.Text = "FormGiris";
            this.Load += new System.EventHandler(this.FormGiris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbRezervasyonTip;
        private System.Windows.Forms.Button btnBugunkuBosYerler;
        private System.Windows.Forms.Button btnOtuzGunlukDoluluk;
        private System.Windows.Forms.Button btnGunBazindaDolulukOranlari;
        private System.Windows.Forms.Button btnBugunHizliRezervasyonTek;
        private System.Windows.Forms.Button btnGunSonu;
        private System.Windows.Forms.Button btnIkıTarihArasiIkiYer;
        private System.Windows.Forms.Button btnBugunHizliRezervasyonIkiYer;
        private System.Windows.Forms.Button btnIkıTarihArasiTek;
        private System.Windows.Forms.ListBox lbSonuclar;
        private System.Windows.Forms.DateTimePicker dtpBaslangic;
        private System.Windows.Forms.DateTimePicker dtpBitis;
    }
}