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
    public partial class f400_phieu_chuyen_kho : Form
    {
        public f400_phieu_chuyen_kho()
        {
            InitializeComponent();
            format_control();
        }

        private void format_control()
        {
            set_define_event();
        }

        private void set_initial_form_load()
        {
            m_dat_ngay_chung_tu.DateTime = DateTime.Now;
            fill_data_to_sle_nhan_vien();
            fill_data_to_sle_kho();
        }
        private void fill_data_to_sle_nhan_vien()
        {
            m_sle_nhan_vien.Properties.DataSource = BS_NhanVien.Instance.GetListNhanVien();
        }
        private void fill_data_to_sle_kho()
        {
            m_sle_chuyen_tu_kho.Properties.DataSource = BS_KHO.Instance.GetListKho();
            m_sle_chuyen_toi_kho.Properties.DataSource = BS_KHO.Instance.GetListKho();
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

            var obj_bo = BS_MAT_HANG.Instance.LayEntity(barcode);

            m_sle_chuyen_tu_kho.EditValue = obj_bo.ID_KHO;

            m_sle_chuyen_toi_kho.Focus();
        }
        private void set_define_event()
        {
            Load += f400_phieu_chuyen_kho_Load;
            m_cmd_lap_phieu.Click += m_cmd_lap_phieu_Click;
            m_cmd_danh_sach_phieu.Click += m_cmd_danh_sach_phieu_Click;
            m_txt_barcode.Leave += m_txt_barcode_Leave;
        }

        void m_txt_barcode_Leave(object sender, EventArgs e)
        {
            try
            {
                if(string.IsNullOrEmpty(m_txt_barcode.Text))
                {
                    return;
                }
                fill_data_suggest(m_txt_barcode.Text);
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
                if(!ControlUtility.ValidateControlEmpty(m_txt_so_phieu, m_dat_ngay_chung_tu, m_sle_nhan_vien, m_sle_chuyen_toi_kho, m_sle_chuyen_tu_kho, m_txt_barcode))
                {
                    XtraMessageBox.Show("Hoàn thiện dữ liệu trước", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
               
            }
            catch(Exception v_e)
            {
                ExceptionHandle.Show(v_e);
            }
        }

        void f400_phieu_chuyen_kho_Load(object sender, EventArgs e)
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
    }
}
