using System.Windows.Forms;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Drawing;
using System.Xml;
using System.Xml.Linq;
using MyForms.FormsOverride;
using System.Windows.Controls;
using System.Windows.Media;
using System.Diagnostics;
using GE_1;

namespace GE_1.ProjectManager
{
    public partial class Window_init : Form
    {
        #region properties
        List<Project> projects = new List<Project>();

        private bool dragging = false;
        private Point startPoint = new Point(0, 0);
        // selected project in the box
        public int selectedProjIndex { get { return lbx_selectProject.SelectedIndex; } private set { } }
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
        #endregion


        public Window_init()
        {
            #region windowConfig

            InitializeComponent();
            this.CenterToScreen();

            #endregion

            try
            {



                // search all Projects in Constants.pathProjects

                DirectoryInfo projsDirectory = new DirectoryInfo(Constants.pathProjects);

                foreach (DirectoryInfo folder in projsDirectory.GetDirectories())
                    foreach (FileInfo file in folder.GetFiles("*.pjt"))
                    {
                    Project proj = new Project(file.DirectoryName, file.Name);

                    if (!proj.isValid)
                        continue;

                    projects.Add(proj);

                    lbx_selectProject.Items.Add(proj.Name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().Name);
            }


            Editor editor = new Editor(projects[0]);
            editor.ShowDialog();
        }

        #region Select Project

        private void mat_btn_run_Click(object sender, EventArgs e)
        {
            if (selectedProjIndex == -1)
                return;
            Editor editor = new Editor(projects[selectedProjIndex]);
            editor.ShowDialog();
            this.Close();
        }
        private void lbx_selectProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbx_selectProject.SelectedIndex == -1)
                return;
            lb_selectedProjectName.Text = projects[selectedProjIndex].Name;
            lb_lastTimeOpen.Text = projects[selectedProjIndex].LastTimeOpen.ToString("dd/MM/yyyy, hh:mm");
            try
            {
                img_selectedProject.LoadAsync(projects[selectedProjIndex].Path + "");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().Name);
            }


        }
        private void mat_btn_loadOtherProject_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "Hydra Project File | *.pjt",
                Title = "Select Project File",
                InitialDirectory = Constants.pathProjects
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileInfo file = new FileInfo(ofd.FileName);
                Project pjt = new Project(file.DirectoryName, file.Name);

                if (!pjt.isValid)
                {
                    MessageBox.Show("Project is not valid!");
                    return;
                }
                foreach (var p in projects)
                    if (pjt.Path == p.Path)
                    {
                        MessageBox.Show("Project is already listed!");
                        return;
                    }



                projects.Add(pjt);
                lbx_selectProject.Items.Add(pjt.Name);

            }
        }
        #endregion

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

        #region edit Projects
        private void mat_btn_createProject_Click(object sender, EventArgs e)
        {
            Window_createNewProject createProject = Window_createNewProject.getInstance();
            
            createProject.Show(this);
        }
        #endregion
    }
}
