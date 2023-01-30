using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GE_1.ProjectManager;
using MyForms.FormsOverride;

namespace GE_1
{
    public partial class Editor : Form
    {
        public Editor(Project project)
        {
            InitializeComponent();

            this.WindowState = FormWindowState.Maximized;
        }
    }
}
