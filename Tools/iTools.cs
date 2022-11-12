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
        public static void openForm(Form frm, Form frmMain)
        {
            bool isActive = false;
            foreach (var item in frmMain.MdiChildren)
            {
                if (item.Name == frm.Name)
                {
                    frm.Activate();
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