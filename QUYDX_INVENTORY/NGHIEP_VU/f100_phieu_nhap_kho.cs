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
using MODEL.NHAP;
namespace QUYDX_INVENTORY.NGHIEP_VU
{
    public partial class f100_phieu_nhap_kho : Form
    {
        private BindingList<BO_HANG> m_lst_hang;
        private BindingList<DM_MAT_HANG> m_lst_mat_hang;

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
            m_lst_hang = new BindingList<BO_HANG>();
            m_lst_mat_hang = new BindingList<DM_MAT_HANG>(BS_MAT_HANG.Instance.GetListMatHang());
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
            m_sle_mat_hang.Properties.DataSource = m_lst_mat_hang;
        }
        private void fill_data_to_grid_hang()
        {
            m_grd_ds_hang.DataSource = m_lst_hang;
            m_grd_ds_hang.RefreshDataSource();
        }
        
        private void fill_data_2_edit(BO_HANG ip_obj)
        {
            m_sle_mat_hang.EditValue = ip_obj.ID_MAT_HANG;
            m_txt_barcode.Text = ip_obj.BARCODE;

        }
        private void fill_data_suggest(DM_MAT_HANG ip_obj)
        {
            m_txt_gia_nhap.EditValue = ip_obj.GIA_NHAP_DE_XUAT;
            m_txt_gia_xuat_de_xuat.EditValue = ip_obj.GIA_XUAT_DE_XUAT;
            m_txt_thoi_gian_bao_hanh.EditValue = ip_obj.THOI_GIAN_BAO_HANH_DE_XUAT;
        }
        private void reset_nhap_hang()
        {
            m_sle_mat_hang.EditValue = null;
            m_txt_barcode.ResetText();
            m_txt_gia_nhap.ResetText();
            m_txt_gia_xuat_de_xuat.ResetText();
            m_txt_thoi_gian_bao_hanh.ResetText();
            m_sle_mat_hang.Focus();
        }
        private void reset_phieu_nhap()
        {
            m_txt_so_phieu_nhap.ResetText();
            m_dat_ngay_nhap_kho.DateTime = DateTime.Now;
            m_sle_nhan_vien.EditValue = null;
            m_le_nhap_vao_kho.EditValue = null;
            m_grd_ds_hang.DataSource = null;
            m_grd_ds_hang.RefreshDataSource();
        }
        private bool is_exist_barcode_in_csdl(string ip_str_barcode){
            if(BS_MAT_HANG.Instance.IsExistBarcode(ip_str_barcode))
                return true;
            return false;
        }
        private bool is_exist_barcode_in_qua_trinh_nhap(string ip_str_barcode)
        {
            if(m_lst_hang.Where(x=>x.BARCODE == ip_str_barcode).Count() > 0)
            {
                return true;
            }
            return false;
        }
        private void add_item()
        {
            if(!ControlUtility.ValidateControlEmpty(m_sle_mat_hang, m_txt_barcode, m_txt_gia_nhap, m_txt_gia_xuat_de_xuat, m_txt_thoi_gian_bao_hanh))
            {
                XtraMessageBox.Show("Hoàn thiện dữ liệu trước", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(is_exist_barcode_in_csdl(m_txt_barcode.Text))
            {
                XtraMessageBox.Show("Barcode đã tồn tại trong CSDL", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }
            if(is_exist_barcode_in_qua_trinh_nhap(m_txt_barcode.Text))
            {
                XtraMessageBox.Show("Barcode đã tồn tại trong việc nhập vừa rồi", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }
            DM_MAT_HANG obj_selected = (DM_MAT_HANG)m_sle_mat_hang.Properties.View.GetRow(m_sle_mat_hang.Properties.GetIndexByKeyValue(m_sle_mat_hang.EditValue));

            BO_HANG item = new BO_HANG()
            {
                ID = 0,
                TEN_MAT_HANG = obj_selected.TEN_MAT_HANG,
                GIA_NHAP = (decimal) m_txt_gia_nhap.EditValue,
                GIA_XUAT_DE_XUAT = (decimal) m_txt_gia_xuat_de_xuat.EditValue,
                THOI_GIAN_BAO_HANH = (int) m_txt_thoi_gian_bao_hanh.EditValue,
                BARCODE = m_txt_barcode.Text.Trim(),
                ID_MAT_HANG = obj_selected.ID,
                NGAY_NHAP_HANG = m_dat_ngay_nhap_kho.DateTime
            };
            m_lst_hang.Add(item);
            fill_data_to_grid_hang();
            reset_nhap_hang();
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
            var phieu_nhap = new GD_PHIEU_NHAP()
            {
                SO_CHUNG_TU = m_txt_so_phieu_nhap.Text,
                NGAY_CHUNG_TU = m_dat_ngay_nhap_kho.DateTime,
                ID_NHAN_VIEN_LIEN_QUAN = (long) m_sle_nhan_vien.EditValue,
                NGAY_NHAP_PHAN_MEM = DateTime.Now.Date
            };
            BS_MAT_HANG.Instance.LapPhieuNhap(phieu_nhap, m_lst_hang);
            var dlg = XtraMessageBox.Show("Lập phiếu nhập thành công! Bạn muốn lập phiếu nhập mới?", "THÔNG BÁO", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(dlg == System.Windows.Forms.DialogResult.OK)
            {
                reset_nhap_hang();
                reset_phieu_nhap();
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
            Load += f100_phieu_nhap_kho_Load;
            KeyDown += f100_phieu_nhap_kho_KeyDown;
            m_cmd_delete.Click += m_cmd_delete_Click;
            m_cmd_lap_phieu.Click += m_cmd_lap_phieu_Click;
            m_cmd_insert.Click += m_cmd_insert_Click;
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

        void m_sle_mat_hang_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if(m_sle_mat_hang.EditValue == null)
                {
                    return;
                }
                var id_mat_hang = (long)m_sle_mat_hang.EditValue;
                if(id_mat_hang <= 0)
                {
                    return;
                }

                var obj = (DM_MAT_HANG)m_sle_mat_hang.Properties.View.GetRow(m_sle_mat_hang.Properties.GetIndexByKeyValue(id_mat_hang));
               
                fill_data_suggest(obj);
                m_txt_barcode.Focus();
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
                m_lst_hang.Remove(item);

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
