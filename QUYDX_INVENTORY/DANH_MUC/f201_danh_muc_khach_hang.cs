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
    public partial class f201_danh_muc_khach_hang : Form
    {
        public f201_danh_muc_khach_hang()
        {
            InitializeComponent();
        }

        private void f201_danh_muc_khach_hang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'iVT_Ver01DataSet3.DM_KHACH_HANG' table. You can move, or remove it, as needed.
            this.dM_KHACH_HANGTableAdapter.Fill(this.iVT_Ver01DataSet3.DM_KHACH_HANG);

        }
    }
}
