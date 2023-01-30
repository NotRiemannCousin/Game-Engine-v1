namespace GE_1.ProjectManager
{
    partial class Window_init
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Window_init));
            this.pn_selectedProject = new System.Windows.Forms.Panel();
            this.lb_lastTimeOpen = new System.Windows.Forms.Label();
            this.mat_btn_run = new MaterialSkin.Controls.MaterialButton();
            this.img_selectedProject = new System.Windows.Forms.PictureBox();
            this.lb_selectedProjectName = new System.Windows.Forms.Label();
            this.pn_moveWindow = new System.Windows.Forms.Panel();
            this.mat_btn_createProject = new MaterialSkin.Controls.MaterialButton();
            this.mat_btn_loadOtherProject = new MaterialSkin.Controls.MaterialButton();
            this.lbx_selectProject = new MyForms.FormsOverride.MyListBox();
            this.pn_main = new System.Windows.Forms.Panel();
            this.pn_selectedProject.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_selectedProject)).BeginInit();
            this.pn_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_selectedProject
            // 
            this.pn_selectedProject.BackColor = System.Drawing.Color.Transparent;
            this.pn_selectedProject.Controls.Add(this.lb_lastTimeOpen);
            this.pn_selectedProject.Controls.Add(this.mat_btn_run);
            this.pn_selectedProject.Controls.Add(this.img_selectedProject);
            this.pn_selectedProject.Controls.Add(this.lb_selectedProjectName);
            this.pn_selectedProject.Location = new System.Drawing.Point(408, 56);
            this.pn_selectedProject.Name = "pn_selectedProject";
            this.pn_selectedProject.Size = new System.Drawing.Size(500, 383);
            this.pn_selectedProject.TabIndex = 3;
            // 
            // lb_lastTimeOpen
            // 
            this.lb_lastTimeOpen.BackColor = System.Drawing.Color.Transparent;
            this.lb_lastTimeOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lb_lastTimeOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_lastTimeOpen.ForeColor = System.Drawing.Color.DarkGray;
            this.lb_lastTimeOpen.Location = new System.Drawing.Point(337, 263);
            this.lb_lastTimeOpen.Name = "lb_lastTimeOpen";
            this.lb_lastTimeOpen.Size = new System.Drawing.Size(156, 17);
            this.lb_lastTimeOpen.TabIndex = 5;
            this.lb_lastTimeOpen.Text = "Aberto pela ultima vez...";
            this.lb_lastTimeOpen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mat_btn_run
            // 
            this.mat_btn_run.AutoSize = false;
            this.mat_btn_run.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mat_btn_run.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            this.mat_btn_run.Depth = 0;
            this.mat_btn_run.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mat_btn_run.HighEmphasis = true;
            this.mat_btn_run.Icon = null;
            this.mat_btn_run.Location = new System.Drawing.Point(357, 345);
            this.mat_btn_run.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mat_btn_run.MouseState = MaterialSkin.MouseState.HOVER;
            this.mat_btn_run.Name = "mat_btn_run";
            this.mat_btn_run.NoAccentTextColor = System.Drawing.Color.Empty;
            this.mat_btn_run.Size = new System.Drawing.Size(136, 32);
            this.mat_btn_run.TabIndex = 4;
            this.mat_btn_run.Text = "Run";
            this.mat_btn_run.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mat_btn_run.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mat_btn_run.UseAccentColor = false;
            this.mat_btn_run.UseVisualStyleBackColor = true;
            this.mat_btn_run.Click += new System.EventHandler(this.mat_btn_run_Click);
            // 
            // img_selectedProject
            // 
            this.img_selectedProject.ErrorImage = ((System.Drawing.Image)(resources.GetObject("img_selectedProject.ErrorImage")));
            this.img_selectedProject.ImageLocation = "C:\\USers\\Aluno\\Documents\\Marcelo\\GE\\GE 1\\imgs\\default_project.png";
            this.img_selectedProject.Location = new System.Drawing.Point(6, 3);
            this.img_selectedProject.Name = "img_selectedProject";
            this.img_selectedProject.Size = new System.Drawing.Size(487, 213);
            this.img_selectedProject.TabIndex = 2;
            this.img_selectedProject.TabStop = false;
            // 
            // lb_selectedProjectName
            // 
            this.lb_selectedProjectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.lb_selectedProjectName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lb_selectedProjectName.Location = new System.Drawing.Point(6, 219);
            this.lb_selectedProjectName.Name = "lb_selectedProjectName";
            this.lb_selectedProjectName.Size = new System.Drawing.Size(487, 43);
            this.lb_selectedProjectName.TabIndex = 0;
            this.lb_selectedProjectName.Text = "Project";
            this.lb_selectedProjectName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pn_moveWindow
            // 
            this.pn_moveWindow.BackColor = System.Drawing.Color.Transparent;
            this.pn_moveWindow.Location = new System.Drawing.Point(-1, -1);
            this.pn_moveWindow.Name = "pn_moveWindow";
            this.pn_moveWindow.Size = new System.Drawing.Size(916, 37);
            this.pn_moveWindow.TabIndex = 5;
            this.pn_moveWindow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pn_moveWindow_MouseDown);
            this.pn_moveWindow.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pn_moveWindow_MouseMove);
            this.pn_moveWindow.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pn_moveWindow_MouseUp);
            // 
            // mat_btn_createProject
            // 
            this.mat_btn_createProject.AutoSize = false;
            this.mat_btn_createProject.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mat_btn_createProject.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            this.mat_btn_createProject.Depth = 0;
            this.mat_btn_createProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mat_btn_createProject.HighEmphasis = true;
            this.mat_btn_createProject.Icon = null;
            this.mat_btn_createProject.Location = new System.Drawing.Point(7, 59);
            this.mat_btn_createProject.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mat_btn_createProject.MouseState = MaterialSkin.MouseState.HOVER;
            this.mat_btn_createProject.Name = "mat_btn_createProject";
            this.mat_btn_createProject.NoAccentTextColor = System.Drawing.Color.Empty;
            this.mat_btn_createProject.Size = new System.Drawing.Size(188, 47);
            this.mat_btn_createProject.TabIndex = 6;
            this.mat_btn_createProject.Text = "create project";
            this.mat_btn_createProject.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mat_btn_createProject.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mat_btn_createProject.UseAccentColor = false;
            this.mat_btn_createProject.UseVisualStyleBackColor = true;
            this.mat_btn_createProject.Click += new System.EventHandler(this.mat_btn_createProject_Click);
            // 
            // mat_btn_loadOtherProject
            // 
            this.mat_btn_loadOtherProject.AutoSize = false;
            this.mat_btn_loadOtherProject.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mat_btn_loadOtherProject.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            this.mat_btn_loadOtherProject.Depth = 0;
            this.mat_btn_loadOtherProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mat_btn_loadOtherProject.HighEmphasis = true;
            this.mat_btn_loadOtherProject.Icon = null;
            this.mat_btn_loadOtherProject.Location = new System.Drawing.Point(203, 59);
            this.mat_btn_loadOtherProject.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mat_btn_loadOtherProject.MouseState = MaterialSkin.MouseState.HOVER;
            this.mat_btn_loadOtherProject.Name = "mat_btn_loadOtherProject";
            this.mat_btn_loadOtherProject.NoAccentTextColor = System.Drawing.Color.Empty;
            this.mat_btn_loadOtherProject.Size = new System.Drawing.Size(198, 47);
            this.mat_btn_loadOtherProject.TabIndex = 7;
            this.mat_btn_loadOtherProject.Text = "load other project";
            this.mat_btn_loadOtherProject.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mat_btn_loadOtherProject.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mat_btn_loadOtherProject.UseAccentColor = false;
            this.mat_btn_loadOtherProject.UseVisualStyleBackColor = true;
            this.mat_btn_loadOtherProject.Click += new System.EventHandler(this.mat_btn_loadOtherProject_Click);
            // 
            // lbx_selectProject
            // 
            this.lbx_selectProject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.lbx_selectProject.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbx_selectProject.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lbx_selectProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbx_selectProject.ForeColor = System.Drawing.Color.White;
            this.lbx_selectProject.FormattingEnabled = true;
            this.lbx_selectProject.ItemHeight = 20;
            this.lbx_selectProject.Location = new System.Drawing.Point(7, 119);
            this.lbx_selectProject.Name = "lbx_selectProject";
            this.lbx_selectProject.Size = new System.Drawing.Size(394, 320);
            this.lbx_selectProject.TabIndex = 8;
            this.lbx_selectProject.SelectedIndexChanged += new System.EventHandler(this.lbx_selectProject_SelectedIndexChanged);
            // 
            // pn_main
            // 
            this.pn_main.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pn_main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_main.Controls.Add(this.lbx_selectProject);
            this.pn_main.Controls.Add(this.mat_btn_loadOtherProject);
            this.pn_main.Controls.Add(this.mat_btn_createProject);
            this.pn_main.Controls.Add(this.pn_moveWindow);
            this.pn_main.Controls.Add(this.pn_selectedProject);
            this.pn_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_main.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pn_main.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.pn_main.Location = new System.Drawing.Point(3, 0);
            this.pn_main.Name = "pn_main";
            this.pn_main.Size = new System.Drawing.Size(916, 459);
            this.pn_main.TabIndex = 0;
            // 
            // Window_init
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(922, 462);
            this.ControlBox = false;
            this.Controls.Add(this.pn_main);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Window_init";
            this.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.pn_selectedProject.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.img_selectedProject)).EndInit();
            this.pn_main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_selectedProject;
        private System.Windows.Forms.Label lb_lastTimeOpen;
        private MaterialSkin.Controls.MaterialButton mat_btn_run;
        private System.Windows.Forms.PictureBox img_selectedProject;
        private System.Windows.Forms.Label lb_selectedProjectName;
        private System.Windows.Forms.Panel pn_moveWindow;
        private MaterialSkin.Controls.MaterialButton mat_btn_createProject;
        private MaterialSkin.Controls.MaterialButton mat_btn_loadOtherProject;
        private MyForms.FormsOverride.MyListBox lbx_selectProject;
        private System.Windows.Forms.Panel pn_main;
    }
}

