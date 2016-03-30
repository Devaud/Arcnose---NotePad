namespace ArcNotepad
{
    partial class FrmArcNotepad
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmArcNotepad));
            this.TBXText = new System.Windows.Forms.TextBox();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.TSMIFile = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMINew = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.TSMISave = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMISaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.TSMIQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIFont = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIAppearance = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.TSMIForeground = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.SSInformations = new System.Windows.Forms.StatusStrip();
            this.TSSLNumbresLines = new System.Windows.Forms.ToolStripStatusLabel();
            this.TSSLStatuForeground = new System.Windows.Forms.ToolStripStatusLabel();
            this.Menu.SuspendLayout();
            this.SSInformations.SuspendLayout();
            this.SuspendLayout();
            // 
            // TBXText
            // 
            this.TBXText.AcceptsTab = true;
            this.TBXText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBXText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBXText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBXText.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TBXText.Location = new System.Drawing.Point(13, 32);
            this.TBXText.Margin = new System.Windows.Forms.Padding(4);
            this.TBXText.Multiline = true;
            this.TBXText.Name = "TBXText";
            this.TBXText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TBXText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TBXText.Size = new System.Drawing.Size(813, 457);
            this.TBXText.TabIndex = 0;
            this.TBXText.TextChanged += new System.EventHandler(this.TBXText_TextChanged);
            // 
            // Menu
            // 
            this.Menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMIFile,
            this.TSMSettings,
            this.TSMHelp});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.Menu.Size = new System.Drawing.Size(826, 28);
            this.Menu.TabIndex = 3;
            this.Menu.Text = "menuStrip1";
            // 
            // TSMIFile
            // 
            this.TSMIFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMINew,
            this.TSMIOpen,
            this.toolStripMenuItem2,
            this.TSMISave,
            this.TSMISaveAs,
            this.toolStripMenuItem1,
            this.TSMIQuit});
            this.TSMIFile.Name = "TSMIFile";
            this.TSMIFile.Size = new System.Drawing.Size(64, 24);
            this.TSMIFile.Text = "&Fichier";
            // 
            // TSMINew
            // 
            this.TSMINew.Image = global::ArcNotepad.Properties.Resources.document_empty;
            this.TSMINew.Name = "TSMINew";
            this.TSMINew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.TSMINew.Size = new System.Drawing.Size(286, 26);
            this.TSMINew.Text = "&Nouveau";
            this.TSMINew.Click += new System.EventHandler(this.TSMINew_Click);
            // 
            // TSMIOpen
            // 
            this.TSMIOpen.Image = global::ArcNotepad.Properties.Resources.page;
            this.TSMIOpen.Name = "TSMIOpen";
            this.TSMIOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.TSMIOpen.Size = new System.Drawing.Size(286, 26);
            this.TSMIOpen.Text = "&Ouvrir ...";
            this.TSMIOpen.Click += new System.EventHandler(this.TSMIOpen_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(283, 6);
            // 
            // TSMISave
            // 
            this.TSMISave.Image = global::ArcNotepad.Properties.Resources.page_save;
            this.TSMISave.Name = "TSMISave";
            this.TSMISave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.TSMISave.Size = new System.Drawing.Size(286, 26);
            this.TSMISave.Text = "&Enregistrer";
            this.TSMISave.Click += new System.EventHandler(this.TSMISave_Click);
            // 
            // TSMISaveAs
            // 
            this.TSMISaveAs.Image = global::ArcNotepad.Properties.Resources.save_as;
            this.TSMISaveAs.Name = "TSMISaveAs";
            this.TSMISaveAs.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.TSMISaveAs.Size = new System.Drawing.Size(286, 26);
            this.TSMISaveAs.Text = "Enregistrer sous ...";
            this.TSMISaveAs.Click += new System.EventHandler(this.TSMISaveAs_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(283, 6);
            // 
            // TSMIQuit
            // 
            this.TSMIQuit.Image = ((System.Drawing.Image)(resources.GetObject("TSMIQuit.Image")));
            this.TSMIQuit.Name = "TSMIQuit";
            this.TSMIQuit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.TSMIQuit.Size = new System.Drawing.Size(286, 26);
            this.TSMIQuit.Text = "&Quitter";
            this.TSMIQuit.Click += new System.EventHandler(this.TSMIQuit_Click);
            // 
            // TSMSettings
            // 
            this.TSMSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMIFont,
            this.TSMIAppearance,
            this.toolStripMenuItem3,
            this.TSMIForeground});
            this.TSMSettings.Name = "TSMSettings";
            this.TSMSettings.Size = new System.Drawing.Size(73, 24);
            this.TSMSettings.Text = "O&ptions";
            // 
            // TSMIFont
            // 
            this.TSMIFont.Image = global::ArcNotepad.Properties.Resources.font;
            this.TSMIFont.Name = "TSMIFont";
            this.TSMIFont.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.TSMIFont.Size = new System.Drawing.Size(221, 26);
            this.TSMIFont.Text = "&Police ...";
            this.TSMIFont.Click += new System.EventHandler(this.TSMIFont_Click);
            // 
            // TSMIAppearance
            // 
            this.TSMIAppearance.Image = global::ArcNotepad.Properties.Resources.application_edit;
            this.TSMIAppearance.Name = "TSMIAppearance";
            this.TSMIAppearance.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.TSMIAppearance.Size = new System.Drawing.Size(221, 26);
            this.TSMIAppearance.Text = "&Apparence ...";
            this.TSMIAppearance.Click += new System.EventHandler(this.TSMIAppearance_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(218, 6);
            // 
            // TSMIForeground
            // 
            this.TSMIForeground.CheckOnClick = true;
            this.TSMIForeground.Image = global::ArcNotepad.Properties.Resources.application_double;
            this.TSMIForeground.Name = "TSMIForeground";
            this.TSMIForeground.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.TSMIForeground.Size = new System.Drawing.Size(221, 26);
            this.TSMIForeground.Text = "P&remier plan";
            this.TSMIForeground.Click += new System.EventHandler(this.TSMIForeground_Click);
            // 
            // TSMHelp
            // 
            this.TSMHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMIAbout});
            this.TSMHelp.Name = "TSMHelp";
            this.TSMHelp.Size = new System.Drawing.Size(28, 24);
            this.TSMHelp.Text = "&?";
            // 
            // TSMIAbout
            // 
            this.TSMIAbout.Image = global::ArcNotepad.Properties.Resources.information;
            this.TSMIAbout.Name = "TSMIAbout";
            this.TSMIAbout.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.TSMIAbout.Size = new System.Drawing.Size(230, 26);
            this.TSMIAbout.Text = "A propos &de ...";
            this.TSMIAbout.Click += new System.EventHandler(this.TSMIAbout_Click);
            // 
            // SSInformations
            // 
            this.SSInformations.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.SSInformations.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSSLNumbresLines,
            this.TSSLStatuForeground});
            this.SSInformations.Location = new System.Drawing.Point(0, 490);
            this.SSInformations.Name = "SSInformations";
            this.SSInformations.Size = new System.Drawing.Size(826, 25);
            this.SSInformations.TabIndex = 4;
            this.SSInformations.Text = "statusStrip1";
            // 
            // TSSLNumbresLines
            // 
            this.TSSLNumbresLines.BackColor = System.Drawing.SystemColors.MenuBar;
            this.TSSLNumbresLines.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.TSSLNumbresLines.Name = "TSSLNumbresLines";
            this.TSSLNumbresLines.Size = new System.Drawing.Size(70, 20);
            this.TSSLNumbresLines.Text = "Lignes : 0";
            // 
            // TSSLStatuForeground
            // 
            this.TSSLStatuForeground.BackColor = System.Drawing.SystemColors.MenuBar;
            this.TSSLStatuForeground.Name = "TSSLStatuForeground";
            this.TSSLStatuForeground.Size = new System.Drawing.Size(135, 20);
            this.TSSLStatuForeground.Text = "Premier plan : false";
            // 
            // FrmArcNotepad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(826, 515);
            this.Controls.Add(this.SSInformations);
            this.Controls.Add(this.TBXText);
            this.Controls.Add(this.Menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.Menu;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmArcNotepad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ArcNotepad";
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.SSInformations.ResumeLayout(false);
            this.SSInformations.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBXText;
        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem TSMIFile;
        private System.Windows.Forms.ToolStripMenuItem TSMIOpen;
        private System.Windows.Forms.ToolStripMenuItem TSMISaveAs;
        private System.Windows.Forms.StatusStrip SSInformations;
        private System.Windows.Forms.ToolStripStatusLabel TSSLNumbresLines;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem TSMIQuit;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem TSMISave;
        private System.Windows.Forms.ToolStripMenuItem TSMSettings;
        private System.Windows.Forms.ToolStripMenuItem TSMIFont;
        private System.Windows.Forms.ToolStripMenuItem TSMIAppearance;
        private System.Windows.Forms.ToolStripStatusLabel TSSLStatuForeground;
        private System.Windows.Forms.ToolStripMenuItem TSMIForeground;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem TSMHelp;
        private System.Windows.Forms.ToolStripMenuItem TSMIAbout;
        private System.Windows.Forms.ToolStripMenuItem TSMINew;
    }
}

