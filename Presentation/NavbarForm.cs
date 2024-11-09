using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoppelSystem
{
    public partial class NavbarForm : Form
    {
        public NavbarForm()
        {
            InitializeComponent();
        }

        protected virtual void showNavButtons(bool show)
        {
            btnHome.Visible = show;
            btnInventory.Visible = show;
            btnCurrentOrders.Visible = show;
        }
        protected virtual void recentreControls()
        {
            //Navbar 
            pnlNavBar.Width = this.ClientSize.Width;
            btnInventory.Left = (this.ClientSize.Width - btnInventory.Width) / 2;
            btnHome.Left = ((this.ClientSize.Width - btnInventory.Width) / 2) - (btnHome.Width * 2);
            btnCurrentOrders.Left = ((this.ClientSize.Width - btnInventory.Width) / 2) + (btnCurrentOrders.Width * 2);
            btnInventory.Top = (pnlNavBar.Height - btnInventory.Height) / 2;
            btnHome.Top = (pnlNavBar.Height - btnHome.Height) / 2;
            btnCurrentOrders.Top = (pnlNavBar.Height - btnCurrentOrders.Height) / 2;


            //Header
            pnlHeader.Width = this.ClientSize.Width;
            imgLogo.Top = ((pnlHeader.Height - imgLogo.Height) / 2);
            lblPoppel.Top = ((pnlHeader.Height - lblPoppel.Height) / 2);
            lblDept.Top = ((pnlHeader.Height - lblDept.Height) / 2) - (int)(lblDept.Height / 1.5);
            lblUserID.Top = ((pnlHeader.Height - lblUserID.Height) / 2) + (int)(lblDept.Height / 1.5);


            //Heading
            lblHeading.Left = (this.ClientSize.Width - lblHeading.Width) / 2;
            lblHeading.Top = ((pnlHeader.Height - lblHeading.Height) / 2);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            changeHeaderLabel();
            reColorNavBar();
            recentreControls();
            showNavButtons(true);
        }

        private void Form2_ResizeEnd(object sender, EventArgs e)
        {
            recentreControls();
        }

        protected virtual void changeHeaderLabel()
        {
            lblHeading.Text = "";
        }

        protected virtual void reColorNavBar()
        {
            btnHome.BackColor = Color.White;
            btnInventory.BackColor = Color.White;
            btnCurrentOrders.BackColor = Color.White;
            btnHome.ForeColor = Color.Black;
            btnInventory.ForeColor = Color.Black;
            btnCurrentOrders.ForeColor = Color.Black;
        }

        protected virtual void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenuForm form = new MainMenuForm();
            form.Show();
        }
        protected virtual void btnInventory_Click(object sender, EventArgs e)
        {
            this.Hide();
            InventoryForm form = new InventoryForm();
            form.Show();
        }
        protected virtual void btnCurrentOrders_Click(object sender, EventArgs e)
        {

        }
        
        private void NavbarForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenuForm form = new MainMenuForm();
            form.Show();
        }
    }
}
