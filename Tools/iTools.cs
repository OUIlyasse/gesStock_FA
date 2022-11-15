using DevExpress.XtraTabbedMdi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tools
{
    public static class iTools
    {
        public static void openForm(Form frmMain, Form frm, XtraTabbedMdiManager mdiManager)
        {
            bool isActive = false;
            foreach (var item in frmMain.MdiChildren)
            {
                if (item.Name == frm.Name)
                {
                    mdiManager.Pages[item].MdiChild.Activate();
                    isActive = true;
                }
            }
            if (!isActive)
            {
                frm.MdiParent = frmMain;
                frm.Show();
            }
            return;
        }
    }
}