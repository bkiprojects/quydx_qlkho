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
            this.m_cmd_thoat = new DevExpress.XtraEditors.SimpleButton();
            this.m_cmd_dang_nhap = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.m_cmd_dang_nhap);
            this.panelControl1.Controls.Add(this.m_cmd_thoat);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 205);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(359, 42);
            this.panelControl1.TabIndex = 1;
            // 
            // m_cmd_thoat
            // 
            this.m_cmd_thoat.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_thoat.Location = new System.Drawing.Point(263, 2);
            this.m_cmd_thoat.Name = "m_cmd_thoat";
            this.m_cmd_thoat.Size = new System.Drawing.Size(94, 38);
            this.m_cmd_thoat.TabIndex = 0;
            this.m_cmd_thoat.Text = "Thoát";
            // 
            // m_cmd_dang_nhap
            // 
            this.m_cmd_dang_nhap.Dock = System.Windows.Forms.DockStyle.Right;
            this.m_cmd_dang_nhap.Location = new System.Drawing.Point(169, 2);
            this.m_cmd_dang_nhap.Name = "m_cmd_dang_nhap";
            this.m_cmd_dang_nhap.Size = new System.Drawing.Size(94, 38);
            this.m_cmd_dang_nhap.TabIndex = 1;
            this.m_cmd_dang_nhap.Text = "Đăng nhập";
            // 
            // f000_dang_nhap
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(359, 247);
            this.Controls.Add(this.panelControl1);
            this.KeyPreview = true;
            this.Name = "f000_dang_nhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton m_cmd_dang_nhap;
        private DevExpress.XtraEditors.SimpleButton m_cmd_thoat;
    }
}