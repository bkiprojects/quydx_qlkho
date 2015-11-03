using BO;
using BSL.COMMOM_SERVICE;
using COMMON.Exception;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using COMMON;
using MODEL.HANG;
using BSL.HANG_SERVICE;
namespace QUYDX_INVENTORY.NGHIEP_VU
{
    public partial class f100_phieu_nhap_kho : Form
    {
        private BindingList<BO_HANG> m_ds_hang;
        private BindingList<DM_MAT_HANG> m_ds_mat_hang;
        public f100_phieu_nhap_kho()
        {
            InitializeComponent();
            format_control();
        }

        #region Private Method
        private void format_control()
        {
            set_define_event();
        }
        private void set_initial_form_load()
        {
            m_dat_ngay_nhap_kho.DateTime = DateTime.Now;
            m_ds_hang = new BindingList<BO_HANG>();
            m_ds_mat_hang = new BindingList<DM_MAT_HANG>(BS_MAT_HANG.Instance.GetListMatHang());
            fill_data_to_sle_nhan_vien();
            fill_data_to_le_kho();
            fill_data_to_sle_mat_hang();
        }
        private void fill_data_to_sle_nhan_vien()
        {
            m_sle_nhan_vien.Properties.DataSource = BS_NhanVien.Instance.GetListNhanVien();
        }
        private void fill_data_to_le_kho()
        {
            m_le_nhap_vao_kho.Properties.DataSource = BS_KHO.Instance.GetListKho();
        }
        private void fill_data_to_sle_mat_hang()
        {
            m_sle_mat_hang.Properties.DataSource = m_ds_mat_hang;
        }
        private void add_item()
        {
            if(ControlUtility.ValidateControlEmpty(m_sle_mat_hang, m_txt_barcode))
            {
                XtraMessageBox.Show("Hoàn thiện dữ liệu trước", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning );
                return;
            }
        }
        #endregion

        #region Event Handle
        private void set_define_event()
        {
            Load += f100_phieu_nhap_kho_Load;
            KeyDown += f100_phieu_nhap_kho_KeyDown;
        }

        void f100_phieu_nhap_kho_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if(e.KeyCode == Keys.Enter)
                {
                    add_item();
                }
            }
            catch(Exception v_e)
            {
                ExceptionHandle.Show(v_e);
            }
        }

        void f100_phieu_nhap_kho_Load(object sender, EventArgs e)
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
