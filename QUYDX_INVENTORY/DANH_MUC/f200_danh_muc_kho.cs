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

namespace QUYDX_INVENTORY.DANH_MUC
{
    public partial class f200_danh_muc_kho : Form
    {
        public f200_danh_muc_kho()
        {
            InitializeComponent();
        }

        private void f200_danh_muc_kho_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'iVT_Ver01DataSet1.V_DM_KHO' table. You can move, or remove it, as needed.
                this.v_DM_KHOTableAdapter.Fill(this.iVT_Ver01DataSet1.V_DM_KHO);
                // TODO: This line of code loads data into the 'iVT_Ver01DataSet.DM_KHO' table. You can move, or remove it, as needed.
                //this.dM_KHOTableAdapter.Fill(this.iVT_Ver01DataSet.DM_KHO);
            }
            catch(Exception v_e)
            {
                ExceptionHandle.Show(v_e);
            }
           
        }
    }
}
