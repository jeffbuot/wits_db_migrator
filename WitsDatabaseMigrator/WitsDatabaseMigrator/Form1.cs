using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;
using WITS.to.XAF.WITSRej;
using DevExpress.Xpo.Metadata;

namespace WitsDatabaseMigrator
{
    public partial class Form1 : TabForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            var connectionString = MSSqlConnectionProvider.GetConnectionString("AZ18W1350:1433", "sa", "Server12346789", "WITSTest2");
            var dataLayer = XpoDefault.GetDataLayer(connectionString, AutoCreateOption.DatabaseAndSchema);
            var uow = new UnitOfWork(dataLayer);

            //get class info
            XPClassInfo commodityClassInfo = uow.GetClassInfo(typeof(Commodity));
            var col = new XPCollection<PropertyMapping>(uow);

            foreach (XPMemberInfo i in commodityClassInfo.OwnMembers)
            {
                col.Add(new PropertyMapping() {
                    NewColumn = i.Name,
                    OldColumn = $"Old {i.Name}",
                    OldType = i.MemberType.Name,
                    NewType = i.MemberType.Name

                });                
            }


            //var propertyMap = new PropertyMapping() {
            //    LegacyName = "Certificate",
            //    NewPropertyName = "Certificate"
            //};

            //propertyMap.Save();
            //customerCollection.Add(propertyMap);


            //uow.CommitChanges();

            gridControl1.DataSource = col;
            gridControl1.Refresh();
        }
        void OnOuterFormCreating(object sender, OuterFormCreatingEventArgs e)
        {
            Form1 form = new Form1();
            form.TabFormControl.Pages.Clear();
            e.Form = form;
            OpenFormCount++;
        }
        static int OpenFormCount = 1;
                
        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void gridView1_ShowingEditor(object sender, CancelEventArgs e)
        {

        }
    }
}
