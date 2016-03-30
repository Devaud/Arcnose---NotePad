/*
 *  Author      : Squibbles
 *  Description : Manager of xml file
 *  Date        : 23.03.2016
 *  Version     : 1.0
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ArcNotepad
{
    class xmlManager
    {
        #region Properties
        XmlDocument settingXML;
        XmlNode node;
        #endregion

        #region Construcor
        public xmlManager(string path)
        {
            if (!File.Exists(path))
            {
                MessageBox.Show("Error");
            }
            this.settingXML = new XmlDocument();
            this.settingXML.Load(path);
            this.node = null;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Read a node in a XML file
        /// </summary>
        /// <param name="nodeName">Name of the node which need to read</param>
        /// <returns>The value in the node</returns>
        public string ReadNode(string nodeName)
        {
            this.node = this.settingXML.DocumentElement.SelectSingleNode(nodeName);
            return this.node.InnerText;
        }

        /// <summary>
        /// Get the RGB color in a XML file
        /// </summary>
        /// <param name="nodeName">Name of the node which contains the RGB color</param>
        /// <returns>An array which contains the RGB color. 0 : Red, 1 : Green, 2 : Blue</returns>
        public int[] GetNodeColor(string nodeName)
        {
            int[] colorRGB = new int[3];

            colorRGB[0] = Convert.ToInt16(this.ReadNode(nodeName + "/Red"));
            colorRGB[1] = Convert.ToInt16(this.ReadNode(nodeName + "/Green"));
            colorRGB[2] = Convert.ToInt16(this.ReadNode(nodeName + "/Blue"));

            return colorRGB;
        }

        /// <summary>
        /// Get the font in a XML file
        /// </summary>
        /// <param name="nodeName">Name of the node which contains the font properties</param>
        /// <returns>The font object</returns>
        public Font GetNodeFont(string nodeName)
        {
            Font f;

            FontFamily ff = new FontFamily(this.ReadNode(nodeName + "/font-family"));
            float size = (float)Convert.ToDouble(this.ReadNode(nodeName + "/size"));

            FontStyle fs = FontStyle.Regular;

            if (this.ReadNode(nodeName + "/fontstyle/bold") == "true")
                fs |= FontStyle.Bold;

            if (this.ReadNode(nodeName + "/fontstyle/underline") == "true")
                fs |= FontStyle.Underline;

            if (this.ReadNode(nodeName + "/fontstyle/italic") == "true")
                fs |= FontStyle.Italic;

            if (this.ReadNode(nodeName + "/fontstyle/strikeout") == "true")
                fs |= FontStyle.Strikeout;

            f = new Font(ff, size, fs);
            

            return f;
        }
        #endregion
    }
}
