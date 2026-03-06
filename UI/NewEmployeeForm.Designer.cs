namespace UI
{
    partial class NewEmployeeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewEmployeeForm));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.simpleButtonSave = new DevExpress.XtraEditors.SimpleButton();
            this.TxtFullName = new DevExpress.XtraEditors.TextEdit();
            this.TxtLastName = new DevExpress.XtraEditors.TextEdit();
            this.TxtFirstName = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciFirstName = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciLastName = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciFullName = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFullName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtLastName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFirstName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFirstName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLastName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFullName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.simpleButtonSave);
            this.layoutControl1.Controls.Add(this.TxtFullName);
            this.layoutControl1.Controls.Add(this.TxtLastName);
            this.layoutControl1.Controls.Add(this.TxtFirstName);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(791, 0, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(487, 120);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // simpleButtonSave
            // 
            this.simpleButtonSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButtonSave.ImageOptions.Image")));
            this.simpleButtonSave.Location = new System.Drawing.Point(380, 84);
            this.simpleButtonSave.Name = "simpleButtonSave";
            this.simpleButtonSave.Size = new System.Drawing.Size(95, 22);
            this.simpleButtonSave.StyleController = this.layoutControl1;
            this.simpleButtonSave.TabIndex = 7;
            this.simpleButtonSave.Text = "Save";
            this.simpleButtonSave.Click += new System.EventHandler(this.simpleButtonSave_Click);
            // 
            // TxtFullName
            // 
            this.TxtFullName.Location = new System.Drawing.Point(66, 60);
            this.TxtFullName.Name = "TxtFullName";
            this.TxtFullName.Size = new System.Drawing.Size(409, 20);
            this.TxtFullName.StyleController = this.layoutControl1;
            this.TxtFullName.TabIndex = 6;
            // 
            // TxtLastName
            // 
            this.TxtLastName.Location = new System.Drawing.Point(66, 36);
            this.TxtLastName.Name = "TxtLastName";
            this.TxtLastName.Size = new System.Drawing.Size(409, 20);
            this.TxtLastName.StyleController = this.layoutControl1;
            this.TxtLastName.TabIndex = 5;
            // 
            // TxtFirstName
            // 
            this.TxtFirstName.Location = new System.Drawing.Point(66, 12);
            this.TxtFirstName.Name = "TxtFirstName";
            this.TxtFirstName.Size = new System.Drawing.Size(409, 20);
            this.TxtFirstName.StyleController = this.layoutControl1;
            this.TxtFirstName.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciFirstName,
            this.lciLastName,
            this.lciFullName,
            this.emptySpaceItem1,
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(487, 120);
            this.Root.TextVisible = false;
            // 
            // lciFirstName
            // 
            this.lciFirstName.Control = this.TxtFirstName;
            this.lciFirstName.CustomizationFormText = "First Name";
            this.lciFirstName.Location = new System.Drawing.Point(0, 0);
            this.lciFirstName.Name = "lciFirstName";
            this.lciFirstName.Size = new System.Drawing.Size(467, 24);
            this.lciFirstName.Text = "First Name";
            this.lciFirstName.TextSize = new System.Drawing.Size(51, 13);
            // 
            // lciLastName
            // 
            this.lciLastName.Control = this.TxtLastName;
            this.lciLastName.Location = new System.Drawing.Point(0, 24);
            this.lciLastName.Name = "lciLastName";
            this.lciLastName.Size = new System.Drawing.Size(467, 24);
            this.lciLastName.Text = "Last Name";
            this.lciLastName.TextSize = new System.Drawing.Size(51, 13);
            // 
            // lciFullName
            // 
            this.lciFullName.Control = this.TxtFullName;
            this.lciFullName.CustomizationFormText = "Full Name";
            this.lciFullName.Location = new System.Drawing.Point(0, 48);
            this.lciFullName.Name = "lciFullName";
            this.lciFullName.Size = new System.Drawing.Size(467, 24);
            this.lciFullName.Text = "Full Name";
            this.lciFullName.TextSize = new System.Drawing.Size(51, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 72);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(368, 28);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.simpleButtonSave;
            this.layoutControlItem1.Location = new System.Drawing.Point(368, 72);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(99, 28);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // NewEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 120);
            this.Controls.Add(this.layoutControl1);
            this.Name = "NewEmployeeForm";
            this.Text = "NewEmployeeForm";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TxtFullName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtLastName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFirstName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFirstName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLastName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFullName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.TextEdit TxtFirstName;
        private DevExpress.XtraLayout.LayoutControlItem lciFirstName;
        private DevExpress.XtraEditors.TextEdit TxtLastName;
        private DevExpress.XtraLayout.LayoutControlItem lciLastName;
        private DevExpress.XtraEditors.TextEdit TxtFullName;
        private DevExpress.XtraLayout.LayoutControlItem lciFullName;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.SimpleButton simpleButtonSave;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    }
}