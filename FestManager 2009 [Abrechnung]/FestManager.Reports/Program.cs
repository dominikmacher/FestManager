using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FestManager.Reports
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.Run(new Form1());
        }
    }
}
