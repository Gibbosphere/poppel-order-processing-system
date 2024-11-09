using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PoppelSystem
{
    public partial class CustomerDetailsCCForm : PoppelSystem.NavbarForm
    {
        public CustomerDetailsCCForm()
        {
            InitializeComponent();
        }

        protected override void changeHeaderLabel()
        {
            lblHeading.Text = "Create a Customer";
        }

        protected override void recentreControls()
        {
            base.recentreControls();
            pnlMain.Left = (this.ClientSize.Width - pnlMain.Width) / 2;
        }

        protected override void reColorNavBar()
        {
            base.reColorNavBar();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void CustomerDetailsCCForm_Load(object sender, EventArgs e)
        {
            showNavButtons(false);
        }
    }
}
