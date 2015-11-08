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
            //Hệ thống

            //Bao cao
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