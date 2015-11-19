using BSL.COMMOM_SERVICE;
using BSL.HANG_SERVICE;
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
    public partial class f500_hang_trong_kho : Form
    {
        public f500_hang_trong_kho()
        {
            InitializeComponent();
            format_control();
        }
        private void fill_data_to_dm_kho()
        {
            var source = BS_KHO.Instance.GetListKho();
            m_sle_chuyen_toi_kho.Properties.DataSource = source;
        }
        private void fill_data_to_grid()
        {
            var source = BS_MAT_HANG.Instance.LayDanhSachHangTrongKho((long) m_sle_chuyen_toi_kho.EditValue);
            m_grc_hang.DataSource = source;
            m_grc_hang.RefreshDataSource();
        }
        private void format_control()
        {
            set_define_event();
        }



        private void set_define_event()
        {
            Load += f500_hang_trong_kho_Load;
            
        }

        void f500_hang_trong_kho_Load(object sender, EventArgs e)
        {
            try
            {
                fill_data_to_dm_kho();
                m_sle_chuyen_toi_kho.EditValueChanged += m_sle_chuyen_toi_kho_EditValueChanged;
            }
            catch(Exception)
            {
                throw;
            }
        }

        void m_sle_chuyen_toi_kho_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                fill_data_to_grid();
            }
            catch(Exception)
            {
                
                throw;
            }
        }
    }
}
