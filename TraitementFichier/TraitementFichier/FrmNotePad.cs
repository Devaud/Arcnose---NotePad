/*
 *  Author      : Squibbles
 *  Description : Little notepad which can be put in the foreground
 *  Date        : 08.08.2016
 *  Version     : 1.0
 */

using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace TraitementFichier
{
    public partial class FrmNotePad : Form
    {
        #region Fields
        private SaveFileDialog saveDlg;
        private OpenFileDialog openDlg;
        private FontDialog fontDialog;
        private ColorDialog colorDlg;
        private string fileName;
        private bool foreground;
        #endregion

        #region Properties
        /// <summary>
        /// Get or set the save dialog
        /// </summary>
        public SaveFileDialog SaveDlg
        {
            get { return saveDlg; }
            set { saveDlg = value; }
        }

        /// <summary>
        /// Get or set the open dialog
        /// </summary>
        public OpenFileDialog OpenDlg
        {
            get { return openDlg; }
            set { openDlg = value; }
        }

        /// <summary>
        /// Get or set the font dialog
        /// </summary>
        public FontDialog FontDialog
        {
            get { return fontDialog; }
            set { fontDialog = value; }
        }

        /// <summary>
        /// Get or set the color dialog
        /// </summary>
        public ColorDialog ColorDlg
        {
            get { return colorDlg; }
            set { colorDlg = value; }
        }

        /// <summary>
        /// Get or set the filename
        /// </summary>
        public string FileName
        {
            get { return fileName; }
            set { fileName = value; }
        }

        /// <summary>
        /// Get or set the foreground
        /// </summary>
        public bool Foreground
        {
            get { return foreground; }
            set { this.ChangeStateForeground(value); }
        }
        #endregion

        #region Const
        private const string FILTER_EXT = "Text files (*.txt)|*.txt|C# files (*.cs)|*.cs|All files (*.*)|*.*";
        #endregion

        public FrmNotePad()
        {
            InitializeComponent();
            this.FileName = null;
            this.Foreground = false;
            this.InitDialog();
        }

        /// <summary>
        /// Initialise all dialog which are necessary
        /// </summary>
        private void InitDialog()
        {
            // Initialize the save dialog
            this.SaveDlg = new SaveFileDialog();
            this.SaveDlg.Title = "Enregistrer sous ...";
            this.SaveDlg.DefaultExt = "txt";
            this.SaveDlg.Filter = FILTER_EXT;
            this.SaveDlg.OverwritePrompt = true;

            // Initialize the open dialog
            this.OpenDlg = new OpenFileDialog();
            this.OpenDlg.Title = "Ovrir le fichier ...";
            this.OpenDlg.Filter = FILTER_EXT;

            // Initialize the font dialog
            this.FontDialog = new FontDialog();
            this.FontDialog.ShowColor = true;

            // Initialize the color dialog
            this.ColorDlg = new ColorDialog();
            this.ColorDlg.AllowFullOpen = true;
        }

        /// <summary>
        /// Show the text which from an externe file
        /// </summary>
        private void ShowText()
        {
            TbxText.Clear();
            TbxText.Text = File.ReadAllText(this.FileName);
        }

        /// <summary>
        /// Save all text in the file
        /// </summary>
        private void SaveFile()
        {
            StreamWriter sw = new StreamWriter(this.FileName, false, Encoding.Unicode);

            foreach (string line in TbxText.Lines)
                sw.WriteLine(line);

            sw.Close();
        }

        private void ouvrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res = this.openDlg.ShowDialog();

            if (res != DialogResult.Cancel)
            {
                this.fileName = openDlg.FileName;
                this.ShowText();
            }
        }

        private void sauvegarderSousToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res = saveDlg.ShowDialog();

            if (res != DialogResult.Cancel)
            {
                this.fileName = saveDlg.FileName;
                this.SaveFile();
            }
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void TbxText_TextChanged(object sender, EventArgs e)
        {
            this.TSSLNombresLignes.Text = "Lignes : " + TbxText.Lines.Count<string>().ToString();
        }

        private void sauvegarderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.fileName != "" && this.fileName != null)
            {
                this.SaveFile();
            }
            else
            {
                this.sauvegarderSousToolStripMenuItem_Click(sender, e);
            }
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.fileName != "" && this.fileName != null)
            {
                this.SaveFile();
            }

            Application.Exit();
        }

        private void policeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.fontDialog.Font = this.TbxText.Font;
            DialogResult res = this.fontDialog.ShowDialog();

            if (res != DialogResult.Cancel)
            {
                this.TbxText.Font = this.fontDialog.Font;
                this.TbxText.ForeColor = this.fontDialog.Color;
            }
        }

        private void apparenceToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.colorDlg.Color = this.TbxText.BackColor;

            DialogResult res = this.colorDlg.ShowDialog();

            if (res != DialogResult.Cancel)
            {
                this.TbxText.BackColor = this.colorDlg.Color;
                this.BackColor = this.colorDlg.Color;
            }
        }

        /// <summary>
        /// Change forground state
        /// </summary>
        /// <param name="val">True if the windows must be forgrounded. False if doesn't it</param>
        private void ChangeStateForeground(bool val)
        {
            TSSLStatusPp.Text = (val) ? "Premier plan : activé" : "Premier plan : désactivé";
            this.TopMost = val;
            this.Foreground = val;
        }

        private void premierPlanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Foreground = !this.Foreground;
        }
    }
}
