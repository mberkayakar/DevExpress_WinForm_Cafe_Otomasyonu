using DevExpress.XtraEditors.Repository;
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
    public partial class frmgiris : Form
    {
        public frmgiris()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (textEdit2.Properties.PasswordChar == '*')
            {
                textEdit2.Properties.PasswordChar = '\0';
                 simpleButton1.Image = AKARCAFE.DesktopUI.Properties.Resources.show_16x16;
            }
            else
            {
                simpleButton1.Image = AKARCAFE.DesktopUI.Properties.Resources.hide_16x16;
                textEdit2.Properties.PasswordChar = '*';

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
