using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gesStock_FA.Main
{
    public partial class frmPrincipal : Form
    {
        #region Codes

        public virtual void Data_Add()
        {
        }

        public virtual void Data_Update()
        {
        }

        public virtual void Data_Delete()
        {
        }

        public virtual void VerifyButtons()
        {
        }

        #endregion Codes

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control == true && e.KeyCode == Keys.A)
                btnAdd.PerformClick();
            if (e.Control == true && e.KeyCode == Keys.M)
                btnUpdate.PerformClick();
            if (e.Control == true && e.KeyCode == Keys.S)
                btnDelete.PerformClick();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Data_Update();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Data_Add();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Data_Delete();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            VerifyButtons();
        }
    }
}