using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COMMON;
using COMMON.Exception;
namespace QUYDX_INVENTORY.HE_THONG
{
    public partial class f000_dang_nhap : Form
    {
        public f000_dang_nhap()
        {
            InitializeComponent();
            format_control();
        }

        private void format_control()
        {
            set_define_event();
        }
        private void set_define_event()
        {
            m_cmd_dang_nhap.Click += m_cmd_dang_nhap_Click;
        }

        void m_cmd_dang_nhap_Click(object sender, EventArgs e)
        {
            try
            {
                MainForm main_form = new MainForm();
                main_form.ShowDialog();
                main_form.Dispose();
            }
            catch(Exception v_e)
            {
                ExceptionHandle.Show(v_e);
            }
        }
    }
}
