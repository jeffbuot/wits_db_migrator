using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WitsDatabaseMigrator.Helpers
{
    public class DirectoryPathSettings
    {// Fields...
        private string _XMLFilePath;
        private string _DBFDirectoryPath;
        private const string xmlDefaultValue = "D:\\witsmap.xml";
        private const string dbfDefaultValue = "D:\\Data\\";
        public static readonly string XMLPathDefault = "temp.xml";

        public string DBFDirectoryPath
        {
            get { return _DBFDirectoryPath == null ? dbfDefaultValue : _DBFDirectoryPath; }
            set
            {
                if (_DBFDirectoryPath.Equals(value)) return;
                _DBFDirectoryPath = value;
            }
        }


        public string XMLFilePath
        {
            get { return _XMLFilePath == null ? xmlDefaultValue : _XMLFilePath; }
            set
            {
                if (_XMLFilePath.Equals(value)) return;
                _XMLFilePath = value;
            }
        }
        
    }
}
