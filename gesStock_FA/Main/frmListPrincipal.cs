﻿using System;
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
    public partial class frmListPrincipal : Form
    {
        #region Codes

        public virtual void getData()
        {
        }

        #endregion Codes

        public frmListPrincipal()
        {
            InitializeComponent();
        }

        private void frmListPrincipal_Activated(object sender, EventArgs e)
        {
            getData();
        }
    }
}