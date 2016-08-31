using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Xpo;

namespace WitsDatabaseMigrator.Helpers
{
    public class MappedColumn : XPObject
    {
        public MappedColumn() : base()
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public MappedColumn(Session session) : base(session)
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place here your initialization code.
        }

        // Fields...
        private string _NewType;
        private string _OldType;
        private string _TableName;
        private string _NewColumn;
        private string _OldColumn;


        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string TableName
        {
            get
            {
                return _TableName;
            }
            set
            {
                SetPropertyValue("TableName", ref _TableName, value);
            }
        }
        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string OldColumn
        {
            get
            {
                return _OldColumn;
            }
            set
            {
                SetPropertyValue("OldColumn", ref _OldColumn, value);
            }
        }


        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string OldType
        {
            get
            {
                return _OldType;
            }
            set
            {
                SetPropertyValue("OldType", ref _OldType, value);
            }
        }

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string NewColumn
        {
            get
            {
                return _NewColumn;
            }
            set
            {
                SetPropertyValue("NewColumn", ref _NewColumn, value);
            }
        }


        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string NewType
        {
            get
            {
                return _NewType;
            }
            set
            {
                SetPropertyValue("NewType", ref _NewType, value);
            }
        }
    }
}
