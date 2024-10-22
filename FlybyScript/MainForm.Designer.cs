namespace FlybyScript
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.treeSettings = new System.Windows.Forms.TreeView();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.btnTogglePatch = new System.Windows.Forms.Button();
            this.linkGitHub = new System.Windows.Forms.LinkLabel();
            this.btnMountRun = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.linkChangeExperience = new System.Windows.Forms.LinkLabel();
            this.panelForm = new System.Windows.Forms.Panel();
            this.panelMain.SuspendLayout();
            this.panelForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeSettings
            // 
            this.treeSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeSettings.BackColor = System.Drawing.Color.White;
            this.treeSettings.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeSettings.CheckBoxes = true;
            this.treeSettings.Font = new System.Drawing.Font("Segoe UI Variable Small Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeSettings.ForeColor = System.Drawing.Color.Black;
            this.treeSettings.FullRowSelect = true;
            this.treeSettings.Indent = 20;
            this.treeSettings.ItemHeight = 25;
            this.treeSettings.Location = new System.Drawing.Point(36, 168);
            this.treeSettings.Name = "treeSettings";
            this.treeSettings.ShowLines = false;
            this.treeSettings.ShowNodeToolTips = true;
            this.treeSettings.ShowPlusMinus = false;
            this.treeSettings.ShowRootLines = false;
            this.treeSettings.Size = new System.Drawing.Size(865, 172);
            this.treeSettings.TabIndex = 200;
            this.treeSettings.TabStop = false;
            this.treeSettings.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeSettings_AfterCheck);
            this.treeSettings.MouseMove += new System.Windows.Forms.MouseEventHandler(this.treeSettings_MouseMove);
            // 
            // rtbDescription
            // 
            this.rtbDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbDescription.BackColor = System.Drawing.Color.White;
            this.rtbDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbDescription.Font = new System.Drawing.Font("Segoe UI Variable Small Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbDescription.ForeColor = System.Drawing.Color.Black;
            this.rtbDescription.Location = new System.Drawing.Point(34, 346);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbDescription.Size = new System.Drawing.Size(867, 123);
            this.rtbDescription.TabIndex = 199;
            this.rtbDescription.TabStop = false;
            this.rtbDescription.Text = "";
            // 
            // btnTogglePatch
            // 
            this.btnTogglePatch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTogglePatch.BackColor = System.Drawing.Color.White;
            this.btnTogglePatch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTogglePatch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(192)))));
            this.btnTogglePatch.FlatAppearance.BorderSize = 2;
            this.btnTogglePatch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(192)))));
            this.btnTogglePatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTogglePatch.Font = new System.Drawing.Font("Segoe UI Variable Small", 11F);
            this.btnTogglePatch.Location = new System.Drawing.Point(629, 497);
            this.btnTogglePatch.Name = "btnTogglePatch";
            this.btnTogglePatch.Size = new System.Drawing.Size(222, 40);
            this.btnTogglePatch.TabIndex = 201;
            this.btnTogglePatch.TabStop = false;
            this.btnTogglePatch.Text = "Patch";
            this.btnTogglePatch.UseCompatibleTextRendering = true;
            this.btnTogglePatch.UseVisualStyleBackColor = false;
            this.btnTogglePatch.Click += new System.EventHandler(this.btnTogglePatch_Click);
            // 
            // linkGitHub
            // 
            this.linkGitHub.ActiveLinkColor = System.Drawing.Color.Magenta;
            this.linkGitHub.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkGitHub.AutoEllipsis = true;
            this.linkGitHub.Font = new System.Drawing.Font("Segoe UI Variable Small", 8.75F);
            this.linkGitHub.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkGitHub.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(65)))), ((int)(((byte)(17)))));
            this.linkGitHub.Location = new System.Drawing.Point(169, 567);
            this.linkGitHub.Name = "linkGitHub";
            this.linkGitHub.Size = new System.Drawing.Size(45, 16);
            this.linkGitHub.TabIndex = 202;
            this.linkGitHub.TabStop = true;
            this.linkGitHub.Text = "GitHub";
            this.linkGitHub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkGitHub_LinkClicked);
            // 
            // btnMountRun
            // 
            this.btnMountRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMountRun.AutoEllipsis = true;
            this.btnMountRun.BackColor = System.Drawing.Color.White;
            this.btnMountRun.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMountRun.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnMountRun.FlatAppearance.BorderSize = 2;
            this.btnMountRun.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(192)))));
            this.btnMountRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMountRun.Font = new System.Drawing.Font("Segoe UI Variable Small", 11F);
            this.btnMountRun.Location = new System.Drawing.Point(403, 497);
            this.btnMountRun.Name = "btnMountRun";
            this.btnMountRun.Size = new System.Drawing.Size(220, 40);
            this.btnMountRun.TabIndex = 203;
            this.btnMountRun.TabStop = false;
            this.btnMountRun.Text = "Mount and Run ISO";
            this.btnMountRun.UseVisualStyleBackColor = false;
            this.btnMountRun.Click += new System.EventHandler(this.btnMountRun_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoEllipsis = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Small Light", 21.25F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(30, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(780, 82);
            this.label1.TabIndex = 205;
            this.label1.Text = "Utilize FlybyScript to Bypass Windows 11 Hardware Restrictions and Install on Uns" +
    "upported Devices";
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.Magenta;
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkLabel1.AutoEllipsis = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI Variable Small", 8.75F);
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(164)))), ((int)(((byte)(239)))));
            this.linkLabel1.Location = new System.Drawing.Point(27, 567);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(122, 16);
            this.linkLabel1.TabIndex = 206;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "A Belim app creation";
            // 
            // linkLabel2
            // 
            this.linkLabel2.ActiveLinkColor = System.Drawing.Color.Magenta;
            this.linkLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkLabel2.AutoEllipsis = true;
            this.linkLabel2.Font = new System.Drawing.Font("Segoe UI Variable Small", 8.75F);
            this.linkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel2.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(186)))), ((int)(((byte)(0)))));
            this.linkLabel2.Location = new System.Drawing.Point(235, 567);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(54, 16);
            this.linkLabel2.TabIndex = 208;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "0.11.31";
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.linkLabel2);
            this.panelMain.Controls.Add(this.linkChangeExperience);
            this.panelMain.Controls.Add(this.label1);
            this.panelMain.Controls.Add(this.linkLabel1);
            this.panelMain.Controls.Add(this.rtbDescription);
            this.panelMain.Controls.Add(this.treeSettings);
            this.panelMain.Controls.Add(this.btnMountRun);
            this.panelMain.Controls.Add(this.btnTogglePatch);
            this.panelMain.Controls.Add(this.linkGitHub);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(943, 592);
            this.panelMain.TabIndex = 209;
            // 
            // linkChangeExperience
            // 
            this.linkChangeExperience.ActiveLinkColor = System.Drawing.Color.Fuchsia;
            this.linkChangeExperience.AutoSize = true;
            this.linkChangeExperience.Font = new System.Drawing.Font("Segoe UI Variable Small Semilig", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkChangeExperience.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkChangeExperience.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(192)))));
            this.linkChangeExperience.Location = new System.Drawing.Point(33, 139);
            this.linkChangeExperience.Name = "linkChangeExperience";
            this.linkChangeExperience.Size = new System.Drawing.Size(209, 16);
            this.linkChangeExperience.TabIndex = 10;
            this.linkChangeExperience.TabStop = true;
            this.linkChangeExperience.Text = "Change how you experience Windows";
            this.linkChangeExperience.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkChangeExperience_LinkClicked);
            // 
            // panelForm
            // 
            this.panelForm.Controls.Add(this.panelMain);
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForm.Location = new System.Drawing.Point(0, 0);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(943, 592);
            this.panelForm.TabIndex = 210;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(943, 592);
            this.Controls.Add(this.panelForm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Flyby11";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panelForm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeSettings;
        public System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.Button btnTogglePatch;
        private System.Windows.Forms.LinkLabel linkGitHub;
        private System.Windows.Forms.Button btnMountRun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.LinkLabel linkChangeExperience;
        private System.Windows.Forms.Panel panelForm;
    }
}

