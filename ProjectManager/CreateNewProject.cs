using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GE_1.ProjectManager
{
    public partial class Window_createNewProject : Form
    {
        #region properties
        private static Window_createNewProject _instance;
        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x00020000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);
        #endregion


        public static Window_createNewProject getInstance()
        {
            if( _instance == null || _instance.IsDisposed)
                _instance = new Window_createNewProject();
            return _instance;
        }
        private Window_createNewProject()
        {
            InitializeComponent();
        }

        #region Movable Window
        private void pn_moveWindow_MouseDown(object sender, MouseEventArgs e)
        {

            dragging = true;
            startPoint = new Point(e.X, e.Y);

        }

        private void pn_moveWindow_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void pn_moveWindow_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
                this.Location = Location;
            }

        }

        #endregion

        private void btn_folderBrowser_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            


            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txt_projectLocation.Text = dialog.SelectedPath;
            }
        }
    }
}
