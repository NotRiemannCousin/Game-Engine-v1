using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using GE_1.ProjectManager;

namespace GE_1
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Window_init());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetType().FullName, ex.Message);
            }
        }
    }
}
