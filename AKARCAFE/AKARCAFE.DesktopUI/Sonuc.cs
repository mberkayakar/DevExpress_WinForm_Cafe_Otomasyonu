using AKARCAFE.Business.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AKARCAFE.DesktopUI
{
    public partial class Sonuc : Form
    {
        public Sonuc()
        {
            InitializeComponent();
        }

        private ISonuc _Sonuc;
        public Sonuc( ISonuc sonuc)
        {
            InitializeComponent();
            _Sonuc = sonuc;
        }



        private void Sonuc_Load(object sender, EventArgs e)
        {
            this.Text = _Sonuc.SonucGetir();
        }
    }
}
