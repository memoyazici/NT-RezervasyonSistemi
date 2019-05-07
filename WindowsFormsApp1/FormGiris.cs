using RezervasyonClassLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace WindowsFormsApp1
{
    public partial class FormGiris : Form
    {
        public FormGiris()
        {
            InitializeComponent();
            

        }

        List<string> rezervasyonTipler = new List<string>();


        Rezervasyon rezervasyon;

        private void FormGiris_Load(object sender, EventArgs e)
        {
                        
            rezervasyonTipler.Add("ButikOtel");
            rezervasyonTipler.Add("Yat");
            rezervasyonTipler.Add("Cadir");
            cmbRezervasyonTip.DataSource = rezervasyonTipler;

            rezervasyon.RasgeleDoldur();


        }

        private void btnBugunkuBosYerler_Click(object sender, EventArgs e)
        {

            // GunlukDurum f = new GunlukDurum(rezervasyon);
            //dataGrid.DataSource = rezervasyon.BugunkuBosOdalar()
            //     .Select(x=> new {Liste = x }).ToList();

            lbSonuclar.DisplayMember = "Liste";
            lbSonuclar.DataSource = rezervasyon.BugunkuBosOdalar()
                .Select(x => new { Liste = x }).ToList();

        }

        private void cmbRezervasyonTip_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRezervasyonTip.SelectedItem.Equals("ButikOtel"))
            {
                rezervasyon = new ButikOtelRezervasyonu();
                btnBugunHizliRezervasyonIkiYer.Enabled = rezervasyon.YanYanaIkiYerBirdenRezervasyonYapilabilirMi();
                btnIkıTarihArasiIkiYer.Enabled = rezervasyon.YanYanaIkiYerBirdenRezervasyonYapilabilirMi();
                
            }
            else if (cmbRezervasyonTip.SelectedItem.Equals("Yat"))
            {
                rezervasyon = new YatLimaniRezervasyonu();
                btnBugunHizliRezervasyonIkiYer.Enabled = rezervasyon.YanYanaIkiYerBirdenRezervasyonYapilabilirMi();
                btnIkıTarihArasiIkiYer.Enabled = rezervasyon.YanYanaIkiYerBirdenRezervasyonYapilabilirMi();

            }
            else
            {
                rezervasyon = new CadirRezervasyonu();
                btnBugunHizliRezervasyonIkiYer.Enabled = rezervasyon.YanYanaIkiYerBirdenRezervasyonYapilabilirMi();
                btnIkıTarihArasiIkiYer.Enabled = rezervasyon.YanYanaIkiYerBirdenRezervasyonYapilabilirMi();

            }
        }

        private void btnOtuzGunlukDoluluk_Click(object sender, EventArgs e)
        {
            lbSonuclar.DataSource = null;
            lbSonuclar.Items.Clear();
            //dataGrid.DataSource = null;
            //dataGrid.Update();
            //dataGrid.Refresh();
            string kolonAd = "";

            string[,] AylikMatrix = new string[10, 30];
            
            AylikMatrix = rezervasyon.AylikDolulukDurumu();
            
            for (int i = 0; i < 30; i++)
            {
                
                kolonAd += " "+(DateTime.Now.AddDays(i).Day).ToString("D2") + " ";
                //dataGrid.Columns.Add(kolonAd, kolonAd);
                
                
            }
            string bosluk = "         ";
            lbSonuclar.Items.Add(" " +bosluk+kolonAd);




            //    DataGridViewRow dgvr;
            //    for (int i = 0; i < 10; i++)
            //    {
            //        dgvr = new DataGridViewRow();
            //        for (int j = 0; j < 30; j++)
            //        {

            //            dgvr.Cells[j].Value = AylikMatrix[i, j];
            //        }

            //        dataGrid.Rows.Add(dgvr);
            //    }

            string ay = "";

            

            for (int i = 0; i < 10; i++)
            {
                
                for (int j = 0; j < 30; j++)
                {
                    if (j%4==0)
                    {
                        ay += " ";
                    }
                    ay += AylikMatrix[i, j] + " ";
                    
                }
                lbSonuclar.Items.Add("  "+bosluk+ay);
                ay = string.Empty;

            }


        }

        private void btnGunBazindaDolulukOranlari_Click(object sender, EventArgs e)
        {
            lbSonuclar.DataSource = null;
            lbSonuclar.Items.Clear();
            lbSonuclar.Items.Add(TarihCetveli());


            int[] oranlar = rezervasyon.GunBazindaDolulukOranlari();

            string oranString = "";
            for (int i = 0; i < 30; i++)
            {
                oranString += " " + oranlar[i].ToString("D2") + " ";
            }
            lbSonuclar.Items.Add("          " + oranString);
            
        }

        private string TarihCetveli()
        {
            string kolonAd = "";

            for (int i = 0; i < 30; i++)
            {
                kolonAd += " " + (DateTime.Now.AddDays(i).Day).ToString("D2") + " ";
            }
            string bosluk = "         ";
            //lbSonuclar.Items.Add(" " + bosluk + kolonAd);
            return (" " + bosluk + kolonAd);
        }

        private void btnBugunHizliRezervasyonTek_Click(object sender, EventArgs e)
        {
            
            lbSonuclar.Items.Clear();
            rezervasyon.RezervasyonYap(
                DateTime.Now,
                DateTime.Now,
                rezervasyon.YanYanaIkiYerBirdenRezervasyonYapilabilirMi()
                );
            GunBazindakiListbox();
        }

        private void btnIkıTarihArasiTek_Click(object sender, EventArgs e)
        {
            rezervasyon.RezervasyonYap(
                dtpBaslangic.Value,
                dtpBitis.Value,
                rezervasyon.YanYanaIkiYerBirdenRezervasyonYapilabilirMi());
        }

        private void btnGunSonu_Click(object sender, EventArgs e)
        {
            lbSonuclar.Items.Clear();
            rezervasyon.GunSonuIslemi();
            GunBazindakiListbox();
        }


        private void GunBazindakiListbox()
        {
            string kolonAd = "";

            string[,] AylikMatrix = new string[10, 30];

            AylikMatrix = rezervasyon.AylikDolulukDurumu();

            for (int i = 0; i < 30; i++)
            {
                kolonAd += " " + (DateTime.Now.AddDays(i).Day).ToString("D2") + " ";
            }
            string bosluk = "         ";
            lbSonuclar.Items.Add(" " + bosluk + kolonAd);
            
            string ay = "";
            
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 30; j++)
                {
                    if (j % 4 == 0)
                    {
                        ay += " ";
                    }
                    ay += AylikMatrix[i, j] + " ";
                }
                lbSonuclar.Items.Add("  " + bosluk + ay);
                ay = string.Empty;
            }
        }

        private void btnBugunHizliRezervasyonIkiYer_Click(object sender, EventArgs e)
        {
            rezervasyon.RezervasyonYap(
                DateTime.Now,
                DateTime.Now,
                rezervasyon.YanYanaIkiYerBirdenRezervasyonYapilabilirMi());
        }

        private void btnIkıTarihArasiIkiYer_Click(object sender, EventArgs e)
        {
            rezervasyon.RezervasyonYap(
               dtpBaslangic.Value,
               dtpBitis.Value,
               rezervasyon.YanYanaIkiYerBirdenRezervasyonYapilabilirMi());
        }
    }
}
