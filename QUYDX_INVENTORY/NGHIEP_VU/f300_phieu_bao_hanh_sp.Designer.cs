namespace QUYDX_INVENTORY.NGHIEP_VU
{
    partial class f300_phieu_bao_hanh_sp
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.m_cmd_in_bao_hanh = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_danh_sach_phieu = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_lap_phieu = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.m_cmd_in_bao_hanh);
            this.panelControl1.Controls.Add(this.m_cmd_danh_sach_phieu);
            this.panelControl1.Controls.Add(this.m_cmd_lap_phieu);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 221);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(545, 40);
            this.panelControl1.TabIndex = 2;
            // 
            // m_cmd_in_bao_hanh
            // 
            this.m_cmd_in_bao_hanh.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_cmd_in_bao_hanh.Image = global::QUYDX_INVENTORY.Properties.Resources.print;
            this.m_cmd_in_bao_hanh.Location = new System.Drawing.Point(267, 2);
            this.m_cmd_in_bao_hanh.Name = "m_cmd_in_bao_hanh";
            this.m_cmd_in_bao_hanh.Size = new System.Drawing.Size(168, 36);
            this.m_cmd_in_bao_hanh.TabIndex = 2;
            this.m_cmd_in_bao_hanh.Text = "In phiếu bảo hành";
            // 
            // m_cmd_danh_sach_phieu
            // 
            this.m_cmd_danh_sach_phieu.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_cmd_danh_sach_phieu.Image = global::QUYDX_INVENTORY.Properties.Resources.address_book;
            this.m_cmd_danh_sach_phieu.Location = new System.Drawing.Point(99, 2);
            this.m_cmd_danh_sach_phieu.Name = "m_cmd_danh_sach_phieu";
            this.m_cmd_danh_sach_phieu.Size = new System.Drawing.Size(168, 36);
            this.m_cmd_danh_sach_phieu.TabIndex = 1;
            this.m_cmd_danh_sach_phieu.Text = "Danh sách phiếu xuất";
            // 
            // m_cmd_lap_phieu
            // 
            this.m_cmd_lap_phieu.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_cmd_lap_phieu.Image = global::QUYDX_INVENTORY.Properties.Resources.blue_tag;
            this.m_cmd_lap_phieu.Location = new System.Drawing.Point(2, 2);
            this.m_cmd_lap_phieu.Name = "m_cmd_lap_phieu";
            this.m_cmd_lap_phieu.Size = new System.Drawing.Size(97, 36);
            this.m_cmd_lap_phieu.TabIndex = 0;
            this.m_cmd_lap_phieu.Text = "Lập phiếu";
            // 
            // f300_phieu_bao_hanh_sp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 261);
            this.Controls.Add(this.panelControl1);
            this.Name = "f300_phieu_bao_hanh_sp";
            this.Text = "f300_phieu_bao_hanh_sp";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton m_cmd_in_bao_hanh;
        private DevExpress.XtraEditors.SimpleButton m_cmd_danh_sach_phieu;
        private DevExpress.XtraEditors.SimpleButton m_cmd_lap_phieu;
    }
}