using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace FBLogic
{
    public class AppSetting
    {
        public bool RememberMe { get; set; } = false;

        public string AccesToken { get; set; } = string.Empty;

        private AppSetting()
        {
        }

        public static AppSetting LoadFromFile()
        {
            AppSetting appSetting = null;

            try
            {
                string relativePath = @".\AppSetting.xml";
                using (Stream stream = new FileStream(relativePath, FileMode.Open))
                {
                    XmlSerializer xmlSerlize = new XmlSerializer(typeof(AppSetting));
                    appSetting = xmlSerlize.Deserialize(stream) as AppSetting;
                }
            }
            catch
            {
                appSetting = new AppSetting();
            }

            return appSetting;
        }

        public void SaveToFile()
        {
            string relativePath = @".\AppSetting.xml";
            using (Stream stream = new FileStream(relativePath, FileMode.Create))
            {
                XmlSerializer xmlSerelize = new XmlSerializer(this.GetType());
                xmlSerelize.Serialize(stream, this);
            }
        }
    }
}