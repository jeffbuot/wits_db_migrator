using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WitsDatabaseMigrator.Helpers
{
    class MapList
    {
        private List<MappedColumn> _MappedColumnList;

        public MapList()
        {
            _MappedColumnList = new List<MappedColumn>();
        }


        public List<MappedColumn> MappedColumnList
        {
            get { return _MappedColumnList; }
            set
            {
                _MappedColumnList = value;
            }
        }
        
    }
}
