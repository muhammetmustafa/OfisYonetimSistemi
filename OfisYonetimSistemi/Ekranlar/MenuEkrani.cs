using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OfisYonetimSistemi.Ekranlar
{
    public partial class MenuEkrani : Form
    {
        public MenuEkrani()
        {
            InitializeComponent();
        }

        private void btnMusteri_Click(object sender, EventArgs e)
        {
            var musteriEkrani = new MusteriEkrani();
            musteriEkrani.Show(this);
        }
    }
}
