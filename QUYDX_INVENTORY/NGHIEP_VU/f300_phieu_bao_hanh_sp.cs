using BSL.COMMOM_SERVICE;
using BSL.HANG_SERVICE;
using COMMON;
using COMMON.Exception;
using DevExpress.XtraEditors;
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
    public partial class f300_phieu_bao_hanh_sp : Form
    {
        bool is_ok_lap_phieu = 0;

        #region Public Interface
        public f300_phieu_bao_hanh_sp()
        {
            InitializeComponent();
            format_control();
        }
        #endregion


        #region Privat Method
        private void format_control()
        {
            set_define_event();
        }

        private void set_initial_form_load()
        {
            m_dat_ngay_chung_tu.DateTime = DateTime.Now;
            fill_data_to_sle_nhan_vien();
            fill_data_to_sle_khach_hang();
        }
        private void fill_data_to_sle_nhan_vien()
        {
            m_sle_nhan_vien.Properties.DataSource = BS_NhanVien.Instance.GetListNhanVien();
        }
        private void fill_data_to_sle_khach_hang()
        {
            m_sle_khach_hang.Properties.DataSource = BS_KhachHang.Instance.GetListKhachHang();
        }
        private void reset_nhan_hang()
        {
            m_txt_barcode.ResetText();
            m_dat_tu_ngay_bh.ResetText();
            m_dat_den_ngay_bh.ResetText();
            m_txt_lan_bh.ResetText();
            m_txt_thoi_gian_bh.ResetText();

            m_txt_barcode.Focus();
        }
        private void reset_phieu_nhan_bao_hanh()
        {
            m_txt_so_phieu.ResetText();
            m_dat_ngay_chung_tu.DateTime = DateTime.Now;
            m_sle_nhan_vien.EditValue = null;
            m_txt_so_phieu.Focus();
        }
        private bool is_exist_barcode_in_csdl(string ip_str_barcode)
        {
            if(BS_MAT_HANG.Instance.IsExistBarcode(ip_str_barcode))
                return true;
            return false;
        }
        private void fill_data_suggest(string barcode)
        {
            if(!is_exist_barcode_in_csdl(m_txt_barcode.Text))
            {
                XtraMessageBox.Show("Không có barcode này trong CSDL", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            var obj_bo = BS_MAT_HANG.Instance.LayBOHang(barcode);

            m_dat_tu_ngay_bh.EditValue = obj_bo.THOI_GIAN_BAT_DAU_BAO_HANH;
            m_dat_den_ngay_bh.EditValue = obj_bo.THOI_GIAN_KET_THUC_BAO_HANH;
            m_sle_khach_hang.EditValue = obj_bo.ID_KHACH_HANG;
            m_txt_lan_bh.EditValue = obj_bo.SO_LAN_BAO_HANH + 1;
            m_txt_thoi_gian_bh.EditValue = obj_bo.THOI_GIAN_BAO_HANH;

            m_txt_noi_dung_bh.Focus();
            is_ok_lap_phieu = true;
        }
        private void lap_phieu()
        {
            if(!ControlUtility.ValidateControlEmpty(m_txt_so_phieu, m_dat_ngay_chung_tu, m_sle_khach_hang, m_sle_nhan_vien))
            {
                XtraMessageBox.Show("Hoàn thiện dữ liệu trước", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(!is_ok_lap_phieu)
            {
                XtraMessageBox.Show("Hoàn thiện dữ liệu trước", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var phieu_nhan_bh = new 
        }
        #endregion

        #region Event Handle
        private void set_define_event()
        {
            Load += f300_phieu_bao_hanh_sp_Load;
            m_cmd_lap_phieu.Click += m_cmd_lap_phieu_Click;
            m_cmd_danh_sach_phieu.Click += m_cmd_danh_sach_phieu_Click;
            m_cmd_in_bao_hanh.Click += m_cmd_in_bao_hanh_Click;
            m_txt_barcode.Leave += m_txt_barcode_Leave;
        }

        void m_txt_barcode_Leave(object sender, EventArgs e)
        {
            try
            {
                fill_data_suggest(m_txt_barcode.Text);
            }
            catch(Exception v_e)
            {
                ExceptionHandle.Show(v_e);
            }
        }

        void m_cmd_in_bao_hanh_Click(object sender, EventArgs e)
        {
            try
            {

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

        void f300_phieu_bao_hanh_sp_Load(object sender, EventArgs e)
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
