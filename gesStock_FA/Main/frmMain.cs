using gesStock_FA.Sub;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tools;

namespace gesStock_FA.Main
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnTest_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //frmList_Fournisseur frm = new frmList_Fournisseur();
            frmList_BL frm = new frmList_BL();
            iTools.openForm(this, frm, mdiManager);
        }

        private void btnTest2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frm_Fournisseur frm = new frm_Fournisseur();
            iTools.openForm(this, frm, mdiManager);
        }
    }
}