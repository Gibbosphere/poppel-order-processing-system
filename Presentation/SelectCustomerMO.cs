using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PoppelSystem
{
    public partial class SelectCustomerMO : PoppelSystem.NavbarForm
    {
        public SelectCustomerMO()
        {
            InitializeComponent();
        }

        protected override void recentreControls()
        {
            base.recentreControls();
            pnlMain.Left = (this.ClientSize.Width - pnlMain.Width) / 2;
        }

        protected override void changeHeaderLabel()
        {
            lblHeading.Text = "Make an Order";
        }

        protected override void reColorNavBar()
        {
            base.reColorNavBar();
        }

        private void SelectCustomerMO_Load(object sender, EventArgs e)
        {
            showNavButtons(false);
        }
    }
}
