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
using DevExpress.XtraGrid;
using DevExpress.XtraEditors.Repository;
using DevExpress.Data.Filtering;
using WitsDatabaseMigrator.Helpers;
using System.Data.OleDb;
using DevExpress.XtraEditors;

namespace WitsDatabaseMigrator
{
    public partial class Form1 : TabForm
    {
        private UnitOfWork unitOfWork;
        IDataLayer dataLayer;
        private readonly DirectoryPathSettings dps;
        public Form1()
        {
            InitializeComponent();
            // --- Setup Connection
            dataLayer = ConnectionHelper.GetDataLayer(AutoCreateOption.DatabaseAndSchema);

            //Load Configurations
            dps = XMLHelper.LoadClassXML<DirectoryPathSettings>(DirectoryPathSettings.XMLPathDefault) as DirectoryPathSettings;
            if (dps == null) {
                dps = new DirectoryPathSettings();
                XMLHelper.SaveClassXML<DirectoryPathSettings>(dps,dps.);
            }
            //Load

            LoadAllMappingData();
        }

        private void LoadAllMappingData()
        {
            unitOfWork = new UnitOfWork(dataLayer);

            populateData(unitOfWork.GetClassInfo(typeof(Commodity)), gridControlCommodity, dropSourceRepoCommodity);
            populateData(unitOfWork.GetClassInfo(typeof(Certificate)), gridControlCertificate, dropSourceRepoCertificate);
            populateData(unitOfWork.GetClassInfo(typeof(Customer)), gridControlCustomer, dropSourceRepoCustomer);
            populateData(unitOfWork.GetClassInfo(typeof(LotNumber)), gridControlLotNum, dropSourceRepoLotNumber);
            populateData(unitOfWork.GetClassInfo(typeof(GrowerYTD)), gridControlGrowerYTD, dropSourceRepoGowerYTD);
            populateData(unitOfWork.GetClassInfo(typeof(SplitSetup)), gridControlSplitSetup, dropSourceRepoSplitSetup);
            populateData(unitOfWork.GetClassInfo(typeof(SplitDetail)), gridControlSplitDetails, dropSourceRepoSplitDetails);

        }

        private void populateData(XPClassInfo classInfo, GridControl gridControl, RepositoryItemComboBox cb)
        {
            var mappedObject = unitOfWork.FindObject<MappedColumn>(CriteriaOperator.Parse("TableName = ?", classInfo.TableName));
            if (mappedObject == null)
            {
                //setup the table to the database
                //now MappedColumn that doesn't appear in the database has nowhere to run
                foreach (XPMemberInfo i in classInfo.OwnMembers)
                {
                    mappedObject = new MappedColumn(unitOfWork)
                    {
                        TableName = classInfo.TableName,
                        NewColumn = i.Name,
                        NewType = i.MemberType.Name,
                        OldColumn = "(None)"
                    };
                    mappedObject.Save();
                }
            }
            unitOfWork.CommitChanges();
            gridControl.DataSource = new XPCollection<MappedColumn>(unitOfWork, CriteriaOperator.Parse("TableName=?", classInfo.TableName));
            gridControl.Refresh();
            populateDropdown(classInfo.TableName, cb);
        }

        private void populateDropdown(string TableName, RepositoryItemComboBox cb)
        {
            DataTable dt = new DataTable();
            string queryString = DBFConnectionHelper.DataTables[TableName];
            OleDbCommand cmd = new OleDbCommand(queryString);
            cmd.Connection = new OleDbConnection($"Provider=VfpOleDB;Data Source= {databaseDirectory};Collating Sequence=general");
            cmd.Connection.Open();
            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
            try
            {
                adapter.Fill(dt);
            }
            catch (OleDbException ex)
            {
                XtraMessageBox.Show(this, $"Unable to open database directory \"{databaseDirectory}\".", "Databae error.");
            }
            if (adapter != null)
                adapter.Dispose();
            if (cmd != null)
                cmd.Dispose();
            Console.WriteLine("Table test");
            foreach (DataColumn i in dt.Columns)
            {
                string s = i.ColumnName;
                cb.Items.Add(s);
                //Console.WriteLine(s);
            }
        }
        private void RestoreMappingettings()
        {

        }
        private void SaveAllMapping()
        {

        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }
        void OnOuterFormCreating(object sender, OuterFormCreatingEventArgs e)
        {
            Form1 form = new Form1();
            form.TabFormControl.Pages.Clear();
            e.Form = form;
            OpenFormCount++;
        }
        static int OpenFormCount = 1;

        private void btnBrowseDBF_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fb = new FolderBrowserDialog();
            fb.Description = "Select the database directory:";
            if (fb.ShowDialog(this) == DialogResult.OK)
            {
                databaseDirectory = fb.SelectedPath;
                System.Configuration.ConfigurationSettings.AppSettings["db_dir"] = databaseDirectory;
            }
        }

        private void btnBrowseXML_Click(object sender, EventArgs e)
        {

        }
    }
}
