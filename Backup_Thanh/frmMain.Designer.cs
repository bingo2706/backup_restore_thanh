
namespace Backup_Thanh
{
    partial class frmMain
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
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnSaoLuu = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnThamSoThoiGian = new DevExpress.XtraBars.BarCheckItem();
            this.btnTaoDevice = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.databaseNameGridControl = new DevExpress.XtraGrid.GridControl();
            this.bdsListDatabase = new System.Windows.Forms.BindingSource(this.components);
            this.tempdbDataSet = new Backup_Thanh.tempdbDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl5 = new DevExpress.XtraEditors.PanelControl();
            this.dtptTimeStop = new System.Windows.Forms.DateTimePicker();
            this.txtInfoPhucHoi = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblinfo = new System.Windows.Forms.Label();
            this.ckiNit = new System.Windows.Forms.CheckBox();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.PrgLoad = new System.Windows.Forms.ProgressBar();
            this.dataTable1GridControl = new DevExpress.XtraGrid.GridControl();
            this.bdsBackup = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colbackup_set_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colposition = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbackup_start_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coluser_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.txbTenDevice = new System.Windows.Forms.TextBox();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbTenDB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.databaseNameTableAdapter = new Backup_Thanh.tempdbDataSetTableAdapters.databaseNameTableAdapter();
            this.tableAdapterManager = new Backup_Thanh.tempdbDataSetTableAdapters.TableAdapterManager();
            this.bdsDevice = new System.Windows.Forms.BindingSource(this.components);
            this.backup_devicesTableAdapter = new Backup_Thanh.tempdbDataSetTableAdapters.backup_devicesTableAdapter();
            this.process1 = new System.Diagnostics.Process();
            this.dataTable1TableAdapter = new Backup_Thanh.tempdbDataSetTableAdapters.DataTable1TableAdapter();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.databaseNameGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsListDatabase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempdbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).BeginInit();
            this.panelControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1GridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBackup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDevice)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(479, 12);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(74, 17);
            nameLabel.TabIndex = 5;
            nameLabel.Text = "Tên device";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.barButtonItem2,
            this.btnSaoLuu,
            this.btnPhucHoi,
            this.btnThamSoThoiGian,
            this.btnTaoDevice,
            this.btnThoat});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 7;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Tools";
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSaoLuu),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnPhucHoi),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThamSoThoiGian),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnTaoDevice),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThoat)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnSaoLuu
            // 
            this.btnSaoLuu.Caption = "Sao lưu";
            this.btnSaoLuu.Id = 2;
            this.btnSaoLuu.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSaoLuu.ImageOptions.SvgImage")));
            this.btnSaoLuu.Name = "btnSaoLuu";
            this.btnSaoLuu.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnSaoLuu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSaoLuu_ItemClick);
            // 
            // btnPhucHoi
            // 
            this.btnPhucHoi.Caption = "Phục hồi";
            this.btnPhucHoi.Id = 3;
            this.btnPhucHoi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPhucHoi.ImageOptions.SvgImage")));
            this.btnPhucHoi.Name = "btnPhucHoi";
            this.btnPhucHoi.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnPhucHoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhucHoi_ItemClick);
            // 
            // btnThamSoThoiGian
            // 
            this.btnThamSoThoiGian.Caption = "Tham số theo thời gian";
            this.btnThamSoThoiGian.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
            this.btnThamSoThoiGian.Id = 4;
            this.btnThamSoThoiGian.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThamSoThoiGian.ImageOptions.SvgImage")));
            this.btnThamSoThoiGian.Name = "btnThamSoThoiGian";
            this.btnThamSoThoiGian.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnThamSoThoiGian.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThamSoThoiGian_CheckedChanged);
            // 
            // btnTaoDevice
            // 
            this.btnTaoDevice.Caption = "Tạo device sao lưu";
            this.btnTaoDevice.Id = 5;
            this.btnTaoDevice.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTaoDevice.ImageOptions.SvgImage")));
            this.btnTaoDevice.Name = "btnTaoDevice";
            this.btnTaoDevice.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnTaoDevice.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTaoDevice_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 6;
            this.btnThoat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThoat.ImageOptions.SvgImage")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1180, 51);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 632);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1180, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 51);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 581);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1180, 51);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 581);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "SAO LƯU";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem1.ImageOptions.SvgImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "PHỤC HỒI";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem2.ImageOptions.SvgImage")));
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.databaseNameGridControl);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 51);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(260, 581);
            this.panelControl1.TabIndex = 5;
            // 
            // databaseNameGridControl
            // 
            this.databaseNameGridControl.DataSource = this.bdsListDatabase;
            this.databaseNameGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.databaseNameGridControl.Location = new System.Drawing.Point(2, 2);
            this.databaseNameGridControl.MainView = this.gridView1;
            this.databaseNameGridControl.MenuManager = this.barManager1;
            this.databaseNameGridControl.Name = "databaseNameGridControl";
            this.databaseNameGridControl.Size = new System.Drawing.Size(256, 577);
            this.databaseNameGridControl.TabIndex = 0;
            this.databaseNameGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // bdsListDatabase
            // 
            this.bdsListDatabase.DataMember = "databaseName";
            this.bdsListDatabase.DataSource = this.tempdbDataSet;
            // 
            // tempdbDataSet
            // 
            this.tempdbDataSet.DataSetName = "tempdbDataSet";
            this.tempdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colname});
            this.gridView1.GridControl = this.databaseNameGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            // 
            // colname
            // 
            this.colname.Caption = "Danh sách cơ sở dữ liệu";
            this.colname.FieldName = "name";
            this.colname.MinWidth = 25;
            this.colname.Name = "colname";
            this.colname.Visible = true;
            this.colname.VisibleIndex = 0;
            this.colname.Width = 94;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.panelControl5);
            this.panelControl2.Controls.Add(this.panelControl4);
            this.panelControl2.Controls.Add(this.panelControl3);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(260, 51);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(920, 581);
            this.panelControl2.TabIndex = 6;
            // 
            // panelControl5
            // 
            this.panelControl5.Controls.Add(this.dtptTimeStop);
            this.panelControl5.Controls.Add(this.txtInfoPhucHoi);
            this.panelControl5.Controls.Add(this.dtpDate);
            this.panelControl5.Controls.Add(this.lblinfo);
            this.panelControl5.Controls.Add(this.ckiNit);
            this.panelControl5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl5.Location = new System.Drawing.Point(2, 404);
            this.panelControl5.Name = "panelControl5";
            this.panelControl5.Size = new System.Drawing.Size(916, 175);
            this.panelControl5.TabIndex = 2;
            // 
            // dtptTimeStop
            // 
            this.dtptTimeStop.CustomFormat = "HH:mm:ss";
            this.dtptTimeStop.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtptTimeStop.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtptTimeStop.Location = new System.Drawing.Point(565, 23);
            this.dtptTimeStop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtptTimeStop.Name = "dtptTimeStop";
            this.dtptTimeStop.ShowUpDown = true;
            this.dtptTimeStop.Size = new System.Drawing.Size(121, 23);
            this.dtptTimeStop.TabIndex = 72;
            this.dtptTimeStop.Visible = false;
            this.dtptTimeStop.ValueChanged += new System.EventHandler(this.dtptTimeStop_ValueChanged);
            // 
            // txtInfoPhucHoi
            // 
            this.txtInfoPhucHoi.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInfoPhucHoi.Location = new System.Drawing.Point(83, 57);
            this.txtInfoPhucHoi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtInfoPhucHoi.Multiline = true;
            this.txtInfoPhucHoi.Name = "txtInfoPhucHoi";
            this.txtInfoPhucHoi.Size = new System.Drawing.Size(572, 116);
            this.txtInfoPhucHoi.TabIndex = 71;
            this.txtInfoPhucHoi.Text = resources.GetString("txtInfoPhucHoi.Text");
            this.txtInfoPhucHoi.Visible = false;
            this.txtInfoPhucHoi.TextChanged += new System.EventHandler(this.txtInfoPhucHoi_TextChanged);
            // 
            // dtpDate
            // 
            this.dtpDate.Checked = false;
            this.dtpDate.CustomFormat = "yyyy-MM-dd";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(356, 23);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(170, 23);
            this.dtpDate.TabIndex = 70;
            this.dtpDate.Visible = false;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // lblinfo
            // 
            this.lblinfo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinfo.Location = new System.Drawing.Point(79, 25);
            this.lblinfo.Name = "lblinfo";
            this.lblinfo.Size = new System.Drawing.Size(268, 31);
            this.lblinfo.TabIndex = 69;
            this.lblinfo.Text = "Ngày giờ phục hồi tới thời điểm đó";
            this.lblinfo.Visible = false;
            // 
            // ckiNit
            // 
            this.ckiNit.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckiNit.Location = new System.Drawing.Point(232, 28);
            this.ckiNit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ckiNit.Name = "ckiNit";
            this.ckiNit.Size = new System.Drawing.Size(230, 21);
            this.ckiNit.TabIndex = 68;
            this.ckiNit.Text = "Xóa tất cả các bản sao lưu trước đó";
            this.ckiNit.UseVisualStyleBackColor = true;
            this.ckiNit.CheckedChanged += new System.EventHandler(this.ckiNit_CheckedChanged);
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.PrgLoad);
            this.panelControl4.Controls.Add(this.dataTable1GridControl);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl4.Location = new System.Drawing.Point(2, 54);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(916, 350);
            this.panelControl4.TabIndex = 1;
            // 
            // PrgLoad
            // 
            this.PrgLoad.Location = new System.Drawing.Point(254, 28);
            this.PrgLoad.Name = "PrgLoad";
            this.PrgLoad.Size = new System.Drawing.Size(289, 30);
            this.PrgLoad.TabIndex = 1;
            // 
            // dataTable1GridControl
            // 
            this.dataTable1GridControl.DataSource = this.bdsBackup;
            this.dataTable1GridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataTable1GridControl.Location = new System.Drawing.Point(2, 2);
            this.dataTable1GridControl.MainView = this.gridView2;
            this.dataTable1GridControl.MenuManager = this.barManager1;
            this.dataTable1GridControl.Name = "dataTable1GridControl";
            this.dataTable1GridControl.Size = new System.Drawing.Size(912, 346);
            this.dataTable1GridControl.TabIndex = 0;
            this.dataTable1GridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // bdsBackup
            // 
            this.bdsBackup.DataMember = "DataTable1";
            this.bdsBackup.DataSource = this.tempdbDataSet;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colbackup_set_id,
            this.colposition,
            this.coldescription,
            this.colbackup_start_date,
            this.coluser_name});
            this.gridView2.GridControl = this.dataTable1GridControl;
            this.gridView2.Name = "gridView2";
            this.gridView2.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView2_RowClick_1);
            // 
            // colbackup_set_id
            // 
            this.colbackup_set_id.Caption = "Mã số";
            this.colbackup_set_id.FieldName = "backup_set_id";
            this.colbackup_set_id.MinWidth = 25;
            this.colbackup_set_id.Name = "colbackup_set_id";
            this.colbackup_set_id.Visible = true;
            this.colbackup_set_id.VisibleIndex = 0;
            this.colbackup_set_id.Width = 94;
            // 
            // colposition
            // 
            this.colposition.Caption = "Bản sao lưu thứ #";
            this.colposition.FieldName = "position";
            this.colposition.MinWidth = 25;
            this.colposition.Name = "colposition";
            this.colposition.Visible = true;
            this.colposition.VisibleIndex = 1;
            this.colposition.Width = 94;
            // 
            // coldescription
            // 
            this.coldescription.Caption = "Diễn giải";
            this.coldescription.FieldName = "description";
            this.coldescription.MinWidth = 25;
            this.coldescription.Name = "coldescription";
            this.coldescription.Visible = true;
            this.coldescription.VisibleIndex = 2;
            this.coldescription.Width = 94;
            // 
            // colbackup_start_date
            // 
            this.colbackup_start_date.Caption = "Ngày giờ sao lưu";
            this.colbackup_start_date.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.colbackup_start_date.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colbackup_start_date.FieldName = "backup_start_date";
            this.colbackup_start_date.MinWidth = 25;
            this.colbackup_start_date.Name = "colbackup_start_date";
            this.colbackup_start_date.Visible = true;
            this.colbackup_start_date.VisibleIndex = 3;
            this.colbackup_start_date.Width = 94;
            // 
            // coluser_name
            // 
            this.coluser_name.Caption = "Tên user";
            this.coluser_name.FieldName = "user_name";
            this.coluser_name.MinWidth = 25;
            this.coluser_name.Name = "coluser_name";
            this.coluser_name.Visible = true;
            this.coluser_name.VisibleIndex = 4;
            this.coluser_name.Width = 94;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.txbTenDevice);
            this.panelControl3.Controls.Add(nameLabel);
            this.panelControl3.Controls.Add(this.txtSL);
            this.panelControl3.Controls.Add(this.label2);
            this.panelControl3.Controls.Add(this.txbTenDB);
            this.panelControl3.Controls.Add(this.label1);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl3.Location = new System.Drawing.Point(2, 2);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(916, 52);
            this.panelControl3.TabIndex = 0;
            // 
            // txbTenDevice
            // 
            this.txbTenDevice.Location = new System.Drawing.Point(559, 9);
            this.txbTenDevice.Name = "txbTenDevice";
            this.txbTenDevice.ReadOnly = true;
            this.txbTenDevice.Size = new System.Drawing.Size(232, 23);
            this.txbTenDevice.TabIndex = 6;
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(414, 9);
            this.txtSL.Name = "txtSL";
            this.txtSL.ReadOnly = true;
            this.txtSL.Size = new System.Drawing.Size(48, 23);
            this.txtSL.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(345, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số lượng";
            // 
            // txbTenDB
            // 
            this.txbTenDB.Location = new System.Drawing.Point(133, 9);
            this.txbTenDB.Name = "txbTenDB";
            this.txbTenDB.ReadOnly = true;
            this.txbTenDB.Size = new System.Drawing.Size(206, 23);
            this.txbTenDB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên cơ sở dữ liệu";
            // 
            // databaseNameTableAdapter
            // 
            this.databaseNameTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.DataTable1TableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Backup_Thanh.tempdbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bdsDevice
            // 
            this.bdsDevice.DataMember = "backup_devices";
            this.bdsDevice.DataSource = this.tempdbDataSet;
            // 
            // backup_devicesTableAdapter
            // 
            this.backup_devicesTableAdapter.ClearBeforeFill = true;
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            // 
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xóaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(211, 56);
            // 
            // xóaToolStripMenuItem
            // 
            this.xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            this.xóaToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.xóaToolStripMenuItem.Text = "Xóa";
            this.xóaToolStripMenuItem.Click += new System.EventHandler(this.xóaToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 652);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm sao lưu - phục hồi cơ sở dữ liệu 2022";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.databaseNameGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsListDatabase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempdbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).EndInit();
            this.panelControl5.ResumeLayout(false);
            this.panelControl5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1GridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsBackup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDevice)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnSaoLuu;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoi;
        private DevExpress.XtraBars.BarCheckItem btnThamSoThoiGian;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem btnTaoDevice;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbTenDB;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.PanelControl panelControl5;
        private System.Windows.Forms.DateTimePicker dtptTimeStop;
        private System.Windows.Forms.TextBox txtInfoPhucHoi;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblinfo;
        private System.Windows.Forms.CheckBox ckiNit;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private System.Windows.Forms.BindingSource bdsListDatabase;
        private tempdbDataSet tempdbDataSet;
        private tempdbDataSetTableAdapters.databaseNameTableAdapter databaseNameTableAdapter;
        private tempdbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl databaseNameGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colname;
        private System.Windows.Forms.BindingSource bdsDevice;
        private tempdbDataSetTableAdapters.backup_devicesTableAdapter backup_devicesTableAdapter;
        private System.Windows.Forms.TextBox txbTenDevice;
        private System.Diagnostics.Process process1;
        private System.Windows.Forms.ProgressBar PrgLoad;
        private System.Windows.Forms.BindingSource bdsBackup;
        private tempdbDataSetTableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
        private DevExpress.XtraGrid.GridControl dataTable1GridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colbackup_set_id;
        private DevExpress.XtraGrid.Columns.GridColumn colposition;
        private DevExpress.XtraGrid.Columns.GridColumn coldescription;
        private DevExpress.XtraGrid.Columns.GridColumn colbackup_start_date;
        private DevExpress.XtraGrid.Columns.GridColumn coluser_name;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
    }
}