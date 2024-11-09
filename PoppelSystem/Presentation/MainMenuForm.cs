using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PoppelSystem
{
    public partial class MainMenuForm : PoppelSystem.NavbarForm
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        protected override void reColorNavBar()
        {
            base.reColorNavBar();
            btnHome.BackColor = Color.RoyalBlue;
            btnHome.ForeColor = Color.White;
        }

        protected override void changeHeaderLabel()
        {
            lblHeading.Text = "Main Menu";
        }

        protected override void recentreControls()
        {
            base.recentreControls();
            //Search
            txtSearch.Left = (this.ClientSize.Width - txtSearch.Width) / 2;
            lblSearch.Left = txtSearch.Left;
            imgSearch.Left = lblSearch.Left + lblSearch.Width + 5;

            //Main buttons
            btnMakeOrder.Left = (this.ClientSize.Width - txtSearch.Width) / 2;
            btnCreateCustomer.Left = (this.ClientSize.Width - txtSearch.Width) / 2;

            //Colleagues
            //lblColleagues.Left = ((pnlColleagues.Width - lblColleagues.Width) / 2) + pnlColleagues.Left;
            //imgColleagues.Left = ((pnlColleagues.Width - imgColleagues.Width) / 2) + pnlColleagues.Left;

            //Poppel News
            //lblNews.Left = ((pnlNews.Width - lblNews.Width) / 2) + pnlNews.Left;
            //imgNews.Left = ((pnlNews.Width - imgNews.Width) / 2) + pnlNews.Left;
        }

        protected override void btnHome_Click(object sender, EventArgs e)
        {
            
        }

        private void btnMakeOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
            SelectCustomerMO form = new SelectCustomerMO();
            form.Show();
        }

        private void btnCreateCustomer_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerDetailsCCForm form = new CustomerDetailsCCForm();
            form.Show();
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {
            showNavButtons(true);
            btnCancel.Visible = false; 
        }
    }


}
