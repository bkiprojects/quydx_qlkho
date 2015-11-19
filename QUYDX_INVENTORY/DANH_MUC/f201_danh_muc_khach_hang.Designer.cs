namespace QUYDX_INVENTORY.DANH_MUC
{
    partial class f201_danh_muc_khach_hang
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
            this.iVT_Ver01DataSet = new QUYDX_INVENTORY.IVT_Ver01DataSet();
            this.iVTVer01DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iVT_Ver01DataSet3 = new QUYDX_INVENTORY.IVT_Ver01DataSet3();
            this.dMKHACHHANGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dM_KHACH_HANGTableAdapter = new QUYDX_INVENTORY.IVT_Ver01DataSet3TableAdapters.DM_KHACH_HANGTableAdapter();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMA_KHACH_HANG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN_KHACH_HANG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIA_CHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEMAIL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsDeleted = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iVT_Ver01DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iVTVer01DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iVT_Ver01DataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMKHACHHANGBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.DataSource = this.dMKHACHHANGBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(670, 404);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colMA_KHACH_HANG,
            this.colTEN_KHACH_HANG,
            this.colDIA_CHI,
            this.colSDT,
            this.colEMAIL,
            this.colIsDeleted});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // iVT_Ver01DataSet
            // 
            this.iVT_Ver01DataSet.DataSetName = "IVT_Ver01DataSet";
            this.iVT_Ver01DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iVTVer01DataSetBindingSource
            // 
            this.iVTVer01DataSetBindingSource.DataSource = this.iVT_Ver01DataSet;
            this.iVTVer01DataSetBindingSource.Position = 0;
            // 
            // iVT_Ver01DataSet3
            // 
            this.iVT_Ver01DataSet3.DataSetName = "IVT_Ver01DataSet3";
            this.iVT_Ver01DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dMKHACHHANGBindingSource
            // 
            this.dMKHACHHANGBindingSource.DataMember = "DM_KHACH_HANG";
            this.dMKHACHHANGBindingSource.DataSource = this.iVT_Ver01DataSet3;
            // 
            // dM_KHACH_HANGTableAdapter
            // 
            this.dM_KHACH_HANGTableAdapter.ClearBeforeFill = true;
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.OptionsColumn.ReadOnly = true;
            // 
            // colMA_KHACH_HANG
            // 
            this.colMA_KHACH_HANG.Caption = "Mã khách hàng";
            this.colMA_KHACH_HANG.FieldName = "MA_KHACH_HANG";
            this.colMA_KHACH_HANG.Name = "colMA_KHACH_HANG";
            this.colMA_KHACH_HANG.Visible = true;
            this.colMA_KHACH_HANG.VisibleIndex = 0;
            this.colMA_KHACH_HANG.Width = 88;
            // 
            // colTEN_KHACH_HANG
            // 
            this.colTEN_KHACH_HANG.Caption = "Tên khách hàng";
            this.colTEN_KHACH_HANG.FieldName = "TEN_KHACH_HANG";
            this.colTEN_KHACH_HANG.Name = "colTEN_KHACH_HANG";
            this.colTEN_KHACH_HANG.Visible = true;
            this.colTEN_KHACH_HANG.VisibleIndex = 1;
            this.colTEN_KHACH_HANG.Width = 139;
            // 
            // colDIA_CHI
            // 
            this.colDIA_CHI.Caption = "Địa chỉ";
            this.colDIA_CHI.FieldName = "DIA_CHI";
            this.colDIA_CHI.Name = "colDIA_CHI";
            this.colDIA_CHI.Visible = true;
            this.colDIA_CHI.VisibleIndex = 2;
            this.colDIA_CHI.Width = 139;
            // 
            // colSDT
            // 
            this.colSDT.FieldName = "SDT";
            this.colSDT.Name = "colSDT";
            this.colSDT.Visible = true;
            this.colSDT.VisibleIndex = 3;
            this.colSDT.Width = 139;
            // 
            // colEMAIL
            // 
            this.colEMAIL.FieldName = "EMAIL";
            this.colEMAIL.Name = "colEMAIL";
            this.colEMAIL.Visible = true;
            this.colEMAIL.VisibleIndex = 4;
            this.colEMAIL.Width = 147;
            // 
            // colIsDeleted
            // 
            this.colIsDeleted.FieldName = "IsDeleted";
            this.colIsDeleted.Name = "colIsDeleted";
            // 
            // f201_danh_muc_khach_hang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 404);
            this.Controls.Add(this.gridControl1);
            this.Name = "f201_danh_muc_khach_hang";
            this.Text = "F201 - Danh mục khách hàng";
            this.Load += new System.EventHandler(this.f201_danh_muc_khach_hang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iVT_Ver01DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iVTVer01DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iVT_Ver01DataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMKHACHHANGBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource iVTVer01DataSetBindingSource;
        private IVT_Ver01DataSet iVT_Ver01DataSet;
        private IVT_Ver01DataSet3 iVT_Ver01DataSet3;
        private System.Windows.Forms.BindingSource dMKHACHHANGBindingSource;
        private IVT_Ver01DataSet3TableAdapters.DM_KHACH_HANGTableAdapter dM_KHACH_HANGTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colMA_KHACH_HANG;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN_KHACH_HANG;
        private DevExpress.XtraGrid.Columns.GridColumn colDIA_CHI;
        private DevExpress.XtraGrid.Columns.GridColumn colSDT;
        private DevExpress.XtraGrid.Columns.GridColumn colEMAIL;
        private DevExpress.XtraGrid.Columns.GridColumn colIsDeleted;
    }
}