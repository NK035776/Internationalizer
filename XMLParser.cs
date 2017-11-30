using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using System.Text.RegularExpressions;

namespace Internalization
{
    class XMLParse
    {
        public string status = string.Empty;
        public static void GetStringValueFromResource(string filePath, string targetLang, string destinationPath)
        {
            List<String> resxValue = new List<string>();
            XmlDataDocument xmldoc = new XmlDataDocument();
            XmlNodeList xmlnode;
            int i = 0;
            string strEng = string.Empty;
            List<string> strConverted = new List<string>();
            FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.ReadWrite);
            xmldoc.Load(fs);
            xmlnode = xmldoc.GetElementsByTagName("value");
            XmlNodeList aNodes = xmldoc.SelectNodes("/root/data/value");
            foreach (XmlNode aNode in aNodes)
            {
                if (aNode.InnerText != null)
                {
                    string currentValue = aNode.InnerText;
                    if (currentValue.Contains("&"))
                    {
                        currentValue = currentValue.Replace("&", String.Empty);
                    }
                    if (!string.IsNullOrEmpty(currentValue))
                    {
                        strConverted = Internalization.YandexTranslate.Translate(targetLang, currentValue);
                        aNode.InnerText = strConverted[0];
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
