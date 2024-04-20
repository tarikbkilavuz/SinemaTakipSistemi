using SinemaSeansTakip;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinemaSeansTakip
{
    internal static class Program
    {
       
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DbInitializer.InitializeDatabase();
            Application.Run(new Form1()); 
        }
    }
}
