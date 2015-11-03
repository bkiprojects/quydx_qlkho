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

namespace QUYDX_INVENTORY.NGHIEP_VU
{
    public partial class f100_phieu_nhap_kho : Form
    {
        private List<BO_HANG> m_ds_hang;
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
            m_ds_hang = new List<BO_HANG>();

            fill_data_to_sle_nhan_vien()
        }
        private void fill_data_to_sle_nhan_vien()
        {
            m_sle_nhan_vien.Properties.DataSource = BS_NhanVien.Instance.GetListNhanVien();
        }
        private void fill_data_to_le_kho()
        {
            m_le_nhap_vao_kho.Properties.DataSource = BS_NhanVien.Instance
        }
        #endregion

        #region Event Handle
        private void set_define_event()
        {
            Load += f100_phieu_nhap_kho_Load;
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
