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
            this.simpleButton7 = new DevExpress.XtraEditors.SimpleButton();
            this.rtLogs = new System.Windows.Forms.RichTextBox();
            this.simpleButton6 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.tabFormPage2 = new DevExpress.XtraBars.TabFormPage();
            this.xtraScrollableControl2 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.xpCollection1 = new DevExpress.Xpo.XPCollection(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colOid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLegacyName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNewPropertyName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tabFormPage3 = new DevExpress.XtraBars.TabFormPage();
            this.xtraScrollableControl3 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.tabFormPage4 = new DevExpress.XtraBars.TabFormPage();
            this.xtraScrollableControl4 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.tabFormPage5 = new DevExpress.XtraBars.TabFormPage();
            this.xtraScrollableControl5 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.tabFormPage6 = new DevExpress.XtraBars.TabFormPage();
            this.xtraScrollableControl6 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.tabFormPage7 = new DevExpress.XtraBars.TabFormPage();
            this.xtraScrollableControl7 = new DevExpress.XtraEditors.XtraScrollableControl();
            ((System.ComponentModel.ISupportInitialize)(this.tabFormControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabFormDefaultManager1)).BeginInit();
            this.xtraScrollableControl1.SuspendLayout();
            this.xtraScrollableControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
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
            this.tabFormControl1.SelectedPage = this.tabFormPage2;
            this.tabFormControl1.ShowAddPageButton = false;
            this.tabFormControl1.ShowTabsInTitleBar = DevExpress.XtraBars.ShowTabsInTitleBar.True;
            this.tabFormControl1.Size = new System.Drawing.Size(1134, 27);
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
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
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
            this.barbtnSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
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
            this.barDockControlTop.Location = new System.Drawing.Point(0, 27);
            this.barDockControlTop.Size = new System.Drawing.Size(1134, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 597);
            this.barDockControlBottom.Size = new System.Drawing.Size(1134, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 27);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 570);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1134, 27);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 570);
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
            this.xtraScrollableControl1.Controls.Add(this.simpleButton7);
            this.xtraScrollableControl1.Controls.Add(this.rtLogs);
            this.xtraScrollableControl1.Controls.Add(this.simpleButton6);
            this.xtraScrollableControl1.Controls.Add(this.simpleButton5);
            this.xtraScrollableControl1.Controls.Add(this.simpleButton4);
            this.xtraScrollableControl1.Controls.Add(this.simpleButton3);
            this.xtraScrollableControl1.Controls.Add(this.simpleButton2);
            this.xtraScrollableControl1.Controls.Add(this.simpleButton1);
            this.xtraScrollableControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl1.Location = new System.Drawing.Point(0, 27);
            this.xtraScrollableControl1.Name = "xtraScrollableControl1";
            this.xtraScrollableControl1.Size = new System.Drawing.Size(1134, 570);
            this.xtraScrollableControl1.TabIndex = 6;
            // 
            // simpleButton7
            // 
            this.simpleButton7.Appearance.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton7.Appearance.Options.UseFont = true;
            this.simpleButton7.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.simpleButton7.Location = new System.Drawing.Point(12, 324);
            this.simpleButton7.Name = "simpleButton7";
            this.simpleButton7.Size = new System.Drawing.Size(143, 47);
            this.simpleButton7.TabIndex = 7;
            this.simpleButton7.Text = "All";
            // 
            // rtLogs
            // 
            this.rtLogs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtLogs.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtLogs.Location = new System.Drawing.Point(161, 6);
            this.rtLogs.Name = "rtLogs";
            this.rtLogs.Size = new System.Drawing.Size(970, 561);
            this.rtLogs.TabIndex = 6;
            this.rtLogs.Text = "Wits Migration Logs";
            // 
            // simpleButton6
            // 
            this.simpleButton6.Appearance.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton6.Appearance.Options.UseFont = true;
            this.simpleButton6.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.simpleButton6.Location = new System.Drawing.Point(12, 112);
            this.simpleButton6.Name = "simpleButton6";
            this.simpleButton6.Size = new System.Drawing.Size(143, 47);
            this.simpleButton6.TabIndex = 5;
            this.simpleButton6.Text = "Customer";
            // 
            // simpleButton5
            // 
            this.simpleButton5.Appearance.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton5.Appearance.Options.UseFont = true;
            this.simpleButton5.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.simpleButton5.Location = new System.Drawing.Point(12, 271);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(143, 47);
            this.simpleButton5.TabIndex = 4;
            this.simpleButton5.Text = "Splits";
            // 
            // simpleButton4
            // 
            this.simpleButton4.Appearance.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton4.Appearance.Options.UseFont = true;
            this.simpleButton4.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.simpleButton4.Location = new System.Drawing.Point(12, 218);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(143, 47);
            this.simpleButton4.TabIndex = 3;
            this.simpleButton4.Text = "GroYTD";
            // 
            // simpleButton3
            // 
            this.simpleButton3.Appearance.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.simpleButton3.Location = new System.Drawing.Point(12, 165);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(143, 47);
            this.simpleButton3.TabIndex = 2;
            this.simpleButton3.Text = "Lot Number";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.simpleButton2.Location = new System.Drawing.Point(12, 59);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(143, 47);
            this.simpleButton2.TabIndex = 1;
            this.simpleButton2.Text = "Certificate";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.simpleButton1.Location = new System.Drawing.Point(12, 6);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(143, 47);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "Commodity";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
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
            this.xtraScrollableControl2.Controls.Add(this.gridControl1);
            this.xtraScrollableControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl2.Location = new System.Drawing.Point(0, 27);
            this.xtraScrollableControl2.Name = "xtraScrollableControl2";
            this.xtraScrollableControl2.Size = new System.Drawing.Size(1134, 570);
            this.xtraScrollableControl2.TabIndex = 11;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.xpCollection1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.tabFormDefaultManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1134, 570);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // xpCollection1
            // 
            this.xpCollection1.ObjectType = typeof(WitsDatabaseMigrator.PropertyMapping);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colOid,
            this.colLegacyName,
            this.colNewPropertyName});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.ShowingEditor += new System.ComponentModel.CancelEventHandler(this.gridView1_ShowingEditor);
            // 
            // colOid
            // 
            this.colOid.FieldName = "Oid";
            this.colOid.Name = "colOid";
            this.colOid.Visible = true;
            this.colOid.VisibleIndex = 0;
            // 
            // colLegacyName
            // 
            this.colLegacyName.FieldName = "LegacyName";
            this.colLegacyName.Name = "colLegacyName";
            this.colLegacyName.Visible = true;
            this.colLegacyName.VisibleIndex = 1;
            // 
            // colNewPropertyName
            // 
            this.colNewPropertyName.FieldName = "NewPropertyName";
            this.colNewPropertyName.Name = "colNewPropertyName";
            this.colNewPropertyName.Visible = true;
            this.colNewPropertyName.VisibleIndex = 2;
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
            this.xtraScrollableControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl3.Location = new System.Drawing.Point(0, 27);
            this.xtraScrollableControl3.Name = "xtraScrollableControl3";
            this.xtraScrollableControl3.Size = new System.Drawing.Size(1134, 570);
            this.xtraScrollableControl3.TabIndex = 12;
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
            this.xtraScrollableControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl4.Location = new System.Drawing.Point(0, 27);
            this.xtraScrollableControl4.Name = "xtraScrollableControl4";
            this.xtraScrollableControl4.Size = new System.Drawing.Size(1134, 570);
            this.xtraScrollableControl4.TabIndex = 13;
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
            this.xtraScrollableControl5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl5.Location = new System.Drawing.Point(0, 27);
            this.xtraScrollableControl5.Name = "xtraScrollableControl5";
            this.xtraScrollableControl5.Size = new System.Drawing.Size(1134, 570);
            this.xtraScrollableControl5.TabIndex = 14;
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
            this.xtraScrollableControl6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl6.Location = new System.Drawing.Point(0, 27);
            this.xtraScrollableControl6.Name = "xtraScrollableControl6";
            this.xtraScrollableControl6.Size = new System.Drawing.Size(1134, 570);
            this.xtraScrollableControl6.TabIndex = 11;
            // 
            // tabFormPage7
            // 
            this.tabFormPage7.ContentContainer = this.xtraScrollableControl7;
            this.tabFormPage7.Name = "tabFormPage7";
            this.tabFormPage7.ShowCloseButton = DevExpress.Utils.DefaultBoolean.False;
            this.tabFormPage7.Text = "Split";
            // 
            // xtraScrollableControl7
            // 
            this.xtraScrollableControl7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl7.Location = new System.Drawing.Point(0, 27);
            this.xtraScrollableControl7.Name = "xtraScrollableControl7";
            this.xtraScrollableControl7.Size = new System.Drawing.Size(1134, 570);
            this.xtraScrollableControl7.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 597);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Controls.Add(this.xtraScrollableControl2);
            this.Controls.Add(this.tabFormControl1);
            this.Name = "Form1";
            this.TabFormControl = this.tabFormControl1;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tabFormControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabFormDefaultManager1)).EndInit();
            this.xtraScrollableControl1.ResumeLayout(false);
            this.xtraScrollableControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
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
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.RichTextBox rtLogs;
        private DevExpress.XtraEditors.SimpleButton simpleButton6;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
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
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton simpleButton7;
        private DevExpress.XtraGrid.Columns.GridColumn colOid;
        private DevExpress.XtraGrid.Columns.GridColumn colLegacyName;
        private DevExpress.XtraGrid.Columns.GridColumn colNewPropertyName;
    }
}

