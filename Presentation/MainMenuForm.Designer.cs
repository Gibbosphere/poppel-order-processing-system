namespace PoppelSystem
{
    partial class MainMenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            this.lblColleagues = new System.Windows.Forms.Label();
            this.pnlColleagues = new System.Windows.Forms.Panel();
            this.imgColleagues = new System.Windows.Forms.PictureBox();
            this.imgSearch = new System.Windows.Forms.PictureBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnCreateCustomer = new System.Windows.Forms.Button();
            this.btnMakeOrder = new System.Windows.Forms.Button();
            this.imgNews = new System.Windows.Forms.PictureBox();
            this.lblNews = new System.Windows.Forms.Label();
            this.pnlNews = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnContacts = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlColleagues.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgColleagues)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgNews)).BeginInit();
            this.pnlNews.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.Location = new System.Drawing.Point(471, 10);
            this.lblHeading.Size = new System.Drawing.Size(0, 34);
            this.lblHeading.Text = "";
            // 
            // btnCurrentOrders
            // 
            this.btnCurrentOrders.FlatAppearance.BorderSize = 0;
            this.btnCurrentOrders.Location = new System.Drawing.Point(683, 5);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.White;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.ForeColor = System.Drawing.Color.Black;
            this.btnHome.Location = new System.Drawing.Point(181, 5);
            // 
            // btnInventory
            // 
            this.btnInventory.FlatAppearance.BorderSize = 0;
            this.btnInventory.Location = new System.Drawing.Point(413, 5);
            // 
            // lblColleagues
            // 
            this.lblColleagues.AutoSize = true;
            this.lblColleagues.Font = new System.Drawing.Font("Gill Sans MT", 12F);
            this.lblColleagues.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblColleagues.Location = new System.Drawing.Point(25, 12);
            this.lblColleagues.Name = "lblColleagues";
            this.lblColleagues.Size = new System.Drawing.Size(149, 29);
            this.lblColleagues.TabIndex = 14;
            this.lblColleagues.Text = "Your Colleagues";
            // 
            // pnlColleagues
            // 
            this.pnlColleagues.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pnlColleagues.BackColor = System.Drawing.Color.Transparent;
            this.pnlColleagues.Controls.Add(this.lblColleagues);
            this.pnlColleagues.Controls.Add(this.imgColleagues);
            this.pnlColleagues.Location = new System.Drawing.Point(33, 131);
            this.pnlColleagues.Name = "pnlColleagues";
            this.pnlColleagues.Size = new System.Drawing.Size(200, 183);
            this.pnlColleagues.TabIndex = 22;
            // 
            // imgColleagues
            // 
            this.imgColleagues.Image = ((System.Drawing.Image)(resources.GetObject("imgColleagues.Image")));
            this.imgColleagues.Location = new System.Drawing.Point(16, 53);
            this.imgColleagues.Name = "imgColleagues";
            this.imgColleagues.Size = new System.Drawing.Size(170, 120);
            this.imgColleagues.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgColleagues.TabIndex = 15;
            this.imgColleagues.TabStop = false;
            // 
            // imgSearch
            // 
            this.imgSearch.Image = ((System.Drawing.Image)(resources.GetObject("imgSearch.Image")));
            this.imgSearch.Location = new System.Drawing.Point(493, 362);
            this.imgSearch.Name = "imgSearch";
            this.imgSearch.Size = new System.Drawing.Size(18, 18);
            this.imgSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgSearch.TabIndex = 16;
            this.imgSearch.TabStop = false;
            // 
            // lblSearch
            // 
            this.lblSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(331, 362);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(156, 18);
            this.lblSearch.TabIndex = 17;
            this.lblSearch.Text = "Search for a customer";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(334, 386);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(283, 22);
            this.txtSearch.TabIndex = 20;
            // 
            // btnCreateCustomer
            // 
            this.btnCreateCustomer.BackColor = System.Drawing.Color.White;
            this.btnCreateCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateCustomer.Location = new System.Drawing.Point(334, 260);
            this.btnCreateCustomer.Name = "btnCreateCustomer";
            this.btnCreateCustomer.Size = new System.Drawing.Size(283, 54);
            this.btnCreateCustomer.TabIndex = 19;
            this.btnCreateCustomer.Text = "Create a Customer";
            this.btnCreateCustomer.UseVisualStyleBackColor = false;
            this.btnCreateCustomer.Click += new System.EventHandler(this.btnCreateCustomer_Click);
            // 
            // btnMakeOrder
            // 
            this.btnMakeOrder.BackColor = System.Drawing.Color.White;
            this.btnMakeOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMakeOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMakeOrder.Location = new System.Drawing.Point(334, 184);
            this.btnMakeOrder.Name = "btnMakeOrder";
            this.btnMakeOrder.Size = new System.Drawing.Size(283, 54);
            this.btnMakeOrder.TabIndex = 18;
            this.btnMakeOrder.Text = "Make Order";
            this.btnMakeOrder.UseVisualStyleBackColor = false;
            this.btnMakeOrder.Click += new System.EventHandler(this.btnMakeOrder_Click);
            // 
            // imgNews
            // 
            this.imgNews.Image = ((System.Drawing.Image)(resources.GetObject("imgNews.Image")));
            this.imgNews.Location = new System.Drawing.Point(15, 53);
            this.imgNews.Name = "imgNews";
            this.imgNews.Size = new System.Drawing.Size(170, 120);
            this.imgNews.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgNews.TabIndex = 7;
            this.imgNews.TabStop = false;
            // 
            // lblNews
            // 
            this.lblNews.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNews.AutoSize = true;
            this.lblNews.Font = new System.Drawing.Font("Gill Sans MT", 12F);
            this.lblNews.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblNews.Location = new System.Drawing.Point(38, 4);
            this.lblNews.Name = "lblNews";
            this.lblNews.Size = new System.Drawing.Size(122, 29);
            this.lblNews.TabIndex = 7;
            this.lblNews.Text = "Poppel News";
            // 
            // pnlNews
            // 
            this.pnlNews.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pnlNews.BackColor = System.Drawing.Color.Transparent;
            this.pnlNews.Controls.Add(this.richTextBox1);
            this.pnlNews.Controls.Add(this.imgNews);
            this.pnlNews.Controls.Add(this.lblNews);
            this.pnlNews.Location = new System.Drawing.Point(701, 131);
            this.pnlNews.Name = "pnlNews";
            this.pnlNews.Size = new System.Drawing.Size(200, 289);
            this.pnlNews.TabIndex = 21;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(15, 179);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox1.Size = new System.Drawing.Size(170, 84);
            this.richTextBox1.TabIndex = 14;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // btnContacts
            // 
            this.btnContacts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnContacts.BackColor = System.Drawing.Color.White;
            this.btnContacts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContacts.Location = new System.Drawing.Point(12, 449);
            this.btnContacts.Name = "btnContacts";
            this.btnContacts.Size = new System.Drawing.Size(94, 32);
            this.btnContacts.TabIndex = 24;
            this.btnContacts.Text = "Contacts";
            this.btnContacts.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(758, 468);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "Keep calm and Pitso on";
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(942, 493);
            this.Controls.Add(this.btnContacts);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlColleagues);
            this.Controls.Add(this.imgSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnCreateCustomer);
            this.Controls.Add(this.btnMakeOrder);
            this.Controls.Add(this.pnlNews);
            this.Name = "MainMenuForm";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenuForm_Load);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.pnlNews, 0);
            this.Controls.SetChildIndex(this.btnMakeOrder, 0);
            this.Controls.SetChildIndex(this.btnCreateCustomer, 0);
            this.Controls.SetChildIndex(this.txtSearch, 0);
            this.Controls.SetChildIndex(this.lblSearch, 0);
            this.Controls.SetChildIndex(this.imgSearch, 0);
            this.Controls.SetChildIndex(this.pnlColleagues, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.btnContacts, 0);
            this.pnlColleagues.ResumeLayout(false);
            this.pnlColleagues.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgColleagues)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgNews)).EndInit();
            this.pnlNews.ResumeLayout(false);
            this.pnlNews.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblColleagues;
        private System.Windows.Forms.Panel pnlColleagues;
        private System.Windows.Forms.PictureBox imgColleagues;
        private System.Windows.Forms.PictureBox imgSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnCreateCustomer;
        private System.Windows.Forms.Button btnMakeOrder;
        private System.Windows.Forms.PictureBox imgNews;
        private System.Windows.Forms.Label lblNews;
        private System.Windows.Forms.Panel pnlNews;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnContacts;
        private System.Windows.Forms.Label label1;
    }
}
