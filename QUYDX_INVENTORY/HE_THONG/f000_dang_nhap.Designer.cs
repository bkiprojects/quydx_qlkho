namespace QUYDX_INVENTORY.HE_THONG
{
    partial class f000_dang_nhap
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.m_cmd_dang_nhap = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_thoat = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.m_txt_ten_dang_nhap = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.m_txt_mat_khau = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_txt_ten_dang_nhap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_txt_mat_khau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.m_cmd_dang_nhap);
            this.panelControl1.Controls.Add(this.m_cmd_thoat);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 143);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(319, 42);
            this.panelControl1.TabIndex = 1;
            // 
            // m_cmd_dang_nhap
            // 
            this.m_cmd_dang_nhap.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.m_cmd_dang_nhap.Appearance.Options.UseFont = true;
            this.m_cmd_dang_nhap.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_dang_nhap.Location = new System.Drawing.Point(129, 2);
            this.m_cmd_dang_nhap.Name = "m_cmd_dang_nhap";
            this.m_cmd_dang_nhap.Size = new System.Drawing.Size(94, 38);
            this.m_cmd_dang_nhap.TabIndex = 1;
            this.m_cmd_dang_nhap.Text = "Đăng nhập";
            // 
            // m_cmd_thoat
            // 
            this.m_cmd_thoat.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_thoat.Location = new System.Drawing.Point(223, 2);
            this.m_cmd_thoat.Name = "m_cmd_thoat";
            this.m_cmd_thoat.Size = new System.Drawing.Size(94, 38);
            this.m_cmd_thoat.TabIndex = 0;
            this.m_cmd_thoat.Text = "Thoát";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.m_txt_mat_khau);
            this.layoutControl1.Controls.Add(this.m_txt_ten_dang_nhap);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(319, 143);
            this.layoutControl1.TabIndex = 2;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(319, 143);
            this.layoutControlGroup1.Text = "layoutControlGroup1";
            this.layoutControlGroup1.TextVisible = false;
            // 
            // m_txt_ten_dang_nhap
            // 
            this.m_txt_ten_dang_nhap.EnterMoveNextControl = true;
            this.m_txt_ten_dang_nhap.Location = new System.Drawing.Point(12, 34);
            this.m_txt_ten_dang_nhap.Name = "m_txt_ten_dang_nhap";
            this.m_txt_ten_dang_nhap.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.m_txt_ten_dang_nhap.Properties.Appearance.Options.UseFont = true;
            this.m_txt_ten_dang_nhap.Size = new System.Drawing.Size(295, 26);
            this.m_txt_ten_dang_nhap.StyleController = this.layoutControl1;
            this.m_txt_ten_dang_nhap.TabIndex = 4;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 12F);
            this.layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem1.Control = this.m_txt_ten_dang_nhap;
            this.layoutControlItem1.CustomizationFormText = "Tên đăng nhập";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(299, 52);
            this.layoutControlItem1.Text = "Tên đăng nhập";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(107, 19);
            // 
            // m_txt_mat_khau
            // 
            this.m_txt_mat_khau.Location = new System.Drawing.Point(12, 86);
            this.m_txt_mat_khau.Name = "m_txt_mat_khau";
            this.m_txt_mat_khau.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.m_txt_mat_khau.Properties.Appearance.Options.UseFont = true;
            this.m_txt_mat_khau.Size = new System.Drawing.Size(295, 26);
            this.m_txt_mat_khau.StyleController = this.layoutControl1;
            this.m_txt_mat_khau.TabIndex = 5;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 12F);
            this.layoutControlItem2.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem2.Control = this.m_txt_mat_khau;
            this.layoutControlItem2.CustomizationFormText = "Mật khẩu";
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 52);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(299, 71);
            this.layoutControlItem2.Text = "Mật khẩu";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(107, 19);
            // 
            // f000_dang_nhap
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(319, 185);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.panelControl1);
            this.KeyPreview = true;
            this.Name = "f000_dang_nhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_txt_ten_dang_nhap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_txt_mat_khau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton m_cmd_dang_nhap;
        private DevExpress.XtraEditors.SimpleButton m_cmd_thoat;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.TextEdit m_txt_mat_khau;
        private DevExpress.XtraEditors.TextEdit m_txt_ten_dang_nhap;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    }
}