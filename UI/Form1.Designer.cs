namespace UI
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
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiAdd = new DevExpress.XtraBars.BarButtonItem();
            this.bbiEdit = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDelete = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gcEmployee = new DevExpress.XtraGrid.GridControl();
            this.vwEmployeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fTPAppDataSet = new UI.FTPAppDataSet();
            this.gvEmployee = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colEmployeeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFirstName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrefix = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCityId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatesId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProvinceId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepartmentId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDesignationId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCityName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatesName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProvinceName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepartmentName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDesignationName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHomeNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMobileNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBirthDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHireDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmployeeProfile = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.fTPAppDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vw_EmployeeTableAdapter = new UI.FTPAppDataSetTableAdapters.vw_EmployeeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwEmployeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fTPAppDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fTPAppDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.bbiAdd,
            this.bbiEdit,
            this.bbiDelete});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 5;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(854, 158);
            // 
            // bbiAdd
            // 
            this.bbiAdd.Caption = "Add";
            this.bbiAdd.Id = 1;
            this.bbiAdd.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiAdd.ImageOptions.SvgImage")));
            this.bbiAdd.Name = "bbiAdd";
            this.bbiAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiAdd_ItemClick);
            // 
            // bbiEdit
            // 
            this.bbiEdit.Caption = "Edit";
            this.bbiEdit.Id = 2;
            this.bbiEdit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiEdit.ImageOptions.SvgImage")));
            this.bbiEdit.Name = "bbiEdit";
            // 
            // bbiDelete
            // 
            this.bbiDelete.Caption = "Delete";
            this.bbiDelete.Id = 3;
            this.bbiDelete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiDelete.ImageOptions.SvgImage")));
            this.bbiDelete.Name = "bbiDelete";
            this.bbiDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiDelete_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiAdd);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiEdit);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiDelete);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gcEmployee);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 158);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(732, 110, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(854, 387);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gcEmployee
            // 
            this.gcEmployee.DataSource = this.vwEmployeeBindingSource;
            this.gcEmployee.Location = new System.Drawing.Point(12, 12);
            this.gcEmployee.MainView = this.gvEmployee;
            this.gcEmployee.MenuManager = this.ribbonControl1;
            this.gcEmployee.Name = "gcEmployee";
            this.gcEmployee.Size = new System.Drawing.Size(830, 363);
            this.gcEmployee.TabIndex = 4;
            this.gcEmployee.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvEmployee});
            // 
            // vwEmployeeBindingSource
            // 
            this.vwEmployeeBindingSource.DataMember = "vw_Employee";
            this.vwEmployeeBindingSource.DataSource = this.fTPAppDataSet;
            // 
            // fTPAppDataSet
            // 
            this.fTPAppDataSet.DataSetName = "FTPAppDataSet";
            this.fTPAppDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gvEmployee
            // 
            this.gvEmployee.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colEmployeeID,
            this.colFullName,
            this.colFirstName,
            this.colLastName,
            this.colPrefix,
            this.colStatus,
            this.colAddress,
            this.colCityId,
            this.colStatesId,
            this.colProvinceId,
            this.colDepartmentId,
            this.colDesignationId,
            this.colCityName,
            this.colStatesName,
            this.colProvinceName,
            this.colDepartmentName,
            this.colDesignationName,
            this.colHomeNumber,
            this.colMobileNumber,
            this.colEmail,
            this.colBirthDate,
            this.colHireDate,
            this.colEmployeeProfile});
            this.gvEmployee.GridControl = this.gcEmployee;
            this.gvEmployee.Name = "gvEmployee";
            this.gvEmployee.OptionsBehavior.Editable = false;
            this.gvEmployee.OptionsBehavior.ReadOnly = true;
            this.gvEmployee.Click += new System.EventHandler(this.gvEmployee_Click);
            // 
            // colEmployeeID
            // 
            this.colEmployeeID.FieldName = "EmployeeID";
            this.colEmployeeID.Name = "colEmployeeID";
            this.colEmployeeID.Visible = true;
            this.colEmployeeID.VisibleIndex = 0;
            // 
            // colFullName
            // 
            this.colFullName.FieldName = "FullName";
            this.colFullName.Name = "colFullName";
            this.colFullName.Visible = true;
            this.colFullName.VisibleIndex = 1;
            // 
            // colFirstName
            // 
            this.colFirstName.FieldName = "FirstName";
            this.colFirstName.Name = "colFirstName";
            this.colFirstName.Visible = true;
            this.colFirstName.VisibleIndex = 2;
            // 
            // colLastName
            // 
            this.colLastName.FieldName = "LastName";
            this.colLastName.Name = "colLastName";
            this.colLastName.Visible = true;
            this.colLastName.VisibleIndex = 3;
            // 
            // colPrefix
            // 
            this.colPrefix.FieldName = "Prefix";
            this.colPrefix.Name = "colPrefix";
            this.colPrefix.Visible = true;
            this.colPrefix.VisibleIndex = 4;
            // 
            // colStatus
            // 
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 5;
            // 
            // colAddress
            // 
            this.colAddress.FieldName = "Address";
            this.colAddress.Name = "colAddress";
            this.colAddress.Visible = true;
            this.colAddress.VisibleIndex = 6;
            // 
            // colCityId
            // 
            this.colCityId.FieldName = "CityId";
            this.colCityId.Name = "colCityId";
            this.colCityId.Visible = true;
            this.colCityId.VisibleIndex = 7;
            // 
            // colStatesId
            // 
            this.colStatesId.FieldName = "StatesId";
            this.colStatesId.Name = "colStatesId";
            this.colStatesId.Visible = true;
            this.colStatesId.VisibleIndex = 8;
            // 
            // colProvinceId
            // 
            this.colProvinceId.FieldName = "ProvinceId";
            this.colProvinceId.Name = "colProvinceId";
            this.colProvinceId.Visible = true;
            this.colProvinceId.VisibleIndex = 9;
            // 
            // colDepartmentId
            // 
            this.colDepartmentId.FieldName = "DepartmentId";
            this.colDepartmentId.Name = "colDepartmentId";
            this.colDepartmentId.Visible = true;
            this.colDepartmentId.VisibleIndex = 10;
            // 
            // colDesignationId
            // 
            this.colDesignationId.FieldName = "DesignationId";
            this.colDesignationId.Name = "colDesignationId";
            this.colDesignationId.Visible = true;
            this.colDesignationId.VisibleIndex = 11;
            // 
            // colCityName
            // 
            this.colCityName.FieldName = "CityName";
            this.colCityName.Name = "colCityName";
            this.colCityName.Visible = true;
            this.colCityName.VisibleIndex = 12;
            // 
            // colStatesName
            // 
            this.colStatesName.FieldName = "StatesName";
            this.colStatesName.Name = "colStatesName";
            this.colStatesName.Visible = true;
            this.colStatesName.VisibleIndex = 13;
            // 
            // colProvinceName
            // 
            this.colProvinceName.FieldName = "ProvinceName";
            this.colProvinceName.Name = "colProvinceName";
            this.colProvinceName.Visible = true;
            this.colProvinceName.VisibleIndex = 14;
            // 
            // colDepartmentName
            // 
            this.colDepartmentName.FieldName = "DepartmentName";
            this.colDepartmentName.Name = "colDepartmentName";
            this.colDepartmentName.Visible = true;
            this.colDepartmentName.VisibleIndex = 15;
            // 
            // colDesignationName
            // 
            this.colDesignationName.FieldName = "DesignationName";
            this.colDesignationName.Name = "colDesignationName";
            this.colDesignationName.Visible = true;
            this.colDesignationName.VisibleIndex = 16;
            // 
            // colHomeNumber
            // 
            this.colHomeNumber.FieldName = "HomeNumber";
            this.colHomeNumber.Name = "colHomeNumber";
            this.colHomeNumber.Visible = true;
            this.colHomeNumber.VisibleIndex = 17;
            // 
            // colMobileNumber
            // 
            this.colMobileNumber.FieldName = "MobileNumber";
            this.colMobileNumber.Name = "colMobileNumber";
            this.colMobileNumber.Visible = true;
            this.colMobileNumber.VisibleIndex = 18;
            // 
            // colEmail
            // 
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 19;
            // 
            // colBirthDate
            // 
            this.colBirthDate.FieldName = "BirthDate";
            this.colBirthDate.Name = "colBirthDate";
            this.colBirthDate.Visible = true;
            this.colBirthDate.VisibleIndex = 20;
            // 
            // colHireDate
            // 
            this.colHireDate.FieldName = "HireDate";
            this.colHireDate.Name = "colHireDate";
            this.colHireDate.Visible = true;
            this.colHireDate.VisibleIndex = 21;
            // 
            // colEmployeeProfile
            // 
            this.colEmployeeProfile.FieldName = "EmployeeProfile";
            this.colEmployeeProfile.Name = "colEmployeeProfile";
            this.colEmployeeProfile.Visible = true;
            this.colEmployeeProfile.VisibleIndex = 22;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(854, 387);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gcEmployee;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(834, 367);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // fTPAppDataSetBindingSource
            // 
            this.fTPAppDataSetBindingSource.DataSource = this.fTPAppDataSet;
            this.fTPAppDataSetBindingSource.Position = 0;
            // 
            // vw_EmployeeTableAdapter
            // 
            this.vw_EmployeeTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 545);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "Form1";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwEmployeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fTPAppDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fTPAppDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl gcEmployee;
        private DevExpress.XtraGrid.Views.Grid.GridView gvEmployee;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.BindingSource fTPAppDataSetBindingSource;
        private FTPAppDataSet fTPAppDataSet;
        private System.Windows.Forms.BindingSource vwEmployeeBindingSource;
        private FTPAppDataSetTableAdapters.vw_EmployeeTableAdapter vw_EmployeeTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeID;
        private DevExpress.XtraGrid.Columns.GridColumn colFullName;
        private DevExpress.XtraGrid.Columns.GridColumn colFirstName;
        private DevExpress.XtraGrid.Columns.GridColumn colLastName;
        private DevExpress.XtraGrid.Columns.GridColumn colPrefix;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colCityId;
        private DevExpress.XtraGrid.Columns.GridColumn colStatesId;
        private DevExpress.XtraGrid.Columns.GridColumn colProvinceId;
        private DevExpress.XtraGrid.Columns.GridColumn colDepartmentId;
        private DevExpress.XtraGrid.Columns.GridColumn colDesignationId;
        private DevExpress.XtraGrid.Columns.GridColumn colCityName;
        private DevExpress.XtraGrid.Columns.GridColumn colStatesName;
        private DevExpress.XtraGrid.Columns.GridColumn colProvinceName;
        private DevExpress.XtraGrid.Columns.GridColumn colDepartmentName;
        private DevExpress.XtraGrid.Columns.GridColumn colDesignationName;
        private DevExpress.XtraGrid.Columns.GridColumn colHomeNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colMobileNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colBirthDate;
        private DevExpress.XtraGrid.Columns.GridColumn colHireDate;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeProfile;
        private DevExpress.XtraBars.BarButtonItem bbiAdd;
        private DevExpress.XtraBars.BarButtonItem bbiEdit;
        private DevExpress.XtraBars.BarButtonItem bbiDelete;
    }
}

