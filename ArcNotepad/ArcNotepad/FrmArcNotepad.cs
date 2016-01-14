/*
 *  Author      : Squibbles
 *  Description : Little notepad which can be put in the foreground
 *  Date        : 08.08.2016
 *  Version     : 1.1
 */

using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ArcNotepad
{
    public partial class FrmArcNotepad : Form
    {
        #region Fields
        private SaveFileDialog _saveDlg;
        private OpenFileDialog _openDlg;
        private FontDialog _fontDialog;
        private ColorDialog _colorDlg;
        private AboutBox _abx;
        private string _filename;
        private bool _foreground;
        #endregion

        #region Properties
        /// <summary>
        /// Get or set the save dialog
        /// </summary>
        public SaveFileDialog SaveDlg
        {
            get { return _saveDlg; }
            set { _saveDlg = value; }
        }

        /// <summary>
        /// Get or set the open dialog
        /// </summary>
        public OpenFileDialog OpenDlg
        {
            get { return _openDlg; }
            set { _openDlg = value; }
        }

        /// <summary>
        /// Get or set the font dialog
        /// </summary>
        public FontDialog FontDialog
        {
            get { return _fontDialog; }
            set { _fontDialog = value; }
        }

        /// <summary>
        /// Get or set the color dialog
        /// </summary>
        public ColorDialog ColorDlg
        {
            get { return _colorDlg; }
            set { _colorDlg = value; }
        }

        /// <summary>
        /// Get or set the filename
        /// </summary>
        public string Filename
        {
            get { return _filename; }
            set { _filename = value; }
        }

        /// <summary>
        /// Get or set the foreground
        /// </summary>
        public bool Foreground
        {
            get { return _foreground; }
            set { this.ChangeStateForeground(value); }
        }
        #endregion

        #region Const
        private const string FILTER_EXT = "Text files (*.txt)|*.txt|C# files (*.cs)|*.cs|All files (*.*)|*.*";
        #endregion

        #region Constructor
        public FrmArcNotepad()
        {
            InitializeComponent();
            this.Foreground = false;
            this.InitDialog();

            // Get the parameters which past during the command execute
            string[] args = Environment.GetCommandLineArgs();
            if (args.Length >= 2)
            {
                if (args[1] != "")
                {
                    this.Filename = args[1];
                    this.ShowText();
                    this.TBXText.Select(0, 0);
                }
                    
            }
        }
        #endregion

        #region Personnal Method
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

            // Initialize the about box
            this._abx = new AboutBox();
        }

        /// <summary>
        /// Show the text which from an externe file
        /// </summary>
        private void ShowText()
        {
            TBXText.Clear();
            TBXText.Text = File.ReadAllText(this.Filename);
        }

        /// <summary>
        /// Save all text in the file
        /// </summary>
        private void SaveFile()
        {
            StreamWriter sw = new StreamWriter(this.Filename, false, Encoding.Unicode);

            foreach (string line in TBXText.Lines)
                sw.WriteLine(line);

            sw.Close();
        }

        /// <summary>
        /// Change forground state
        /// </summary>
        /// <param name="val">True if the windows must be forgrounded. False if doesn't it</param>
        private void ChangeStateForeground(bool val)
        {
            TSSLStatuForeground.Text = (val) ? "Premier plan : activé" : "Premier plan : désactivé";
            this.TopMost = val;
            this._foreground = val;
        }
        #endregion

        private void TSMIOpen_Click(object sender, EventArgs e)
        {
            DialogResult res = this.OpenDlg.ShowDialog();

            if (res != DialogResult.Cancel)
            {
                this.Filename = this.OpenDlg.FileName;
                this.ShowText();
            }
        }

        private void TSMISaveAs_Click(object sender, EventArgs e)
        {
            DialogResult res = _saveDlg.ShowDialog();

            if (res != DialogResult.Cancel)
            {
                this.Filename = _saveDlg.FileName;
                this.SaveFile();
            }
        }

        private void TBXText_TextChanged(object sender, EventArgs e)
        {
            this.TSSLNumbresLines.Text = "Lignes : " + TBXText.Lines.Count<string>().ToString();
        }

        private void TSMISave_Click(object sender, EventArgs e)
        {
            if (this.Filename != "" && this.Filename != null)
            {
                this.SaveFile();
            }
            else
            {
                this.TSMISaveAs_Click(sender, e);
            }
        }

        private void TSMIQuit_Click(object sender, EventArgs e)
        {
            if (this.Filename != "" && this.Filename != null)
            {
                this.SaveFile();
            }

            Application.Exit();
        }

        private void TSMIFont_Click(object sender, EventArgs e)
        {
            this.FontDialog.Font = this.TBXText.Font;
            DialogResult res = this.FontDialog.ShowDialog();

            if (res != DialogResult.Cancel)
            {
                this.TBXText.Font = this.FontDialog.Font;
                this.TBXText.ForeColor = this.FontDialog.Color;
            }
        }

        private void TSMINew_Click(object sender, EventArgs e)
        {
            this.Filename = null;
            this.TBXText.Clear();
        }

        private void TSMIAbout_Click(object sender, EventArgs e)
        {
            AboutBox abx = new AboutBox();
            abx.ShowDialog();
        }

        private void TSMIForeground_Click(object sender, EventArgs e)
        {
            this.Foreground = !this.Foreground;
        }

        private void TSMIAppearance_Click(object sender, EventArgs e)
        {
            this.ColorDlg.Color = this.TBXText.BackColor;

            DialogResult res = this.ColorDlg.ShowDialog();

            if (res != DialogResult.Cancel)
            {
                this.TBXText.BackColor = this.ColorDlg.Color;
                this.BackColor = this.ColorDlg.Color;
            }
        }
    }
}
