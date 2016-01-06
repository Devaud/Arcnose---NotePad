using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace TraitementFichier
{
    public partial class FrmMonBlocNotes : Form
    {
        #region Champs
        private SaveFileDialog saveDlg;
        private OpenFileDialog openDlg;
        private FontDialog fontDialog;
        private ColorDialog colorDlg;
        private string fileName;
        private bool foreground;
        #endregion

        #region Propriétés
        public bool Foreground
        {
            get { return foreground; }
            set { this.ChangeStateForeground(value); }
        }
        #endregion

        #region Constantes
        private const string FILTER_EXT = "Text files (*.txt)|*.txt|C# files (*.cs)|*.cs|All files (*.*)|*.*";
        #endregion

        public FrmMonBlocNotes()
        {
            InitializeComponent();
            this.fileName = null;
            this.Foreground = false;
            this.InitDialog();
        }

        private void InitDialog()
        {
            this.saveDlg = new SaveFileDialog();
            this.saveDlg.Title = "Enregistrer sous ...";
            this.saveDlg.DefaultExt = "txt";
            this.saveDlg.Filter = FILTER_EXT;
            this.saveDlg.OverwritePrompt = true;

            this.openDlg = new OpenFileDialog();
            this.openDlg.Title = "Ovrir le fichier ...";
            this.openDlg.Filter = FILTER_EXT;

            this.fontDialog = new FontDialog();
            this.fontDialog.ShowColor = true;

            this.colorDlg = new ColorDialog();
            this.colorDlg.AllowFullOpen = true;
        }

        private void AfficherText()
        {
            TbxText.Clear();
            TbxText.Text = File.ReadAllText(this.fileName);
        }

        private void SaveFile()
        {
            StreamWriter sw = new StreamWriter(this.fileName, false, Encoding.Unicode);

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
                this.AfficherText();
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

        private void TSMIPremierPlan_Click(object sender, EventArgs e)
        {
            this.Foreground = !this.Foreground;
        }

        /// <summary>
        /// Change le statut du premier plan.
        /// </summary>
        /// <param name="val">Indique si le premier plan doit être activé ou désactivé</param>
        private void ChangeStateForeground(bool val)
        {
            TSSLStatusPp.Text = (val) ? "Premier plan : activé" : "Premier plan : désactivé";
            this.TopMost = val;
            this.foreground = val;
        }
    }
}
