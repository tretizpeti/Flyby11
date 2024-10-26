namespace Views
{
    partial class MediaView
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

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBack = new System.Windows.Forms.Button();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.comboBoxDrives = new System.Windows.Forms.ComboBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnMCT = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lblStatus = new System.Windows.Forms.Label();
            this.checkCreateUnattend = new System.Windows.Forms.CheckBox();
            this.comboBoxDriveLetters = new System.Windows.Forms.ComboBox();
            this.linkShowDiskList = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.AutoSize = true;
            this.btnBack.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.DarkGray;
            this.btnBack.Location = new System.Drawing.Point(3, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(34, 29);
            this.btnBack.TabIndex = 231;
            this.btnBack.Text = "...";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // rtbLog
            // 
            this.rtbLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.rtbLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbLog.Font = new System.Drawing.Font("Segoe UI Variable Small Light", 9.75F);
            this.rtbLog.Location = new System.Drawing.Point(59, 362);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.Size = new System.Drawing.Size(835, 148);
            this.rtbLog.TabIndex = 234;
            this.rtbLog.Text = "Ready";
            // 
            // comboBoxDrives
            // 
            this.comboBoxDrives.Font = new System.Drawing.Font("Segoe UI Variable Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDrives.FormattingEnabled = true;
            this.comboBoxDrives.Location = new System.Drawing.Point(59, 98);
            this.comboBoxDrives.Name = "comboBoxDrives";
            this.comboBoxDrives.Size = new System.Drawing.Size(121, 25);
            this.comboBoxDrives.TabIndex = 235;
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.BackColor = System.Drawing.Color.White;
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(192)))));
            this.btnStart.FlatAppearance.BorderSize = 2;
            this.btnStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(192)))));
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Segoe UI Variable Small", 10F);
            this.btnStart.Location = new System.Drawing.Point(671, 562);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(205, 40);
            this.btnStart.TabIndex = 236;
            this.btnStart.TabStop = false;
            this.btnStart.Text = "Start";
            this.btnStart.UseCompatibleTextRendering = true;
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Small", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(55, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 32);
            this.label1.TabIndex = 237;
            this.label1.Tag = "";
            this.label1.Text = "Drive Properties";
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Variable Small", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 238;
            this.label2.Tag = "";
            this.label2.Text = "Device ID";
            // 
            // label5
            // 
            this.label5.AutoEllipsis = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Variable Small", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(55, 328);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 31);
            this.label5.TabIndex = 241;
            this.label5.Tag = "";
            this.label5.Text = "Status";
            // 
            // btnSelect
            // 
            this.btnSelect.AutoEllipsis = true;
            this.btnSelect.BackColor = System.Drawing.Color.White;
            this.btnSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelect.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnSelect.FlatAppearance.BorderSize = 2;
            this.btnSelect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(192)))));
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.Font = new System.Drawing.Font("Segoe UI Variable Small", 9F);
            this.btnSelect.Location = new System.Drawing.Point(59, 241);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(132, 28);
            this.btnSelect.TabIndex = 242;
            this.btnSelect.TabStop = false;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseCompatibleTextRendering = true;
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Variable Small", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(57, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 15);
            this.label6.TabIndex = 243;
            this.label6.Tag = "";
            this.label6.Text = "Select ISO file";
            // 
            // btnMCT
            // 
            this.btnMCT.AutoEllipsis = true;
            this.btnMCT.BackColor = System.Drawing.Color.White;
            this.btnMCT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMCT.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(65)))), ((int)(((byte)(17)))));
            this.btnMCT.FlatAppearance.BorderSize = 2;
            this.btnMCT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(192)))));
            this.btnMCT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMCT.Font = new System.Drawing.Font("Segoe UI Variable Small", 9F);
            this.btnMCT.Location = new System.Drawing.Point(235, 241);
            this.btnMCT.Name = "btnMCT";
            this.btnMCT.Size = new System.Drawing.Size(205, 28);
            this.btnMCT.TabIndex = 244;
            this.btnMCT.TabStop = false;
            this.btnMCT.Text = "Media Creation Tool (Microsoft)";
            this.btnMCT.UseCompatibleTextRendering = true;
            this.btnMCT.UseVisualStyleBackColor = false;
            this.btnMCT.Click += new System.EventHandler(this.btnMCT_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Variable Small", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(232, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 15);
            this.label7.TabIndex = 245;
            this.label7.Tag = "";
            this.label7.Text = "or prepare with";
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(60, 516);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(834, 23);
            this.progressBar.TabIndex = 246;
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblStatus.AutoEllipsis = true;
            this.lblStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(361, 519);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(226, 18);
            this.lblStatus.TabIndex = 247;
            this.lblStatus.Tag = "";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkCreateUnattend
            // 
            this.checkCreateUnattend.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkCreateUnattend.AutoEllipsis = true;
            this.checkCreateUnattend.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.checkCreateUnattend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkCreateUnattend.Font = new System.Drawing.Font("Segoe UI Variable Small", 8F);
            this.checkCreateUnattend.Location = new System.Drawing.Point(72, 275);
            this.checkCreateUnattend.Name = "checkCreateUnattend";
            this.checkCreateUnattend.Size = new System.Drawing.Size(194, 25);
            this.checkCreateUnattend.TabIndex = 250;
            this.checkCreateUnattend.Text = "Skip Hardware limits and go local";
            this.checkCreateUnattend.UseVisualStyleBackColor = true;
            this.checkCreateUnattend.Visible = false;
            this.checkCreateUnattend.CheckedChanged += new System.EventHandler(this.checkCreateUnattend_CheckedChanged);
            // 
            // comboBoxDriveLetters
            // 
            this.comboBoxDriveLetters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDriveLetters.Font = new System.Drawing.Font("Segoe UI Variable Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDriveLetters.FormattingEnabled = true;
            this.comboBoxDriveLetters.Location = new System.Drawing.Point(210, 98);
            this.comboBoxDriveLetters.Name = "comboBoxDriveLetters";
            this.comboBoxDriveLetters.Size = new System.Drawing.Size(121, 25);
            this.comboBoxDriveLetters.TabIndex = 251;
            // 
            // linkShowDiskList
            // 
            this.linkShowDiskList.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(192)))));
            this.linkShowDiskList.Location = new System.Drawing.Point(60, 126);
            this.linkShowDiskList.Name = "linkShowDiskList";
            this.linkShowDiskList.Size = new System.Drawing.Size(177, 16);
            this.linkShowDiskList.TabIndex = 252;
            this.linkShowDiskList.TabStop = true;
            this.linkShowDiskList.Text = "Help me identify the device id";
            this.linkShowDiskList.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkShowDiskList_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoEllipsis = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Variable Small", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(55, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 32);
            this.label3.TabIndex = 253;
            this.label3.Tag = "";
            this.label3.Text = "Create Media";
            // 
            // label4
            // 
            this.label4.AutoEllipsis = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Variable Small", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(207, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 15);
            this.label4.TabIndex = 254;
            this.label4.Tag = "";
            this.label4.Text = "Device Letter";
            // 
            // InstallationMediaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.linkShowDiskList);
            this.Controls.Add(this.comboBoxDriveLetters);
            this.Controls.Add(this.checkCreateUnattend);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnMCT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.comboBoxDrives);
            this.Controls.Add(this.rtbLog);
            this.Controls.Add(this.btnBack);
            this.Name = "InstallationMediaView";
            this.Size = new System.Drawing.Size(959, 631);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.RichTextBox rtbLog;
        private System.Windows.Forms.ComboBox comboBoxDrives;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnMCT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.CheckBox checkCreateUnattend;
        private System.Windows.Forms.ComboBox comboBoxDriveLetters;
        private System.Windows.Forms.LinkLabel linkShowDiskList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
