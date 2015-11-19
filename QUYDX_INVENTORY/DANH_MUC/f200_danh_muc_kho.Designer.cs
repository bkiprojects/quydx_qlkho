namespace QUYDX_INVENTORY.DANH_MUC
{
    partial class f200_danh_muc_kho
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
            this.m_grc_dm_kho = new DevExpress.XtraGrid.GridControl();
            this.dMKHOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iVT_Ver01DataSet = new QUYDX_INVENTORY.IVT_Ver01DataSet();
            this.m_grv_dm_kho = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMA_KHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN_KHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_THU_KHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsDeleted = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dM_KHOTableAdapter = new QUYDX_INVENTORY.IVT_Ver01DataSetTableAdapters.DM_KHOTableAdapter();
            this.colTenThuKho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.iVT_Ver01DataSet1 = new QUYDX_INVENTORY.IVT_Ver01DataSet1();
            this.vDMKHOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_DM_KHOTableAdapter = new QUYDX_INVENTORY.IVT_Ver01DataSet1TableAdapters.V_DM_KHOTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_dm_kho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMKHOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iVT_Ver01DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_dm_kho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iVT_Ver01DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDMKHOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // m_grc_dm_kho
            // 
            this.m_grc_dm_kho.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_grc_dm_kho.DataSource = this.vDMKHOBindingSource;
            this.m_grc_dm_kho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_grc_dm_kho.Location = new System.Drawing.Point(0, 0);
            this.m_grc_dm_kho.MainView = this.m_grv_dm_kho;
            this.m_grc_dm_kho.Name = "m_grc_dm_kho";
            this.m_grc_dm_kho.Size = new System.Drawing.Size(586, 408);
            this.m_grc_dm_kho.TabIndex = 0;
            this.m_grc_dm_kho.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.m_grv_dm_kho});
            // 
            // dMKHOBindingSource
            // 
            this.dMKHOBindingSource.DataMember = "DM_KHO";
            this.dMKHOBindingSource.DataSource = this.iVT_Ver01DataSet;
            // 
            // iVT_Ver01DataSet
            // 
            this.iVT_Ver01DataSet.DataSetName = "IVT_Ver01DataSet";
            this.iVT_Ver01DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // m_grv_dm_kho
            // 
            this.m_grv_dm_kho.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colMA_KHO,
            this.colTEN_KHO,
            this.colID_THU_KHO,
            this.colIsDeleted,
            this.colTenThuKho});
            this.m_grv_dm_kho.GridControl = this.m_grc_dm_kho;
            this.m_grv_dm_kho.Name = "m_grv_dm_kho";
            this.m_grv_dm_kho.OptionsBehavior.Editable = false;
            this.m_grv_dm_kho.OptionsBehavior.ReadOnly = true;
            this.m_grv_dm_kho.OptionsView.ShowGroupPanel = false;
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.OptionsColumn.ReadOnly = true;
            // 
            // colMA_KHO
            // 
            this.colMA_KHO.Caption = "Mã kho";
            this.colMA_KHO.FieldName = "MA_KHO";
            this.colMA_KHO.Name = "colMA_KHO";
            this.colMA_KHO.Visible = true;
            this.colMA_KHO.VisibleIndex = 0;
            // 
            // colTEN_KHO
            // 
            this.colTEN_KHO.Caption = "Tên kho";
            this.colTEN_KHO.FieldName = "TEN_KHO";
            this.colTEN_KHO.Name = "colTEN_KHO";
            this.colTEN_KHO.Visible = true;
            this.colTEN_KHO.VisibleIndex = 1;
            // 
            // colID_THU_KHO
            // 
            this.colID_THU_KHO.FieldName = "ID_THU_KHO";
            this.colID_THU_KHO.Name = "colID_THU_KHO";
            // 
            // colIsDeleted
            // 
            this.colIsDeleted.FieldName = "IsDeleted";
            this.colIsDeleted.Name = "colIsDeleted";
            // 
            // dM_KHOTableAdapter
            // 
            this.dM_KHOTableAdapter.ClearBeforeFill = true;
            // 
            // colTenThuKho
            // 
            this.colTenThuKho.Caption = "Thủ kho";
            this.colTenThuKho.FieldName = "TEN_THU_KHO";
            this.colTenThuKho.Name = "colTenThuKho";
            this.colTenThuKho.Visible = true;
            this.colTenThuKho.VisibleIndex = 2;
            // 
            // iVT_Ver01DataSet1
            // 
            this.iVT_Ver01DataSet1.DataSetName = "IVT_Ver01DataSet1";
            this.iVT_Ver01DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vDMKHOBindingSource
            // 
            this.vDMKHOBindingSource.DataMember = "V_DM_KHO";
            this.vDMKHOBindingSource.DataSource = this.iVT_Ver01DataSet1;
            // 
            // v_DM_KHOTableAdapter
            // 
            this.v_DM_KHOTableAdapter.ClearBeforeFill = true;
            // 
            // f200_danh_muc_kho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 408);
            this.Controls.Add(this.m_grc_dm_kho);
            this.Name = "f200_danh_muc_kho";
            this.Text = "F200 - Danh mục kho";
            this.Load += new System.EventHandler(this.f200_danh_muc_kho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.m_grc_dm_kho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dMKHOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iVT_Ver01DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_grv_dm_kho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iVT_Ver01DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDMKHOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl m_grc_dm_kho;
        private DevExpress.XtraGrid.Views.Grid.GridView m_grv_dm_kho;
        private IVT_Ver01DataSet iVT_Ver01DataSet;
        private System.Windows.Forms.BindingSource dMKHOBindingSource;
        private IVT_Ver01DataSetTableAdapters.DM_KHOTableAdapter dM_KHOTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colMA_KHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN_KHO;
        private DevExpress.XtraGrid.Columns.GridColumn colID_THU_KHO;
        private DevExpress.XtraGrid.Columns.GridColumn colIsDeleted;
        private DevExpress.XtraGrid.Columns.GridColumn colTenThuKho;
        private IVT_Ver01DataSet1 iVT_Ver01DataSet1;
        private System.Windows.Forms.BindingSource vDMKHOBindingSource;
        private IVT_Ver01DataSet1TableAdapters.V_DM_KHOTableAdapter v_DM_KHOTableAdapter;
    }
}