using AKARCAFE.DesktopUI.Ortak.GUI;
using AKARCAFE.DesktopUI.Ortak.IOC;
using Autofac;
using System;
using System.Windows.Forms;

namespace AKARCAFE.DesktopUI
{
    static class Program
    {


        public static IContainer Container;
     
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            // Dependency İnjection 
            Container = MicrosoftIOC.Configure();
            
            Application.Run(new Loading_Program_Screen());
        }


 
    }
}
