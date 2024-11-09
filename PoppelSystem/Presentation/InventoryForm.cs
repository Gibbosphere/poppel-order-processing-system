using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PoppelSystem
{
    public partial class InventoryForm : PoppelSystem.NavbarForm
    {
        public InventoryForm()
        {
            InitializeComponent();
        }

        protected override void recentreControls()
        {
            base.recentreControls();
            pnlMain.Left = (this.ClientSize.Width - pnlMain.Width) / 2;
        }

        protected override void reColorNavBar()
        {
            base.reColorNavBar();
            btnInventory.BackColor = Color.RoyalBlue;
            btnInventory.ForeColor = Color.White;
        }

        protected override void changeHeaderLabel()
        {
            lblHeading.Text = "Inventory";
        }

        protected override void btnInventory_Click(object sender, EventArgs e)
        {

        }

        private void InventoryForm_Load(object sender, EventArgs e)
        {
            showNavButtons(true);
            btnCancel.Visible = false;
        }
    }
}
