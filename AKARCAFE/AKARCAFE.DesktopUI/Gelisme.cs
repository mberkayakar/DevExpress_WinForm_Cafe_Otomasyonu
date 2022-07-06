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
    public partial class Gelisme : Form
    {
        public Gelisme()
        {
            InitializeComponent();
        }

        private readonly IGelisme _Gelisme;
        public Gelisme(IGelisme gelisme)
        {
            InitializeComponent();
            _Gelisme = gelisme;
        }
    }
}
