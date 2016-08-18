using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace WITS.to.XAF.WITSRej
{

    public partial class LotNumber
    {
        public LotNumber(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
