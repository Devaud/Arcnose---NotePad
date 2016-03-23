/*
 *  Author      : Squibbles
 *  Description : Manager of xml file
 *  Date        : 23.03.2016
 *  Version     : 1.0
 */
using System;
using System.Collections.Generic;
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
        public string readNode(string nodeName)
        {
            this.node = this.settingXML.DocumentElement.SelectSingleNode(nodeName);
            return this.node.InnerText;
        }
        #endregion
    }
}
