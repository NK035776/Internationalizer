using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetSpell.SpellChecker;
using System.Xml;
using System.IO;

namespace Internalization
{
    class FormResourceConverter
    {
        public static void ConvertFormResx(string filePath, string targetLang, string destinationPath)
        {
            XmlDataDocument xmldoc = new XmlDataDocument();
            XmlNodeList xmlnode;
            int i = 0;
            string strEng = string.Empty;
            List<string> strConverted = new List<string>();
            FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.ReadWrite);
            xmldoc.Load(fs);
            xmlnode = xmldoc.GetElementsByTagName("data");
            XmlNodeList aNodes = xmldoc.SelectNodes("/root/data");
            for (i = 0; i < aNodes.Count; i++)
            {
                string attrVal = aNodes[i].Attributes["name"].Value;
                if (attrVal.EndsWith(".Text"))
                {
                    XmlNodeList aInnerNodes = aNodes[i].ChildNodes;
                    string sNew = aInnerNodes[1].InnerXml;
                    if (sNew.Contains("&amp;"))
                    {
                        sNew = sNew.Replace("&amp;", string.Empty);
                    }
                    if (!string.IsNullOrEmpty(sNew))
                    {
                        strConverted = Internalization.YandexTranslate.Translate(targetLang, sNew);
                        aInnerNodes[1].InnerXml = strConverted[0];
                    }

                }
            }
            fs.Close();
            if (destinationPath == string.Empty)
                xmldoc.Save(Path.GetDirectoryName(filePath) + "\\" + Path.GetFileNameWithoutExtension(filePath) + "_" + targetLang + Path.GetExtension(filePath));
            else
                xmldoc.Save(destinationPath + "_" + targetLang + Path.GetExtension(filePath));
        }
    }
}

