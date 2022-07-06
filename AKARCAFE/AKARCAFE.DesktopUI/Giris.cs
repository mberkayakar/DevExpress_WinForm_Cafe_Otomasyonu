using AKARCAFE.Business.Abstract;
using System;
using System.Windows.Forms;


namespace AKARCAFE.DesktopUI
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }


        private readonly ISonuc sonuc;

        public Giris(ISonuc s)
        {
            InitializeComponent();
            sonuc = s;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            Gelisme g = new Gelisme();
            g.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sonuc s = new Sonuc(sonuc);
            s.Show();
        }

        private void Giris_Load(object sender, EventArgs e)
        {

        }
    }
}
