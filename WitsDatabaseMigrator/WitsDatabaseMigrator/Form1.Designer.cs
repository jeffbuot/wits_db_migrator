namespace WitsDatabaseMigrator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
            if (--OpenFormCount == 0) System.Windows.Forms.Application.Exit();
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabFormControl1 = new DevExpress.XtraBars.TabFormControl();
            this.skinBarSubItem1 = new DevExpress.XtraBars.SkinBarSubItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barbtnSave = new DevExpress.XtraBars.BarButtonItem();
            this.barbtnSaveAll = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.tabFormDefaultManager1 = new DevExpress.XtraBars.TabFormDefaultManager();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.tabFormPage1 = new DevExpress.XtraBars.TabFormPage();
            this.xtraScrollableControl1 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBrowseXML = new DevExpress.XtraEditors.SimpleButton();
            this.btnBrowseDBF = new DevExpress.XtraEditors.SimpleButton();
            this.txtXMLDirectory = new System.Windows.Forms.TextBox();
            this.txtDBFDirectory = new System.Windows.Forms.TextBox();
            this.rtLogs = new System.Windows.Forms.RichTextBox();
            this.tabFormPage2 = new DevExpress.XtraBars.TabFormPage();
            this.xtraScrollableControl2 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.gridControlCommodity = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colOldColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dropSourceRepoCommodity = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.colNewColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tabFormPage3 = new DevExpress.XtraBars.TabFormPage();
            this.xtraScrollableControl3 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.gridControlCertificate = new DevExpress.XtraGrid.GridControl();
            this.xpCollection1 = new DevExpress.Xpo.XPCollection(this.components);
            this.gvCertificate = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colOldColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dropSourceRepoCertificate = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.colNewColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tabFormPage4 = new DevExpress.XtraBars.TabFormPage();
            this.xtraScrollableControl4 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.gridControlCustomer = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dropSourceRepoCustomer = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tabFormPage5 = new DevExpress.XtraBars.TabFormPage();
            this.xtraScrollableControl5 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.gridControlLotNum = new DevExpress.XtraGrid.GridControl();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dropSourceRepoLotNumber = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tabFormPage6 = new DevExpress.XtraBars.TabFormPage();
            this.xtraScrollableControl6 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.gridControlGrowerYTD = new DevExpress.XtraGrid.GridControl();
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dropSourceRepoGowerYTD = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tabFormPage7 = new DevExpress.XtraBars.TabFormPage();
            this.xtraScrollableControl7 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.gridControlSplitSetup = new DevExpress.XtraGrid.GridControl();
            this.gridView6 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dropSourceRepoSplitSetup = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tabFormPage8 = new DevExpress.XtraBars.TabFormPage();
            this.xtraScrollableControl8 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.gridControlSplitDetails = new DevExpress.XtraGrid.GridControl();
            this.gridView7 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dropSourceRepoSplitDetails = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tabFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabFormDefaultManager1)).BeginInit();
            this.xtraScrollableControl1.SuspendLayout();
            this.xtraScrollableControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCommodity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropSourceRepoCommodity)).BeginInit();
            this.xtraScrollableControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCertificate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCertificate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropSourceRepoCertificate)).BeginInit();
            this.xtraScrollableControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropSourceRepoCustomer)).BeginInit();
            this.xtraScrollableControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlLotNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropSourceRepoLotNumber)).BeginInit();
            this.xtraScrollableControl6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlGrowerYTD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropSourceRepoGowerYTD)).BeginInit();
            this.xtraScrollableControl7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSplitSetup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropSourceRepoSplitSetup)).BeginInit();
            this.xtraScrollableControl8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSplitDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropSourceRepoSplitDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // tabFormControl1
            // 
            this.tabFormControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.skinBarSubItem1,
            this.barButtonItem1,
            this.barSubItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barbtnSave,
            this.barbtnSaveAll,
            this.barButtonItem6});
            this.tabFormControl1.LinkProvider.TabLeftItemLinks.Add(this.skinBarSubItem1);
            this.tabFormControl1.LinkProvider.TabLeftItemLinks.Add(this.barbtnSave);
            this.tabFormControl1.LinkProvider.TabLeftItemLinks.Add(this.barbtnSaveAll);
            this.tabFormControl1.Location = new System.Drawing.Point(0, 0);
            this.tabFormControl1.Manager = this.tabFormDefaultManager1;
            this.tabFormControl1.Name = "tabFormControl1";
            this.tabFormControl1.Pages.Add(this.tabFormPage1);
            this.tabFormControl1.Pages.Add(this.tabFormPage2);
            this.tabFormControl1.Pages.Add(this.tabFormPage3);
            this.tabFormControl1.Pages.Add(this.tabFormPage4);
            this.tabFormControl1.Pages.Add(this.tabFormPage5);
            this.tabFormControl1.Pages.Add(this.tabFormPage6);
            this.tabFormControl1.Pages.Add(this.tabFormPage7);
            this.tabFormControl1.Pages.Add(this.tabFormPage8);
            this.tabFormControl1.SelectedPage = this.tabFormPage1;
            this.tabFormControl1.ShowAddPageButton = false;
            this.tabFormControl1.ShowTabsInTitleBar = DevExpress.XtraBars.ShowTabsInTitleBar.True;
            this.tabFormControl1.Size = new System.Drawing.Size(1135, 27);
            this.tabFormControl1.TabForm = this;
            this.tabFormControl1.TabIndex = 0;
            this.tabFormControl1.TabStop = false;
            this.tabFormControl1.OuterFormCreating += new DevExpress.XtraBars.OuterFormCreatingEventHandler(this.OnOuterFormCreating);
            // 
            // skinBarSubItem1
            // 
            this.skinBarSubItem1.Caption = "Theme";
            this.skinBarSubItem1.Id = 0;
            this.skinBarSubItem1.Name = "skinBarSubItem1";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Start Migration";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "Operations";
            this.barSubItem1.Id = 2;
            this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem2)});
            this.barSubItem1.Name = "barSubItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Start Migration";
            this.barButtonItem2.Id = 3;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Id = 4;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barbtnSave
            // 
            this.barbtnSave.Glyph = ((System.Drawing.Image)(resources.GetObject("barbtnSave.Glyph")));
            this.barbtnSave.Id = 5;
            this.barbtnSave.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barbtnSave.LargeGlyph")));
            this.barbtnSave.Name = "barbtnSave";
            // 
            // barbtnSaveAll
            // 
            this.barbtnSaveAll.Glyph = ((System.Drawing.Image)(resources.GetObject("barbtnSaveAll.Glyph")));
            this.barbtnSaveAll.Id = 7;
            this.barbtnSaveAll.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barbtnSaveAll.LargeGlyph")));
            this.barbtnSaveAll.Name = "barbtnSaveAll";
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem6.Glyph")));
            this.barButtonItem6.Id = 8;
            this.barButtonItem6.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem6.LargeGlyph")));
            this.barButtonItem6.Name = "barButtonItem6";
            // 
            // tabFormDefaultManager1
            // 
            this.tabFormDefaultManager1.DockControls.Add(this.barDockControlTop);
            this.tabFormDefaultManager1.DockControls.Add(this.barDockControlBottom);
            this.tabFormDefaultManager1.DockControls.Add(this.barDockControlLeft);
            this.tabFormDefaultManager1.DockControls.Add(this.barDockControlRight);
            this.tabFormDefaultManager1.Form = this;
            this.tabFormDefaultManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.skinBarSubItem1,
            this.barButtonItem1,
            this.barSubItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barbtnSave,
            this.barbtnSaveAll,
            this.barButtonItem6});
            this.tabFormDefaultManager1.MaxItemId = 9;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(1135, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 467);
            this.barDockControlBottom.Size = new System.Drawing.Size(1135, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 467);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1135, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 467);
            // 
            // tabFormPage1
            // 
            this.tabFormPage1.ContentContainer = this.xtraScrollableControl1;
            this.tabFormPage1.Name = "tabFormPage1";
            this.tabFormPage1.ShowCloseButton = DevExpress.Utils.DefaultBoolean.False;
            this.tabFormPage1.Text = "Main ";
            // 
            // xtraScrollableControl1
            // 
            this.xtraScrollableControl1.Controls.Add(this.label2);
            this.xtraScrollableControl1.Controls.Add(this.label1);
            this.xtraScrollableControl1.Controls.Add(this.btnBrowseXML);
            this.xtraScrollableControl1.Controls.Add(this.btnBrowseDBF);
            this.xtraScrollableControl1.Controls.Add(this.txtXMLDirectory);
            this.xtraScrollableControl1.Controls.Add(this.txtDBFDirectory);
            this.xtraScrollableControl1.Controls.Add(this.rtLogs);
            this.xtraScrollableControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl1.Location = new System.Drawing.Point(0, 27);
            this.xtraScrollableControl1.Name = "xtraScrollableControl1";
            this.xtraScrollableControl1.Size = new System.Drawing.Size(1135, 440);
            this.xtraScrollableControl1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(93, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Map Saving Path(XML):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Fox Pro Database Directory:";
            // 
            // btnBrowseXML
            // 
            this.btnBrowseXML.Location = new System.Drawing.Point(12, 75);
            this.btnBrowseXML.Name = "btnBrowseXML";
            this.btnBrowseXML.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseXML.TabIndex = 10;
            this.btnBrowseXML.Text = "Browse...";
            this.btnBrowseXML.Click += new System.EventHandler(this.btnBrowseXML_Click);
            // 
            // btnBrowseDBF
            // 
            this.btnBrowseDBF.Location = new System.Drawing.Point(12, 29);
            this.btnBrowseDBF.Name = "btnBrowseDBF";
            this.btnBrowseDBF.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseDBF.TabIndex = 9;
            this.btnBrowseDBF.Text = "Browse...";
            this.btnBrowseDBF.Click += new System.EventHandler(this.btnBrowseDBF_Click);
            // 
            // txtXMLDirectory
            // 
            this.txtXMLDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtXMLDirectory.Location = new System.Drawing.Point(93, 76);
            this.txtXMLDirectory.Name = "txtXMLDirectory";
            this.txtXMLDirectory.ReadOnly = true;
            this.txtXMLDirectory.Size = new System.Drawing.Size(1030, 21);
            this.txtXMLDirectory.TabIndex = 8;
            this.txtXMLDirectory.Text = "D:\\\\WitsMap.xml";
            // 
            // txtDBFDirectory
            // 
            this.txtDBFDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDBFDirectory.Location = new System.Drawing.Point(93, 31);
            this.txtDBFDirectory.Name = "txtDBFDirectory";
            this.txtDBFDirectory.ReadOnly = true;
            this.txtDBFDirectory.Size = new System.Drawing.Size(1030, 21);
            this.txtDBFDirectory.TabIndex = 7;
            this.txtDBFDirectory.Text = "D:\\\\Data\\\\";
            // 
            // rtLogs
            // 
            this.rtLogs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtLogs.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtLogs.Location = new System.Drawing.Point(12, 105);
            this.rtLogs.Name = "rtLogs";
            this.rtLogs.Size = new System.Drawing.Size(1111, 323);
            this.rtLogs.TabIndex = 6;
            this.rtLogs.Text = "Wits Migration Logs";
            // 
            // tabFormPage2
            // 
            this.tabFormPage2.ContentContainer = this.xtraScrollableControl2;
            this.tabFormPage2.Name = "tabFormPage2";
            this.tabFormPage2.ShowCloseButton = DevExpress.Utils.DefaultBoolean.False;
            this.tabFormPage2.Text = "Commodity";
            // 
            // xtraScrollableControl2
            // 
            this.xtraScrollableControl2.Controls.Add(this.gridControlCommodity);
            this.xtraScrollableControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl2.Location = new System.Drawing.Point(0, 27);
            this.xtraScrollableControl2.Name = "xtraScrollableControl2";
            this.xtraScrollableControl2.Size = new System.Drawing.Size(1039, 438);
            this.xtraScrollableControl2.TabIndex = 11;
            // 
            // gridControlCommodity
            // 
            this.gridControlCommodity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlCommodity.Location = new System.Drawing.Point(0, 0);
            this.gridControlCommodity.MainView = this.gridView2;
            this.gridControlCommodity.Name = "gridControlCommodity";
            this.gridControlCommodity.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.dropSourceRepoCommodity});
            this.gridControlCommodity.Size = new System.Drawing.Size(1039, 438);
            this.gridControlCommodity.TabIndex = 9;
            this.gridControlCommodity.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colOldColumn1,
            this.colNewColumn1});
            this.gridView2.GridControl = this.gridControlCommodity;
            this.gridView2.Name = "gridView2";
            // 
            // colOldColumn1
            // 
            this.colOldColumn1.Caption = "Source";
            this.colOldColumn1.ColumnEdit = this.dropSourceRepoCommodity;
            this.colOldColumn1.FieldName = "OldColumn";
            this.colOldColumn1.Name = "colOldColumn1";
            this.colOldColumn1.Visible = true;
            this.colOldColumn1.VisibleIndex = 0;
            // 
            // dropSourceRepoCommodity
            // 
            this.dropSourceRepoCommodity.AutoHeight = false;
            this.dropSourceRepoCommodity.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dropSourceRepoCommodity.Name = "dropSourceRepoCommodity";
            this.dropSourceRepoCommodity.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // colNewColumn1
            // 
            this.colNewColumn1.Caption = "Destination";
            this.colNewColumn1.FieldName = "NewColumn";
            this.colNewColumn1.Name = "colNewColumn1";
            this.colNewColumn1.OptionsColumn.AllowEdit = false;
            this.colNewColumn1.Visible = true;
            this.colNewColumn1.VisibleIndex = 1;
            // 
            // tabFormPage3
            // 
            this.tabFormPage3.ContentContainer = this.xtraScrollableControl3;
            this.tabFormPage3.Name = "tabFormPage3";
            this.tabFormPage3.ShowCloseButton = DevExpress.Utils.DefaultBoolean.False;
            this.tabFormPage3.Text = "Certificate";
            // 
            // xtraScrollableControl3
            // 
            this.xtraScrollableControl3.Controls.Add(this.gridControlCertificate);
            this.xtraScrollableControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl3.Location = new System.Drawing.Point(0, 27);
            this.xtraScrollableControl3.Name = "xtraScrollableControl3";
            this.xtraScrollableControl3.Size = new System.Drawing.Size(952, 434);
            this.xtraScrollableControl3.TabIndex = 12;
            // 
            // gridControlCertificate
            // 
            this.gridControlCertificate.DataSource = this.xpCollection1;
            this.gridControlCertificate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlCertificate.Location = new System.Drawing.Point(0, 0);
            this.gridControlCertificate.MainView = this.gvCertificate;
            this.gridControlCertificate.Name = "gridControlCertificate";
            this.gridControlCertificate.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.dropSourceRepoCertificate});
            this.gridControlCertificate.Size = new System.Drawing.Size(952, 434);
            this.gridControlCertificate.TabIndex = 5;
            this.gridControlCertificate.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCertificate});
            // 
            // xpCollection1
            // 
            this.xpCollection1.ObjectType = typeof(WitsDatabaseMigrator.PropertyMapping);
            // 
            // gvCertificate
            // 
            this.gvCertificate.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colOldColumn,
            this.colNewColumn});
            this.gvCertificate.GridControl = this.gridControlCertificate;
            this.gvCertificate.Name = "gvCertificate";
            // 
            // colOldColumn
            // 
            this.colOldColumn.Caption = "Source";
            this.colOldColumn.ColumnEdit = this.dropSourceRepoCertificate;
            this.colOldColumn.FieldName = "OldColumn";
            this.colOldColumn.Name = "colOldColumn";
            this.colOldColumn.Visible = true;
            this.colOldColumn.VisibleIndex = 0;
            // 
            // dropSourceRepoCertificate
            // 
            this.dropSourceRepoCertificate.AutoHeight = false;
            this.dropSourceRepoCertificate.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dropSourceRepoCertificate.Name = "dropSourceRepoCertificate";
            this.dropSourceRepoCertificate.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // colNewColumn
            // 
            this.colNewColumn.Caption = "Destination";
            this.colNewColumn.FieldName = "NewColumn";
            this.colNewColumn.Name = "colNewColumn";
            this.colNewColumn.OptionsColumn.AllowEdit = false;
            this.colNewColumn.Visible = true;
            this.colNewColumn.VisibleIndex = 1;
            // 
            // tabFormPage4
            // 
            this.tabFormPage4.ContentContainer = this.xtraScrollableControl4;
            this.tabFormPage4.Name = "tabFormPage4";
            this.tabFormPage4.ShowCloseButton = DevExpress.Utils.DefaultBoolean.False;
            this.tabFormPage4.Text = "Customer";
            // 
            // xtraScrollableControl4
            // 
            this.xtraScrollableControl4.Controls.Add(this.gridControlCustomer);
            this.xtraScrollableControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl4.Location = new System.Drawing.Point(0, 27);
            this.xtraScrollableControl4.Name = "xtraScrollableControl4";
            this.xtraScrollableControl4.Size = new System.Drawing.Size(952, 434);
            this.xtraScrollableControl4.TabIndex = 13;
            // 
            // gridControlCustomer
            // 
            this.gridControlCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlCustomer.Location = new System.Drawing.Point(0, 0);
            this.gridControlCustomer.MainView = this.gridView3;
            this.gridControlCustomer.Name = "gridControlCustomer";
            this.gridControlCustomer.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.dropSourceRepoCustomer});
            this.gridControlCustomer.Size = new System.Drawing.Size(952, 434);
            this.gridControlCustomer.TabIndex = 10;
            this.gridControlCustomer.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn11,
            this.gridColumn12});
            this.gridView3.GridControl = this.gridControlCustomer;
            this.gridView3.Name = "gridView3";
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "Source";
            this.gridColumn11.ColumnEdit = this.dropSourceRepoCustomer;
            this.gridColumn11.FieldName = "OldColumn";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 0;
            // 
            // dropSourceRepoCustomer
            // 
            this.dropSourceRepoCustomer.AutoHeight = false;
            this.dropSourceRepoCustomer.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dropSourceRepoCustomer.Name = "dropSourceRepoCustomer";
            this.dropSourceRepoCustomer.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "Destination";
            this.gridColumn12.FieldName = "NewColumn";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.OptionsColumn.AllowEdit = false;
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 1;
            // 
            // tabFormPage5
            // 
            this.tabFormPage5.ContentContainer = this.xtraScrollableControl5;
            this.tabFormPage5.Name = "tabFormPage5";
            this.tabFormPage5.ShowCloseButton = DevExpress.Utils.DefaultBoolean.False;
            this.tabFormPage5.Text = "LotNumber";
            // 
            // xtraScrollableControl5
            // 
            this.xtraScrollableControl5.Controls.Add(this.gridControlLotNum);
            this.xtraScrollableControl5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl5.Location = new System.Drawing.Point(0, 27);
            this.xtraScrollableControl5.Name = "xtraScrollableControl5";
            this.xtraScrollableControl5.Size = new System.Drawing.Size(952, 434);
            this.xtraScrollableControl5.TabIndex = 14;
            // 
            // gridControlLotNum
            // 
            this.gridControlLotNum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlLotNum.Location = new System.Drawing.Point(0, 0);
            this.gridControlLotNum.MainView = this.gridView4;
            this.gridControlLotNum.Name = "gridControlLotNum";
            this.gridControlLotNum.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.dropSourceRepoLotNumber});
            this.gridControlLotNum.Size = new System.Drawing.Size(952, 434);
            this.gridControlLotNum.TabIndex = 11;
            this.gridControlLotNum.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView4});
            // 
            // gridView4
            // 
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn9,
            this.gridColumn10});
            this.gridView4.GridControl = this.gridControlLotNum;
            this.gridView4.Name = "gridView4";
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Source";
            this.gridColumn9.ColumnEdit = this.dropSourceRepoLotNumber;
            this.gridColumn9.FieldName = "OldColumn";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 0;
            // 
            // dropSourceRepoLotNumber
            // 
            this.dropSourceRepoLotNumber.AutoHeight = false;
            this.dropSourceRepoLotNumber.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dropSourceRepoLotNumber.Name = "dropSourceRepoLotNumber";
            this.dropSourceRepoLotNumber.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Destination";
            this.gridColumn10.FieldName = "NewColumn";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.OptionsColumn.AllowEdit = false;
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 1;
            // 
            // tabFormPage6
            // 
            this.tabFormPage6.ContentContainer = this.xtraScrollableControl6;
            this.tabFormPage6.Name = "tabFormPage6";
            this.tabFormPage6.ShowCloseButton = DevExpress.Utils.DefaultBoolean.False;
            this.tabFormPage6.Text = "GroYTD";
            // 
            // xtraScrollableControl6
            // 
            this.xtraScrollableControl6.Controls.Add(this.gridControlGrowerYTD);
            this.xtraScrollableControl6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl6.Location = new System.Drawing.Point(0, 27);
            this.xtraScrollableControl6.Name = "xtraScrollableControl6";
            this.xtraScrollableControl6.Size = new System.Drawing.Size(1135, 440);
            this.xtraScrollableControl6.TabIndex = 11;
            // 
            // gridControlGrowerYTD
            // 
            this.gridControlGrowerYTD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlGrowerYTD.Location = new System.Drawing.Point(0, 0);
            this.gridControlGrowerYTD.MainView = this.gridView5;
            this.gridControlGrowerYTD.Name = "gridControlGrowerYTD";
            this.gridControlGrowerYTD.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.dropSourceRepoGowerYTD});
            this.gridControlGrowerYTD.Size = new System.Drawing.Size(1135, 440);
            this.gridControlGrowerYTD.TabIndex = 12;
            this.gridControlGrowerYTD.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView5});
            // 
            // gridView5
            // 
            this.gridView5.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn7,
            this.gridColumn8});
            this.gridView5.GridControl = this.gridControlGrowerYTD;
            this.gridView5.Name = "gridView5";
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Source";
            this.gridColumn7.ColumnEdit = this.dropSourceRepoGowerYTD;
            this.gridColumn7.FieldName = "OldColumn";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 0;
            // 
            // dropSourceRepoGowerYTD
            // 
            this.dropSourceRepoGowerYTD.AutoHeight = false;
            this.dropSourceRepoGowerYTD.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dropSourceRepoGowerYTD.Name = "dropSourceRepoGowerYTD";
            this.dropSourceRepoGowerYTD.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Destination";
            this.gridColumn8.FieldName = "NewColumn";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.OptionsColumn.AllowEdit = false;
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 1;
            // 
            // tabFormPage7
            // 
            this.tabFormPage7.ContentContainer = this.xtraScrollableControl7;
            this.tabFormPage7.Name = "tabFormPage7";
            this.tabFormPage7.ShowCloseButton = DevExpress.Utils.DefaultBoolean.False;
            this.tabFormPage7.Text = "Split Setup";
            // 
            // xtraScrollableControl7
            // 
            this.xtraScrollableControl7.Controls.Add(this.gridControlSplitSetup);
            this.xtraScrollableControl7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl7.Location = new System.Drawing.Point(0, 27);
            this.xtraScrollableControl7.Name = "xtraScrollableControl7";
            this.xtraScrollableControl7.Size = new System.Drawing.Size(1135, 440);
            this.xtraScrollableControl7.TabIndex = 12;
            // 
            // gridControlSplitSetup
            // 
            this.gridControlSplitSetup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlSplitSetup.Location = new System.Drawing.Point(0, 0);
            this.gridControlSplitSetup.MainView = this.gridView6;
            this.gridControlSplitSetup.Name = "gridControlSplitSetup";
            this.gridControlSplitSetup.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.dropSourceRepoSplitSetup});
            this.gridControlSplitSetup.Size = new System.Drawing.Size(1135, 440);
            this.gridControlSplitSetup.TabIndex = 13;
            this.gridControlSplitSetup.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView6});
            // 
            // gridView6
            // 
            this.gridView6.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn5,
            this.gridColumn6});
            this.gridView6.GridControl = this.gridControlSplitSetup;
            this.gridView6.Name = "gridView6";
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Source";
            this.gridColumn5.ColumnEdit = this.dropSourceRepoSplitSetup;
            this.gridColumn5.FieldName = "OldColumn";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 0;
            // 
            // dropSourceRepoSplitSetup
            // 
            this.dropSourceRepoSplitSetup.AutoHeight = false;
            this.dropSourceRepoSplitSetup.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dropSourceRepoSplitSetup.Name = "dropSourceRepoSplitSetup";
            this.dropSourceRepoSplitSetup.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Destination";
            this.gridColumn6.FieldName = "NewColumn";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 1;
            // 
            // tabFormPage8
            // 
            this.tabFormPage8.ContentContainer = this.xtraScrollableControl8;
            this.tabFormPage8.Name = "tabFormPage8";
            this.tabFormPage8.Text = "Split Details";
            // 
            // xtraScrollableControl8
            // 
            this.xtraScrollableControl8.Controls.Add(this.gridControlSplitDetails);
            this.xtraScrollableControl8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl8.Location = new System.Drawing.Point(0, 27);
            this.xtraScrollableControl8.Name = "xtraScrollableControl8";
            this.xtraScrollableControl8.Size = new System.Drawing.Size(1135, 440);
            this.xtraScrollableControl8.TabIndex = 13;
            // 
            // gridControlSplitDetails
            // 
            this.gridControlSplitDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlSplitDetails.Location = new System.Drawing.Point(0, 0);
            this.gridControlSplitDetails.MainView = this.gridView7;
            this.gridControlSplitDetails.Name = "gridControlSplitDetails";
            this.gridControlSplitDetails.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.dropSourceRepoSplitDetails});
            this.gridControlSplitDetails.Size = new System.Drawing.Size(1135, 440);
            this.gridControlSplitDetails.TabIndex = 14;
            this.gridControlSplitDetails.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView7});
            // 
            // gridView7
            // 
            this.gridView7.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn3,
            this.gridColumn4});
            this.gridView7.GridControl = this.gridControlSplitDetails;
            this.gridView7.Name = "gridView7";
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Source";
            this.gridColumn3.ColumnEdit = this.dropSourceRepoSplitDetails;
            this.gridColumn3.FieldName = "OldColumn";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 0;
            // 
            // dropSourceRepoSplitDetails
            // 
            this.dropSourceRepoSplitDetails.AutoHeight = false;
            this.dropSourceRepoSplitDetails.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dropSourceRepoSplitDetails.Name = "dropSourceRepoSplitDetails";
            this.dropSourceRepoSplitDetails.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Destination";
            this.gridColumn4.FieldName = "NewColumn";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 467);
            this.Controls.Add(this.xtraScrollableControl1);
            this.Controls.Add(this.tabFormControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "Form1";
            this.TabFormControl = this.tabFormControl1;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tabFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabFormDefaultManager1)).EndInit();
            this.xtraScrollableControl1.ResumeLayout(false);
            this.xtraScrollableControl1.PerformLayout();
            this.xtraScrollableControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCommodity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropSourceRepoCommodity)).EndInit();
            this.xtraScrollableControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCertificate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCertificate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropSourceRepoCertificate)).EndInit();
            this.xtraScrollableControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropSourceRepoCustomer)).EndInit();
            this.xtraScrollableControl5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlLotNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropSourceRepoLotNumber)).EndInit();
            this.xtraScrollableControl6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlGrowerYTD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropSourceRepoGowerYTD)).EndInit();
            this.xtraScrollableControl7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSplitSetup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropSourceRepoSplitSetup)).EndInit();
            this.xtraScrollableControl8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSplitDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dropSourceRepoSplitDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.TabFormControl tabFormControl1;
        private DevExpress.XtraBars.TabFormDefaultManager tabFormDefaultManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl1;
        private DevExpress.XtraBars.TabFormPage tabFormPage1;
        private DevExpress.Xpo.XPCollection xpCollection1;
        private DevExpress.XtraBars.SkinBarSubItem skinBarSubItem1;
        private System.Windows.Forms.RichTextBox rtLogs;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barbtnSave;
        private DevExpress.XtraBars.BarButtonItem barbtnSaveAll;
        private DevExpress.XtraBars.TabFormPage tabFormPage2;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl2;
        private DevExpress.XtraBars.TabFormPage tabFormPage3;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl3;
        private DevExpress.XtraBars.TabFormPage tabFormPage4;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl4;
        private DevExpress.XtraBars.TabFormPage tabFormPage5;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl5;
        private DevExpress.XtraBars.TabFormPage tabFormPage6;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl6;
        private DevExpress.XtraBars.TabFormPage tabFormPage7;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl7;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraEditors.SimpleButton btnBrowseXML;
        private DevExpress.XtraEditors.SimpleButton btnBrowseDBF;
        private System.Windows.Forms.TextBox txtXMLDirectory;
        private System.Windows.Forms.TextBox txtDBFDirectory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gridControlCommodity;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colOldColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox dropSourceRepoCommodity;
        private DevExpress.XtraGrid.Columns.GridColumn colNewColumn1;
        private DevExpress.XtraGrid.GridControl gridControlCertificate;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCertificate;
        private DevExpress.XtraGrid.Columns.GridColumn colOldColumn;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox dropSourceRepoCertificate;
        private DevExpress.XtraGrid.Columns.GridColumn colNewColumn;
        private DevExpress.XtraGrid.GridControl gridControlCustomer;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox dropSourceRepoCustomer;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.GridControl gridControlLotNum;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox dropSourceRepoLotNumber;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.GridControl gridControlGrowerYTD;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox dropSourceRepoGowerYTD;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraBars.TabFormPage tabFormPage8;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl8;
        private DevExpress.XtraGrid.GridControl gridControlSplitDetails;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox dropSourceRepoSplitDetails;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.GridControl gridControlSplitSetup;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox dropSourceRepoSplitSetup;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
    }
}

