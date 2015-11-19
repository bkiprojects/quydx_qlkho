namespace QUYDX_INVENTORY.DANH_MUC
{
    partial class f203_danh_muc_mat_hang
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
            if(disposing && (components != null))
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.iVT_Ver01DataSet2 = new QUYDX_INVENTORY.IVT_Ver01DataSet2();
            this.dMMATHANGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dM_MAT_HANGTableAdapter = new QUYDX_INVENTORY.IVT_Ver01DataSet2TableAdapters.DM_MAT_HANGTableAdapter();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN_MAT_HANG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsDeleted = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGIA_XUAT_DE_XUAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGIA_NHAP_DE_XUAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTHOI_GIAN_BAO_HANH_DE_XUAT = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iVT_Ver01DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMMATHANGBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.DataSource = this.dMMATHANGBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(534, 388);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colTEN_MAT_HANG,
            this.colIsDeleted,
            this.colGIA_XUAT_DE_XUAT,
            this.colGIA_NHAP_DE_XUAT,
            this.colTHOI_GIAN_BAO_HANH_DE_XUAT});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // iVT_Ver01DataSet2
            // 
            this.iVT_Ver01DataSet2.DataSetName = "IVT_Ver01DataSet2";
            this.iVT_Ver01DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dMMATHANGBindingSource
            // 
            this.dMMATHANGBindingSource.DataMember = "DM_MAT_HANG";
            this.dMMATHANGBindingSource.DataSource = this.iVT_Ver01DataSet2;
            // 
            // dM_MAT_HANGTableAdapter
            // 
            this.dM_MAT_HANGTableAdapter.ClearBeforeFill = true;
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.OptionsColumn.ReadOnly = true;
            // 
            // colTEN_MAT_HANG
            // 
            this.colTEN_MAT_HANG.Caption = "Tên mặt hàng";
            this.colTEN_MAT_HANG.FieldName = "TEN_MAT_HANG";
            this.colTEN_MAT_HANG.Name = "colTEN_MAT_HANG";
            this.colTEN_MAT_HANG.Visible = true;
            this.colTEN_MAT_HANG.VisibleIndex = 0;
            this.colTEN_MAT_HANG.Width = 166;
            // 
            // colIsDeleted
            // 
            this.colIsDeleted.FieldName = "IsDeleted";
            this.colIsDeleted.Name = "colIsDeleted";
            // 
            // colGIA_XUAT_DE_XUAT
            // 
            this.colGIA_XUAT_DE_XUAT.Caption = "Giá xuất đề xuất";
            this.colGIA_XUAT_DE_XUAT.DisplayFormat.FormatString = "n0";
            this.colGIA_XUAT_DE_XUAT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colGIA_XUAT_DE_XUAT.FieldName = "GIA_XUAT_DE_XUAT";
            this.colGIA_XUAT_DE_XUAT.Name = "colGIA_XUAT_DE_XUAT";
            this.colGIA_XUAT_DE_XUAT.Visible = true;
            this.colGIA_XUAT_DE_XUAT.VisibleIndex = 1;
            // 
            // colGIA_NHAP_DE_XUAT
            // 
            this.colGIA_NHAP_DE_XUAT.Caption = "Giá nhập đề xuất";
            this.colGIA_NHAP_DE_XUAT.DisplayFormat.FormatString = "n0";
            this.colGIA_NHAP_DE_XUAT.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colGIA_NHAP_DE_XUAT.FieldName = "GIA_NHAP_DE_XUAT";
            this.colGIA_NHAP_DE_XUAT.Name = "colGIA_NHAP_DE_XUAT";
            this.colGIA_NHAP_DE_XUAT.Visible = true;
            this.colGIA_NHAP_DE_XUAT.VisibleIndex = 2;
            // 
            // colTHOI_GIAN_BAO_HANH_DE_XUAT
            // 
            this.colTHOI_GIAN_BAO_HANH_DE_XUAT.Caption = "Thời gian bảo hành (tháng)";
            this.colTHOI_GIAN_BAO_HANH_DE_XUAT.FieldName = "THOI_GIAN_BAO_HANH_DE_XUAT";
            this.colTHOI_GIAN_BAO_HANH_DE_XUAT.Name = "colTHOI_GIAN_BAO_HANH_DE_XUAT";
            this.colTHOI_GIAN_BAO_HANH_DE_XUAT.Visible = true;
            this.colTHOI_GIAN_BAO_HANH_DE_XUAT.VisibleIndex = 3;
            this.colTHOI_GIAN_BAO_HANH_DE_XUAT.Width = 82;
            // 
            // f203_danh_muc_mat_hang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 388);
            this.Controls.Add(this.gridControl1);
            this.Name = "f203_danh_muc_mat_hang";
            this.Text = "F203 - Danh mục mặt hàng";
            this.Load += new System.EventHandler(this.f203_danh_muc_mat_hang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iVT_Ver01DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMMATHANGBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private IVT_Ver01DataSet2 iVT_Ver01DataSet2;
        private System.Windows.Forms.BindingSource dMMATHANGBindingSource;
        private IVT_Ver01DataSet2TableAdapters.DM_MAT_HANGTableAdapter dM_MAT_HANGTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN_MAT_HANG;
        private DevExpress.XtraGrid.Columns.GridColumn colIsDeleted;
        private DevExpress.XtraGrid.Columns.GridColumn colGIA_XUAT_DE_XUAT;
        private DevExpress.XtraGrid.Columns.GridColumn colGIA_NHAP_DE_XUAT;
        private DevExpress.XtraGrid.Columns.GridColumn colTHOI_GIAN_BAO_HANH_DE_XUAT;
    }
}