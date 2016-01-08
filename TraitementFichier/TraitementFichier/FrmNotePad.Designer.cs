namespace TraitementFichier
{
    partial class FrmNotePad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNotePad));
            this.TbxText = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TSMIFichier = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIOuvrir = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.TSMISauvegarder = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMISauvegarderSous = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.TSMIQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIPolice = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIApparence = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.TSMIPremierPlan = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.TSSLNombresLignes = new System.Windows.Forms.ToolStripStatusLabel();
            this.TSSLStatusPp = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TbxText
            // 
            this.TbxText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbxText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbxText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxText.Location = new System.Drawing.Point(13, 32);
            this.TbxText.Margin = new System.Windows.Forms.Padding(4);
            this.TbxText.Multiline = true;
            this.TbxText.Name = "TbxText";
            this.TbxText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TbxText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TbxText.Size = new System.Drawing.Size(813, 457);
            this.TbxText.TabIndex = 0;
            this.TbxText.TextChanged += new System.EventHandler(this.TbxText_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMIFichier,
            this.TSMOptions,
            this.toolStripMenuItem4});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(826, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TSMIFichier
            // 
            this.TSMIFichier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMIOuvrir,
            this.toolStripMenuItem2,
            this.TSMISauvegarder,
            this.TSMISauvegarderSous,
            this.toolStripMenuItem1,
            this.TSMIQuitter});
            this.TSMIFichier.Name = "TSMIFichier";
            this.TSMIFichier.Size = new System.Drawing.Size(64, 24);
            this.TSMIFichier.Text = "&Fichier";
            // 
            // TSMIOuvrir
            // 
            this.TSMIOuvrir.Image = global::TraitementFichier.Properties.Resources.page;
            this.TSMIOuvrir.Name = "TSMIOuvrir";
            this.TSMIOuvrir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.TSMIOuvrir.Size = new System.Drawing.Size(286, 26);
            this.TSMIOuvrir.Text = "&Ouvrir ...";
            this.TSMIOuvrir.Click += new System.EventHandler(this.ouvrirToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(283, 6);
            // 
            // TSMISauvegarder
            // 
            this.TSMISauvegarder.Image = global::TraitementFichier.Properties.Resources.page_save;
            this.TSMISauvegarder.Name = "TSMISauvegarder";
            this.TSMISauvegarder.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.TSMISauvegarder.Size = new System.Drawing.Size(286, 26);
            this.TSMISauvegarder.Text = "&Enregistrer";
            this.TSMISauvegarder.Click += new System.EventHandler(this.sauvegarderToolStripMenuItem_Click);
            // 
            // TSMISauvegarderSous
            // 
            this.TSMISauvegarderSous.Image = global::TraitementFichier.Properties.Resources.save_as;
            this.TSMISauvegarderSous.Name = "TSMISauvegarderSous";
            this.TSMISauvegarderSous.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.TSMISauvegarderSous.Size = new System.Drawing.Size(286, 26);
            this.TSMISauvegarderSous.Text = "Enregistrer sous ...";
            this.TSMISauvegarderSous.Click += new System.EventHandler(this.sauvegarderSousToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(283, 6);
            // 
            // TSMIQuitter
            // 
            this.TSMIQuitter.Image = ((System.Drawing.Image)(resources.GetObject("TSMIQuitter.Image")));
            this.TSMIQuitter.Name = "TSMIQuitter";
            this.TSMIQuitter.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.TSMIQuitter.Size = new System.Drawing.Size(286, 26);
            this.TSMIQuitter.Text = "&Quitter";
            this.TSMIQuitter.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // TSMOptions
            // 
            this.TSMOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMIPolice,
            this.TSMIApparence,
            this.toolStripMenuItem3,
            this.TSMIPremierPlan});
            this.TSMOptions.Name = "TSMOptions";
            this.TSMOptions.Size = new System.Drawing.Size(73, 24);
            this.TSMOptions.Text = "O&ptions";
            // 
            // TSMIPolice
            // 
            this.TSMIPolice.Image = global::TraitementFichier.Properties.Resources.font;
            this.TSMIPolice.Name = "TSMIPolice";
            this.TSMIPolice.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.TSMIPolice.Size = new System.Drawing.Size(218, 26);
            this.TSMIPolice.Text = "&Police";
            this.TSMIPolice.Click += new System.EventHandler(this.policeToolStripMenuItem_Click);
            // 
            // TSMIApparence
            // 
            this.TSMIApparence.Image = global::TraitementFichier.Properties.Resources.application_edit;
            this.TSMIApparence.Name = "TSMIApparence";
            this.TSMIApparence.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.TSMIApparence.Size = new System.Drawing.Size(218, 26);
            this.TSMIApparence.Text = "&Apparence";
            this.TSMIApparence.Click += new System.EventHandler(this.apparenceToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(215, 6);
            // 
            // TSMIPremierPlan
            // 
            this.TSMIPremierPlan.CheckOnClick = true;
            this.TSMIPremierPlan.Image = global::TraitementFichier.Properties.Resources.application_double;
            this.TSMIPremierPlan.Name = "TSMIPremierPlan";
            this.TSMIPremierPlan.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.TSMIPremierPlan.Size = new System.Drawing.Size(218, 26);
            this.TSMIPremierPlan.Text = "P&remier plan";
            this.TSMIPremierPlan.Click += new System.EventHandler(this.premierPlanToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(28, 24);
            this.toolStripMenuItem4.Text = "?";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSSLNombresLignes,
            this.TSSLStatusPp});
            this.statusStrip1.Location = new System.Drawing.Point(0, 490);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(826, 25);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // TSSLNombresLignes
            // 
            this.TSSLNombresLignes.BackColor = System.Drawing.SystemColors.MenuBar;
            this.TSSLNombresLignes.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.TSSLNombresLignes.Name = "TSSLNombresLignes";
            this.TSSLNombresLignes.Size = new System.Drawing.Size(70, 20);
            this.TSSLNombresLignes.Text = "Lignes : 0";
            this.TSSLNombresLignes.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // TSSLStatusPp
            // 
            this.TSSLStatusPp.BackColor = System.Drawing.SystemColors.MenuBar;
            this.TSSLStatusPp.Name = "TSSLStatusPp";
            this.TSSLStatusPp.Size = new System.Drawing.Size(135, 20);
            this.TSSLStatusPp.Text = "Premier plan : false";
            // 
            // FrmNotePad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(826, 515);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.TbxText);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmNotePad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arcnose - NotePad";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbxText;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TSMIFichier;
        private System.Windows.Forms.ToolStripMenuItem TSMIOuvrir;
        private System.Windows.Forms.ToolStripMenuItem TSMISauvegarderSous;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel TSSLNombresLignes;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem TSMIQuitter;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem TSMISauvegarder;
        private System.Windows.Forms.ToolStripMenuItem TSMOptions;
        private System.Windows.Forms.ToolStripMenuItem TSMIPolice;
        private System.Windows.Forms.ToolStripMenuItem TSMIApparence;
        private System.Windows.Forms.ToolStripStatusLabel TSSLStatusPp;
        private System.Windows.Forms.ToolStripMenuItem TSMIPremierPlan;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
    }
}

