using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AKARCAFE.DesktopUI.Ortak.GUI
{
    public partial class Loading_Program_Screen : Form
    {
        public Loading_Program_Screen()
        {
            InitializeComponent();
             

            int screenWidth = Screen.PrimaryScreen.Bounds.Width;
            int height = Screen.PrimaryScreen.Bounds.Height;
            this.Width = screenWidth / 2;
            this.Height = height / 2;
            this.WindowState = FormWindowState.Normal;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Loading_Program_Screen_Load(object sender, EventArgs e)
        {

            timer1.Interval = 3000;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            Giris g = new Giris();
            this.Hide();
            g.Show();
        }
    }
}


 





 