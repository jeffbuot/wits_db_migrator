using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WitsDatabaseMigrator.Helpers
{
    public class DBFConnectionHelper
    {
        //public const String ConnectionString =;
        public static Dictionary<string, string> DataTables = new Dictionary<string, string> {
            {"Commodity","select * from commod where code != ''" },
            { "Certificate","select * from daily where sh_re != 'V'"},
            { "Customer", "select * from customer where id != ''"},
            { "LotNumber", "select * from Lot_info"},
            { "GrowerYTD", "select * from gro_ytd where code != ''"},
            { "SplitSetup", "select * from split_setup"},
            { "SplitDetail", "select * from split_detail"},
        };
    }
}
