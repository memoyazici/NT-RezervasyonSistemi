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
    public partial class GunlukDurum : Form
    {
        public GunlukDurum()
        {
            InitializeComponent();
        }

        public GunlukDurum(Rezervasyon r)
        {
            InitializeComponent();
            this.rezervasyon = r;
        }

        Rezervasyon rezervasyon;

        private void GunlukDurum_Load(object sender, EventArgs e)
        {
            List<int> odalar = rezervasyon.BugunkuBosOdalar();
            
            for (int i = 0; i < 10; i++)
            {

            }
        }
    }
}
