using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace WitsDatabaseMigrator.Helpers
{
    public class XMLHelper
    {
        public static void SaveClassXML<T>(Object obj, string path)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
            using (FileStream fs = new FileStream(path, FileMode.Create))
            {
                //saving the file
                xmlSerializer.Serialize(fs, obj);
            }
        }
        public static object LoadClassXML<T>(string path)
        {
            if (!File.Exists(path))
            {
                return null;
            }
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
            FileStream fs = new FileStream(@path, FileMode.OpenOrCreate);
            Object o = xmlSerializer.Deserialize(fs);
            fs.Close();
            return o;
        }
    }
}
