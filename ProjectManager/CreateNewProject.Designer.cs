namespace GE_1.ProjectManager
{
    partial class Window_createNewProject
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pn_moveWindow = new System.Windows.Forms.Panel();
            this.lb_projectName = new System.Windows.Forms.Label();
            this.lb_projectLocation = new System.Windows.Forms.Label();
            this.pn_content = new System.Windows.Forms.Panel();
            this.mat_btn_createProject = new MaterialSkin.Controls.MaterialButton();
            this.btn_folderBrowser = new System.Windows.Forms.Button();
            this.txt_projectLocation = new System.Windows.Forms.TextBox();
            this.txt_projectName = new System.Windows.Forms.TextBox();
            this.pn_main = new System.Windows.Forms.Panel();
            this.pn_content.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_moveWindow
            // 
            this.pn_moveWindow.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pn_moveWindow.BackColor = System.Drawing.Color.Transparent;
            this.pn_moveWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pn_moveWindow.Location = new System.Drawing.Point(4, 3);
            this.pn_moveWindow.Margin = new System.Windows.Forms.Padding(0);
            this.pn_moveWindow.Name = "pn_moveWindow";
            this.pn_moveWindow.Size = new System.Drawing.Size(652, 39);
            this.pn_moveWindow.TabIndex = 6;
            this.pn_moveWindow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pn_moveWindow_MouseDown);
            this.pn_moveWindow.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pn_moveWindow_MouseMove);
            this.pn_moveWindow.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pn_moveWindow_MouseUp);
            // 
            // lb_projectName
            // 
            this.lb_projectName.AutoSize = true;
            this.lb_projectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_projectName.Location = new System.Drawing.Point(51, 38);
            this.lb_projectName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lb_projectName.Name = "lb_projectName";
            this.lb_projectName.Size = new System.Drawing.Size(116, 20);
            this.lb_projectName.TabIndex = 7;
            this.lb_projectName.Text = "Project Name";
            this.lb_projectName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_projectLocation
            // 
            this.lb_projectLocation.AutoSize = true;
            this.lb_projectLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_projectLocation.Location = new System.Drawing.Point(23, 108);
            this.lb_projectLocation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lb_projectLocation.Name = "lb_projectLocation";
            this.lb_projectLocation.Size = new System.Drawing.Size(139, 20);
            this.lb_projectLocation.TabIndex = 8;
            this.lb_projectLocation.Text = "Project Location";
            this.lb_projectLocation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pn_content
            // 
            this.pn_content.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pn_content.Controls.Add(this.mat_btn_createProject);
            this.pn_content.Controls.Add(this.btn_folderBrowser);
            this.pn_content.Controls.Add(this.txt_projectLocation);
            this.pn_content.Controls.Add(this.txt_projectName);
            this.pn_content.Controls.Add(this.lb_projectName);
            this.pn_content.Controls.Add(this.lb_projectLocation);
            this.pn_content.Location = new System.Drawing.Point(10, 53);
            this.pn_content.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pn_content.Name = "pn_content";
            this.pn_content.Size = new System.Drawing.Size(640, 222);
            this.pn_content.TabIndex = 9;
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
            this.mat_btn_createProject.Location = new System.Drawing.Point(498, 181);
            this.mat_btn_createProject.Margin = new System.Windows.Forms.Padding(4, 6, 12, 12);
            this.mat_btn_createProject.MouseState = MaterialSkin.MouseState.HOVER;
            this.mat_btn_createProject.Name = "mat_btn_createProject";
            this.mat_btn_createProject.NoAccentTextColor = System.Drawing.Color.Empty;
            this.mat_btn_createProject.Size = new System.Drawing.Size(136, 32);
            this.mat_btn_createProject.TabIndex = 12;
            this.mat_btn_createProject.Text = "Run";
            this.mat_btn_createProject.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mat_btn_createProject.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.mat_btn_createProject.UseAccentColor = false;
            this.mat_btn_createProject.UseVisualStyleBackColor = true;
            // 
            // btn_folderBrowser
            // 
            this.btn_folderBrowser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(123)))), ((int)(((byte)(123)))));
            this.btn_folderBrowser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_folderBrowser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_folderBrowser.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btn_folderBrowser.FlatAppearance.BorderSize = 0;
            this.btn_folderBrowser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_folderBrowser.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_folderBrowser.Location = new System.Drawing.Point(544, 106);
            this.btn_folderBrowser.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.btn_folderBrowser.Name = "btn_folderBrowser";
            this.btn_folderBrowser.Size = new System.Drawing.Size(36, 26);
            this.btn_folderBrowser.TabIndex = 11;
            this.btn_folderBrowser.Text = "...";
            this.btn_folderBrowser.UseVisualStyleBackColor = false;
            this.btn_folderBrowser.Click += new System.EventHandler(this.btn_folderBrowser_Click);
            // 
            // txt_projectLocation
            // 
            this.txt_projectLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.txt_projectLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_projectLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_projectLocation.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_projectLocation.Location = new System.Drawing.Point(174, 106);
            this.txt_projectLocation.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.txt_projectLocation.Name = "txt_projectLocation";
            this.txt_projectLocation.Size = new System.Drawing.Size(370, 26);
            this.txt_projectLocation.TabIndex = 10;
            // 
            // txt_projectName
            // 
            this.txt_projectName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.txt_projectName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_projectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_projectName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_projectName.Location = new System.Drawing.Point(174, 36);
            this.txt_projectName.Name = "txt_projectName";
            this.txt_projectName.Size = new System.Drawing.Size(406, 26);
            this.txt_projectName.TabIndex = 9;
            // 
            // pn_main
            // 
            this.pn_main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_main.Location = new System.Drawing.Point(3, 0);
            this.pn_main.Margin = new System.Windows.Forms.Padding(4);
            this.pn_main.Name = "pn_main";
            this.pn_main.Size = new System.Drawing.Size(654, 279);
            this.pn_main.TabIndex = 10;
            // 
            // Window_createNewProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(660, 286);
            this.Controls.Add(this.pn_moveWindow);
            this.Controls.Add(this.pn_content);
            this.Controls.Add(this.pn_main);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Window_createNewProject";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create a new Project";
            this.pn_content.ResumeLayout(false);
            this.pn_content.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_moveWindow;
        private System.Windows.Forms.Label lb_projectName;
        private System.Windows.Forms.Label lb_projectLocation;
        private System.Windows.Forms.Panel pn_content;
        private System.Windows.Forms.TextBox txt_projectName;
        private System.Windows.Forms.TextBox txt_projectLocation;
        private System.Windows.Forms.Button btn_folderBrowser;
        private MaterialSkin.Controls.MaterialButton mat_btn_createProject;
        private System.Windows.Forms.Panel pn_main;
    }
}