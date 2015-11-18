using BO;
using BSL.COMMOM_SERVICE;
using BSL.HANG_SERVICE;
using COMMON;
using COMMON.Exception;
using DevExpress.XtraEditors;
using MODEL.HANG;
using MODEL.XUAT;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUYDX_INVENTORY.NGHIEP_VU
{
    public partial class f200_phieu_xuat_kho : Form
    {
        private BindingList<GD_HANG> m_lst_hang;
        #region Public Interface
        public f200_phieu_xuat_kho()
        {
            InitializeComponent();
            format_control();
        }
        #endregion
        

        #region Private Method
        private void format_control()
        {
            set_define_event();
        }
        private void set_initial_form_load()
        {
            m_dat_ngay_chung_tu.DateTime = DateTime.Now;
            m_lst_hang = new BindingList<GD_HANG>();
            fill_data_to_sle_nhan_vien();
            fill_data_to_le_kho();
            fill_data_to_sle_khach_hang();
        }
        private void fill_data_to_sle_nhan_vien()
        {
            m_sle_nhan_vien.Properties.DataSource = BS_NhanVien.Instance.GetListNhanVien();
        }
        private void fill_data_to_le_kho()
        {
            m_le_kho.Properties.DataSource = BS_KHO.Instance.GetListKho();
        }
        private void fill_data_to_grid_hang()
        {
            m_grd_ds_hang.DataSource = m_lst_hang;
            m_grd_ds_hang.RefreshDataSource();
        }
        private void fill_data_to_sle_khach_hang()
        {
            m_sle_khach_hang.Properties.DataSource = BS_KhachHang.Instance.GetListKhachHang();
        }
        private bool is_exist_barcode_in_csdl(string ip_str_barcode)
        {
            if(BS_MAT_HANG.Instance.IsExistBarcode(ip_str_barcode))
                return true;
            return false;
        }
        private bool is_exist_barcode_in_qua_trinh_nhap(string barcode)
        {
            if(m_lst_hang.Where(x => x.BARCODE == barcode).Count() > 0)
            {
                return true;
            }
            return false;
        }
        private bool is_xuat_kho(string barcode)
        {
            if(BS_MAT_HANG.Instance.IsXuatKho(barcode))
                return true;
            return false;
        }
        private void add_item()
        {
            if(!ControlUtility.ValidateControlEmpty(m_txt_barcode))
            {
                XtraMessageBox.Show("Hoàn thiện dữ liệu trước", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(!is_exist_barcode_in_csdl(m_txt_barcode.Text))
            {
                XtraMessageBox.Show("Barcode chưa tồn tại trong CSDL", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(is_exist_barcode_in_qua_trinh_nhap(m_txt_barcode.Text))
            {
                XtraMessageBox.Show("Barcode đã tồn tại trong phiếu xuất này", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(is_xuat_kho(m_txt_barcode.Text))
            {
                 XtraMessageBox.Show("Barcode này không có trong kho hoặc đã xuất", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var item = BS_MAT_HANG.Instance.LayEntity(m_txt_barcode.Text);
            item.GIA_XUAT = (decimal) m_txt_gia_xuat_thuc_te.EditValue;
            item.NGAY_BAT_DAU_BAO_HANH = m_dat_tu_ngay_bh.DateTime;
            item.NGAY_KET_THUC_BAO_HANH = m_dat_den_ngay_bh.DateTime;
            item.THOI_GIAN_BAO_HANH = (int) m_txt_thoi_gian_bao_hanh.EditValue;
            item.ID_KHACH_HANG = (long?) m_sle_khach_hang.EditValue;
            item.NGAY_XUAT_HANG = m_dat_ngay_chung_tu.DateTime;
            m_lst_hang.Add(item);

            fill_data_to_grid_hang();
            reset_xuat_hang();
        }
        private void fill_data_suggest(string barcode)
        {
            if(!is_exist_barcode_in_csdl(m_txt_barcode.Text))
            {
                XtraMessageBox.Show("Không có barcode này trong CSDL", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(is_exist_barcode_in_qua_trinh_nhap(m_txt_barcode.Text))
            {
                XtraMessageBox.Show("Barcode này đã có trên lưới rồi", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var obj_bo = BS_MAT_HANG.Instance.LayBOHang(barcode);
            m_txt_gia_xuat_thuc_te.EditValue = obj_bo.GIA_XUAT_DE_XUAT;
            m_txt_gia_xuat_de_xuat.EditValue = obj_bo.GIA_XUAT_DE_XUAT;
            m_txt_thoi_gian_bao_hanh.EditValue = obj_bo.THOI_GIAN_BAO_HANH;
            m_dat_tu_ngay_bh.DateTime = DateTime.Now.Date;
            m_dat_den_ngay_bh.DateTime = DateTime.Now.Date.AddMonths((int)m_txt_thoi_gian_bao_hanh.EditValue);
        }
        private void reset_xuat_hang()
        {
            m_txt_barcode.ResetText();
            m_txt_gia_xuat_thuc_te.ResetText();
            m_txt_gia_xuat_de_xuat.ResetText();
            m_txt_thoi_gian_bao_hanh.ResetText();
            m_dat_tu_ngay_bh.ResetText();
            m_dat_den_ngay_bh.ResetText();
            m_txt_barcode.Focus();
        }
        private void reset_phieu_nhap()
        {
            m_txt_so_phieu.ResetText();
            m_dat_ngay_chung_tu.DateTime = DateTime.Now;
            m_sle_nhan_vien.EditValue = null;
            m_le_kho.EditValue = null;
            m_grd_ds_hang.DataSource = null;
            m_grd_ds_hang.RefreshDataSource();
            m_txt_so_phieu.Focus();
        }
        private void lap_phieu()
        {
            if(!ControlUtility.ValidateControlEmpty(m_txt_so_phieu, m_dat_ngay_chung_tu, m_le_kho, m_sle_nhan_vien))
            {
                XtraMessageBox.Show("Hoàn thiện dữ liệu trước", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(m_grv_ds_hang.RowCount <= 0)
            {
                XtraMessageBox.Show("Chưa có hàng để nhập", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var phieu_xuat = new GD_PHIEU_XUAT()
            {
                SO_CHUNG_TU = m_txt_so_phieu.Text,
                NGAY_CHUNG_TU = m_dat_ngay_chung_tu.DateTime,
                ID_NHAN_VIEN_LIEN_QUAN = (long)m_sle_nhan_vien.EditValue,
                NGAY_NHAP_PHAN_MEM = DateTime.Now.Date,
                ID_KHACH_HANG = (long?) m_sle_khach_hang.EditValue
            };
            BS_MAT_HANG.Instance.LapPhieuXuat(phieu_xuat, m_lst_hang);
            var dlg = XtraMessageBox.Show("Lập phiếu nhập thành công! Bạn muốn lập phiếu nhập mới?", "THÔNG BÁO", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(dlg == System.Windows.Forms.DialogResult.OK)
            {
                reset_xuat_hang();
                reset_phieu_nhap();
                m_lst_hang = new BindingList<GD_HANG>();
            }
            else
            {
                Dispose();
            }
        }
        #endregion

        #region Event Handle
        private void set_define_event()
        {
            Load += f200_phieu_xuat_kho_Load;
            KeyDown += f200_phieu_xuat_kho_KeyDown;
            m_cmd_lap_phieu.Click += m_cmd_lap_phieu_Click;
            m_cmd_danh_sach_phieu.Click += m_cmd_danh_sach_phieu_Click;
            m_cmd_insert.Click += m_cmd_insert_Click;
            m_cmd_delete.Click += m_cmd_delete_Click;
            m_txt_barcode.EditValueChanged += m_txt_barcode_EditValueChanged;
            m_txt_barcode.Leave += m_txt_barcode_Leave;
            m_dat_tu_ngay_bh.EditValueChanged += m_dat_tu_ngay_bh_EditValueChanged;
            m_dat_den_ngay_bh.EditValueChanged += m_dat_den_ngay_bh_EditValueChanged;
            m_cmd_in_bao_hanh.Click += m_cmd_in_bao_hanh_Click;
        }

        void m_cmd_in_bao_hanh_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch(Exception)
            {
                
                throw;
            }
        }

        void m_dat_den_ngay_bh_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if(string.IsNullOrEmpty(m_txt_barcode.Text))
                {
                    return;
                }
                m_dat_tu_ngay_bh.DateTime = m_dat_den_ngay_bh.DateTime.AddMonths(-(int)m_txt_thoi_gian_bao_hanh.EditValue);
            }
            catch(Exception v_e)
            {
                ExceptionHandle.Show(v_e);
            }
        }

        void m_dat_tu_ngay_bh_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if(string.IsNullOrEmpty(m_txt_barcode.Text))
                {
                    return;
                }
                m_dat_den_ngay_bh.DateTime = m_dat_tu_ngay_bh.DateTime.AddMonths((int)m_txt_thoi_gian_bao_hanh.EditValue);
            }
            catch(Exception v_e)
            {
                ExceptionHandle.Show(v_e);
            }
        }

        void m_txt_barcode_Leave(object sender, EventArgs e)
            {
            try
            {
                if(string.IsNullOrEmpty(m_txt_barcode.Text))
                {
                    return;
                }
                if(is_xuat_kho(m_txt_barcode.Text))
                {
                    XtraMessageBox.Show("Barcode này không có trong kho hoặc đã xuất", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                fill_data_suggest(m_txt_barcode.Text);
            }
            catch(Exception v_e)
            {
                ExceptionHandle.Show(v_e);
            }
        }

        void m_txt_barcode_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch(Exception v_e)
            {
                ExceptionHandle.Show(v_e);
            }
        }

        void m_cmd_delete_Click(object sender, EventArgs e)
        {
            try
            {
                var item = (GD_HANG)m_grv_ds_hang.GetRow(m_grv_ds_hang.FocusedRowHandle);
                m_lst_hang.Remove(item);

                fill_data_to_grid_hang();
            }
            catch(Exception v_e)
            {
                ExceptionHandle.Show(v_e);
            }
        }

        void m_cmd_insert_Click(object sender, EventArgs e)
        {
            try
            {
                add_item();
            }
            catch(Exception v_e)
            {
                ExceptionHandle.Show(v_e);
            }
        }

        void m_cmd_danh_sach_phieu_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch(Exception v_e)
            {
                ExceptionHandle.Show(v_e);
            }
        }

        void m_cmd_lap_phieu_Click(object sender, EventArgs e)
        {
            try
            {
                lap_phieu();
            }
            catch(Exception v_e)
            {
                ExceptionHandle.Show(v_e);
            }
        }

        void f200_phieu_xuat_kho_KeyDown(object sender, KeyEventArgs e)
        
        {
            try
            {
                if(e.KeyCode == Keys.F1)
                {
                    add_item();
                }
            }
            catch(Exception v_e)
            {
                ExceptionHandle.Show(v_e);
            }
        }

        void f200_phieu_xuat_kho_Load(object sender, EventArgs e)
        {
            try
            {
                set_initial_form_load();
            }
            catch(Exception v_e)
            {
                ExceptionHandle.Show(v_e);
            }
        }
       
        #endregion
    }
}
