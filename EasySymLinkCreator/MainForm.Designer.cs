namespace EasySymLinkCreator
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
            this.LinkPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TargetPath = new System.Windows.Forms.TextBox();
            this.SelectLinkPath = new System.Windows.Forms.Button();
            this.SelectTargetPath = new System.Windows.Forms.Button();
            this.IsDirectory = new System.Windows.Forms.CheckBox();
            this.IsHard = new System.Windows.Forms.CheckBox();
            this.CreateLink = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LinkPath
            // 
            this.LinkPath.Location = new System.Drawing.Point(12, 25);
            this.LinkPath.Name = "LinkPath";
            this.LinkPath.Size = new System.Drawing.Size(238, 20);
            this.LinkPath.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Link Path:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label2.Location = new System.Drawing.Point(9, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Target Path:";
            // 
            // TargetPath
            // 
            this.TargetPath.Location = new System.Drawing.Point(12, 64);
            this.TargetPath.Name = "TargetPath";
            this.TargetPath.Size = new System.Drawing.Size(238, 20);
            this.TargetPath.TabIndex = 4;
            // 
            // SelectLinkPath
            // 
            this.SelectLinkPath.Location = new System.Drawing.Point(248, 24);
            this.SelectLinkPath.Name = "SelectLinkPath";
            this.SelectLinkPath.Size = new System.Drawing.Size(22, 22);
            this.SelectLinkPath.TabIndex = 4;
            this.SelectLinkPath.Text = "...";
            this.SelectLinkPath.UseVisualStyleBackColor = true;
            this.SelectLinkPath.Click += new System.EventHandler(this.SelectPath_Click);
            // 
            // SelectTargetPath
            // 
            this.SelectTargetPath.Location = new System.Drawing.Point(248, 63);
            this.SelectTargetPath.Name = "SelectTargetPath";
            this.SelectTargetPath.Size = new System.Drawing.Size(22, 22);
            this.SelectTargetPath.TabIndex = 5;
            this.SelectTargetPath.Text = "...";
            this.SelectTargetPath.UseVisualStyleBackColor = true;
            this.SelectTargetPath.Click += new System.EventHandler(this.SelectPath_Click);
            // 
            // IsDirectory
            // 
            this.IsDirectory.AutoSize = true;
            this.IsDirectory.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.IsDirectory.Location = new System.Drawing.Point(12, 90);
            this.IsDirectory.Name = "IsDirectory";
            this.IsDirectory.Size = new System.Drawing.Size(72, 17);
            this.IsDirectory.TabIndex = 5;
            this.IsDirectory.Text = "Directory";
            this.IsDirectory.UseVisualStyleBackColor = true;
            // 
            // IsHard
            // 
            this.IsHard.AutoSize = true;
            this.IsHard.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.IsHard.Location = new System.Drawing.Point(90, 90);
            this.IsHard.Name = "IsHard";
            this.IsHard.Size = new System.Drawing.Size(156, 17);
            this.IsHard.TabIndex = 6;
            this.IsHard.Text = "Hard Link (Synced / Copy)";
            this.IsHard.UseVisualStyleBackColor = true;
            // 
            // CreateLink
            // 
            this.CreateLink.Location = new System.Drawing.Point(181, 113);
            this.CreateLink.Name = "CreateLink";
            this.CreateLink.Size = new System.Drawing.Size(89, 22);
            this.CreateLink.TabIndex = 7;
            this.CreateLink.Text = "Create";
            this.CreateLink.UseVisualStyleBackColor = true;
            this.CreateLink.Click += new System.EventHandler(this.CreateLink_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "About";
            this.label3.Click += new System.EventHandler(this.About_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 143);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CreateLink);
            this.Controls.Add(this.IsHard);
            this.Controls.Add(this.IsDirectory);
            this.Controls.Add(this.TargetPath);
            this.Controls.Add(this.SelectTargetPath);
            this.Controls.Add(this.LinkPath);
            this.Controls.Add(this.SelectLinkPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Easy SymLink Creator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LinkPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TargetPath;
        private System.Windows.Forms.Button SelectLinkPath;
        private System.Windows.Forms.Button SelectTargetPath;
        private System.Windows.Forms.CheckBox IsDirectory;
        private System.Windows.Forms.CheckBox IsHard;
        private System.Windows.Forms.Button CreateLink;
        private System.Windows.Forms.Label label3;
    }
}

