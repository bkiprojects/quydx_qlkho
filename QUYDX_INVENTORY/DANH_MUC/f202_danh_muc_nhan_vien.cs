using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUYDX_INVENTORY.DANH_MUC
{
    public partial class f202_danh_muc_nhan_vien : Form
    {
        public f202_danh_muc_nhan_vien()
        {
            InitializeComponent();
        }

        private void f202_danh_muc_nhan_vien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iVT_Ver01DataSet2.DM_NHAN_VIEN' table. You can move, or remove it, as needed.
            this.dM_NHAN_VIENTableAdapter.Fill(this.iVT_Ver01DataSet2.DM_NHAN_VIEN);

        }
    }
}
