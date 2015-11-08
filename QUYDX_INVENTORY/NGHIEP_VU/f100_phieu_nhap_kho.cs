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


            m_sle_mat_hang.EditValueChanged += m_sle_mat_hang_EditValueChanged;
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
        private void fill_data_to_grid_hang()
        {
            m_grd_ds_hang.DataSource = m_ds_hang;
            m_grd_ds_hang.RefreshDataSource();
        }
        
        private void fill_data_2_edit(BO_HANG ip_obj)
        {
            m_sle_mat_hang.EditValue = ip_obj.ID_MAT_HANG;
            m_txt_barcode.Text = ip_obj.BARCODE;

        }
        private void add_item()
        {
            if(!ControlUtility.ValidateControlEmpty(m_sle_mat_hang, m_txt_barcode))
            {
                XtraMessageBox.Show("Hoàn thiện dữ liệu trước", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DM_MAT_HANG obj_selected = (DM_MAT_HANG)m_sle_mat_hang.Properties.View.GetRow(m_sle_mat_hang.Properties.GetIndexByKeyValue(m_sle_mat_hang.EditValue));

            BO_HANG item = new BO_HANG()
            {
                ID = 0,
                TEN_MAT_HANG = obj_selected.TEN_MAT_HANG,
                GIA_NHAP = obj_selected.GIA_NHAP_DE_XUAT,
                GIA_XUAT_DE_XUAT = obj_selected.GIA_XUAT_DE_XUAT,
                THOI_GIAN_BAO_HANH = obj_selected.THOI_GIAN_BAO_HANH_DE_XUAT,
                BARCODE = m_txt_barcode.Text.Trim(),
                ID_MAT_HANG = obj_selected.ID
            };
            m_ds_hang.Add(item);
            fill_data_to_grid_hang();
        }
        private void lap_phieu()
        {
            if(!ControlUtility.ValidateControlEmpty(m_txt_so_phieu_nhap, m_dat_ngay_nhap_kho, m_le_nhap_vao_kho, m_sle_nhan_vien))
            {
                XtraMessageBox.Show("Hoàn thiện dữ liệu trước", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(m_grv_ds_hang.RowCount <= 0)
            {
                XtraMessageBox.Show("Chưa có hàng để nhập", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

        }
        #endregion

        #region Event Handle
        private void set_define_event()
        {
            Load += f100_phieu_nhap_kho_Load;
            KeyDown += f100_phieu_nhap_kho_KeyDown;
            m_cmd_delete.Click += m_cmd_delete_Click;
            m_cmd_lap_phieu.Click += m_cmd_lap_phieu_Click;
            m_grv_ds_hang.FocusedRowChanged += m_grv_ds_hang_FocusedRowChanged;
        }

        void m_grv_ds_hang_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                if(e.FocusedRowHandle < 0)
                {
                    return;
                }
                var obj_row_selected = (BO_HANG) m_grv_ds_hang.GetRow(e.FocusedRowHandle);
                fill_data_2_edit(obj_row_selected);
            }
            catch(Exception v_e)
            {
                ExceptionHandle.Show(v_e);
            }
        }

        void m_sle_mat_hang_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                var id_mat_hang = (long)m_sle_mat_hang.EditValue;
                if(id_mat_hang <= 0)
                {
                    return;
                }
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

        void m_cmd_delete_Click(object sender, EventArgs e)
        {
            try
            {
                var item = (BO_HANG)m_grv_ds_hang.GetRow(m_grv_ds_hang.FocusedRowHandle);
                m_ds_hang.Remove(item);

                fill_data_to_grid_hang();
            }
            catch(Exception v_e)
            {
                ExceptionHandle.Show(v_e);
            }
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
