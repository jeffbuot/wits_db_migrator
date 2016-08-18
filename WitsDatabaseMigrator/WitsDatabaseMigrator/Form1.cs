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

            //var connectionString = MSSqlConnectionProvider.GetConnectionString("AZ18W1350:1433", "sa", "Server12346789", "WITSMigration");
            //var dataLayer = XpoDefault.GetDataLayer(connectionString, AutoCreateOption.DatabaseAndSchema);
            //var uow = new UnitOfWork(dataLayer);

            //var customerCollection = new XPCollection<PropertyMapping>(uow);

            //var propertyMap = new PropertyMapping() {
            //    LegacyName = "Certificate",
            //    NewPropertyName = "Certificate"
            //};

            //propertyMap.Save();
            //customerCollection.Add(propertyMap);


            //uow.CommitChanges();

            //gridControl1.DataSource = customerCollection;
            //gridControl1.Refresh();
        }
        void OnOuterFormCreating(object sender, OuterFormCreatingEventArgs e)
        {
            Form1 form = new Form1();
            form.TabFormControl.Pages.Clear();
            e.Form = form;
            OpenFormCount++;
        }
        static int OpenFormCount = 1;

        private void tabFormControl1_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            tabFormControl1.Pages.Add;
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
    }
}
