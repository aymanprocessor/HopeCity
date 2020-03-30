using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace HopeCity
{
    public class language
    {
        public void updateConfig(string key, string value)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
            foreach (XmlElement element in xml.DocumentElement)
            {
                if (element.Name.Equals("appSettings"))
                {
                    foreach (XmlNode node in element.ChildNodes)
                    {
                        if (node.Attributes[0].Value.Equals(key))
                        {
                            node.Attributes[1].Value = value;
                        }
                    }
                }
            }

            ConfigurationManager.RefreshSection("appSettings");
            xml.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
        }

        public string getFirstTime()
        {
            string first = "";
            XmlDocument xml = new XmlDocument();
            xml.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
            foreach (XmlElement element in xml.DocumentElement)
            {
                if (element.Name.Equals("appSettings"))
                {
                    foreach (XmlNode node in element.ChildNodes)
                    {
                        if (node.Attributes[0].Equals("firstTime"))
                        {
                            first = node.Attributes[1].Value;
                        }
                    }
                }
            }
            return first;
        }
    }
}