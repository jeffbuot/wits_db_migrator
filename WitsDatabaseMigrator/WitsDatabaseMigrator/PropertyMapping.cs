using System;
using DevExpress.Xpo;

namespace WitsDatabaseMigrator
{

    public class PropertyMapping : XPObject
    {
        public PropertyMapping() : base()
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public PropertyMapping(Session session) : base(session)
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
        private string _NewPropertyName;
        private string _LegacyName;

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string LegacyName
        {
            get
            {
                return _LegacyName;
            }
            set
            {
                SetPropertyValue("LegacyName", ref _LegacyName, value);
            }
        }


        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string NewPropertyName
        {
            get
            {
                return _NewPropertyName;
            }
            set
            {
                SetPropertyValue("NewPropertyName", ref _NewPropertyName, value);
            }
        }
    }

}