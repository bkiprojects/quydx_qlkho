using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using COMMON.Exception;
using QUYDX_INVENTORY.NGHIEP_VU;
using QUYDX_INVENTORY.DANH_MUC;
namespace QUYDX_INVENTORY
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
            format_control();
        }
        private void format_control()
        {
            set_define_events();
        }
        private bool IsExistFormName(Form ip_frm)
        {
            foreach (var child in MdiChildren)
            {
                if (child.Name == ip_frm.Name)
                {
                    child.Activate();
                    return true;
                }
            }
            return false;
        }

        private bool IsExistFormText(Form ip_frm)
        {
            foreach (var child in MdiChildren)
            {
                if (child.Text == ip_frm.Text)
                {
                    child.Activate();
                    return true;
                }
            }
            return false;
        }


        private void set_define_events()
        {
            this.Load += MainForm_Load;
            //Nghiệp vụ
            m_cmd_phieu_nhap_kho.ItemClick += m_cmd_phieu_nhap_kho_ItemClick;
            m_cmd_phieu_xuat_kho.ItemClick += m_cmd_phieu_xuat_kho_ItemClick;
            m_cmd_phieu_nhan_bao_hanh.ItemClick += m_cmd_phieu_nhan_bao_hanh_ItemClick;
            m_cmd_hang_trong_kho.ItemClick += m_cmd_hang_trong_kho_ItemClick;
            m_cmd_chuyen_kho.ItemClick += m_cmd_chuyen_kho_ItemClick;
            //Hệ thống

            //Bao cao

            //Danh muc
            m_cmd_kho.ItemClick += m_cmd_kho_ItemClick;
            m_cmd_khach_hang.ItemClick += m_cmd_khach_hang_ItemClick;
            m_cmd_nhan_vien.ItemClick += m_cmd_nhan_vien_ItemClick;
            m_cmd_mat_hang.ItemClick += m_cmd_mat_hang_ItemClick;
        }

        void m_cmd_chuyen_kho_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                f400_phieu_chuyen_kho v_frm = new f400_phieu_chuyen_kho();
                if(IsExistFormName(v_frm)) return;

                v_frm.MdiParent = this;
                v_frm.Show();
            }
            catch(Exception v_e)
            {
                ExceptionHandle.Show(v_e);
            }
        }

        void m_cmd_mat_hang_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                f203_danh_muc_mat_hang v_frm = new f203_danh_muc_mat_hang();
                if(IsExistFormName(v_frm)) return;

                v_frm.MdiParent = this;
                v_frm.Show();
            }
            catch(Exception v_e)
            {
                ExceptionHandle.Show(v_e);
            }
        }

        void m_cmd_nhan_vien_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                f202_danh_muc_nhan_vien v_frm = new f202_danh_muc_nhan_vien();
                if(IsExistFormName(v_frm)) return;

                v_frm.MdiParent = this;
                v_frm.Show();
            }
            catch(Exception v_e)
            {
                ExceptionHandle.Show(v_e);
            }
        }

        void m_cmd_khach_hang_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                f201_danh_muc_khach_hang v_frm = new f201_danh_muc_khach_hang();
                if(IsExistFormName(v_frm)) return;

                v_frm.MdiParent = this;
                v_frm.Show();
            }
            catch(Exception v_e)
            {
                ExceptionHandle.Show(v_e);
            }
        }

        void m_cmd_kho_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                f200_danh_muc_kho v_frm = new f200_danh_muc_kho();
                if(IsExistFormName(v_frm)) return;

                v_frm.MdiParent = this;
                v_frm.Show();
            }
            catch(Exception v_e)
            {
                ExceptionHandle.Show(v_e);
            }
        }

        void m_cmd_hang_trong_kho_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                f500_hang_trong_kho v_frm = new f500_hang_trong_kho();
                if(IsExistFormName(v_frm)) return;

                v_frm.MdiParent = this;
                v_frm.Show();
            }
            catch(Exception v_e)
            {
                ExceptionHandle.Show(v_e);
            }
        }

        void m_cmd_phieu_nhan_bao_hanh_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                f300_phieu_bao_hanh_sp v_frm = new f300_phieu_bao_hanh_sp();
                if(IsExistFormName(v_frm)) return;

                v_frm.MdiParent = this;
                v_frm.Show();
            }
            catch(Exception v_e)
            {
                ExceptionHandle.Show(v_e);
            }
        }

        void m_cmd_phieu_xuat_kho_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                f200_phieu_xuat_kho v_frm = new f200_phieu_xuat_kho();
                if(IsExistFormName(v_frm)) return;

                v_frm.MdiParent = this;
                v_frm.Show();
            }
            catch(Exception v_e)
            {
                ExceptionHandle.Show(v_e);
            }
        }

        void m_cmd_phieu_nhap_kho_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                f100_phieu_nhap_kho v_frm = new f100_phieu_nhap_kho();
                if (IsExistFormName(v_frm)) return;

                v_frm.MdiParent = this;
                v_frm.Show();
            }
            catch (Exception v_e)
            {
                ExceptionHandle.Show(v_e);
            }
        }

        void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception v_e)
            {
                ExceptionHandle.Show(v_e);
            }
        }
    }
}