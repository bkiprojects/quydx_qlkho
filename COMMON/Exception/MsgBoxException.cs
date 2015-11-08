using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace COMMON.Exception
{
    public partial class MsgBoxException : Form
    {
        public MsgBoxException()
        {
            InitializeComponent();
        }
        public MsgBoxException(System.Exception ip_exception)
        {
            InitializeComponent();
            m_lbl_msg.Text = ip_exception.Message;
        }


        private void m_cmd_exit_Click(object sender, EventArgs e)
        {
            try
            {
                Dispose();
            }
            catch(System.Exception)
            {
                XtraMessageBox.Show("Có lỗi xảy ra");
            }
        }
    }
}