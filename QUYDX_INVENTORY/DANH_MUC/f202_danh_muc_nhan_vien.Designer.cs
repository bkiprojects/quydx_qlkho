namespace QUYDX_INVENTORY.DANH_MUC
{
    partial class f202_danh_muc_nhan_vien
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
            this.dMNHANVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dM_NHAN_VIENTableAdapter = new QUYDX_INVENTORY.IVT_Ver01DataSet2TableAdapters.DM_NHAN_VIENTableAdapter();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMA_NHAN_VIEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN_NHAN_VIEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCONG_VIEC_PHU_TRACH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsDeleted = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iVT_Ver01DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMNHANVIENBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.DataSource = this.dMNHANVIENBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(564, 407);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colMA_NHAN_VIEN,
            this.colTEN_NHAN_VIEN,
            this.colSDT,
            this.colCONG_VIEC_PHU_TRACH,
            this.colIsDeleted});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.PaintStyleName = "Flat";
            // 
            // iVT_Ver01DataSet2
            // 
            this.iVT_Ver01DataSet2.DataSetName = "IVT_Ver01DataSet2";
            this.iVT_Ver01DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dMNHANVIENBindingSource
            // 
            this.dMNHANVIENBindingSource.DataMember = "DM_NHAN_VIEN";
            this.dMNHANVIENBindingSource.DataSource = this.iVT_Ver01DataSet2;
            // 
            // dM_NHAN_VIENTableAdapter
            // 
            this.dM_NHAN_VIENTableAdapter.ClearBeforeFill = true;
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.OptionsColumn.ReadOnly = true;
            // 
            // colMA_NHAN_VIEN
            // 
            this.colMA_NHAN_VIEN.Caption = "Mã nhân viên";
            this.colMA_NHAN_VIEN.FieldName = "MA_NHAN_VIEN";
            this.colMA_NHAN_VIEN.Name = "colMA_NHAN_VIEN";
            this.colMA_NHAN_VIEN.Visible = true;
            this.colMA_NHAN_VIEN.VisibleIndex = 0;
            // 
            // colTEN_NHAN_VIEN
            // 
            this.colTEN_NHAN_VIEN.Caption = "Tên nhân viên";
            this.colTEN_NHAN_VIEN.FieldName = "TEN_NHAN_VIEN";
            this.colTEN_NHAN_VIEN.Name = "colTEN_NHAN_VIEN";
            this.colTEN_NHAN_VIEN.Visible = true;
            this.colTEN_NHAN_VIEN.VisibleIndex = 1;
            // 
            // colSDT
            // 
            this.colSDT.FieldName = "SDT";
            this.colSDT.Name = "colSDT";
            this.colSDT.Visible = true;
            this.colSDT.VisibleIndex = 3;
            // 
            // colCONG_VIEC_PHU_TRACH
            // 
            this.colCONG_VIEC_PHU_TRACH.Caption = "Công việc phụ trách";
            this.colCONG_VIEC_PHU_TRACH.FieldName = "CONG_VIEC_PHU_TRACH";
            this.colCONG_VIEC_PHU_TRACH.Name = "colCONG_VIEC_PHU_TRACH";
            this.colCONG_VIEC_PHU_TRACH.Visible = true;
            this.colCONG_VIEC_PHU_TRACH.VisibleIndex = 3;
            // 
            // colIsDeleted
            // 
            this.colIsDeleted.FieldName = "IsDeleted";
            this.colIsDeleted.Name = "colIsDeleted";
            // 
            // f202_danh_muc_nhan_vien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 407);
            this.Controls.Add(this.gridControl1);
            this.Name = "f202_danh_muc_nhan_vien";
            this.Text = "F202 - Danh mục nhân viên";
            this.Load += new System.EventHandler(this.f202_danh_muc_nhan_vien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iVT_Ver01DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMNHANVIENBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private IVT_Ver01DataSet2 iVT_Ver01DataSet2;
        private System.Windows.Forms.BindingSource dMNHANVIENBindingSource;
        private IVT_Ver01DataSet2TableAdapters.DM_NHAN_VIENTableAdapter dM_NHAN_VIENTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colMA_NHAN_VIEN;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN_NHAN_VIEN;
        private DevExpress.XtraGrid.Columns.GridColumn colSDT;
        private DevExpress.XtraGrid.Columns.GridColumn colCONG_VIEC_PHU_TRACH;
        private DevExpress.XtraGrid.Columns.GridColumn colIsDeleted;
    }
}