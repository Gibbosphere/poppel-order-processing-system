namespace PoppelSystem
{
    partial class NavbarForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NavbarForm));
            this.lblPoppel = new System.Windows.Forms.Label();
            this.pnlNavBar = new System.Windows.Forms.Panel();
            this.btnCurrentOrders = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.lblUserID = new System.Windows.Forms.Label();
            this.lblDept = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeading = new System.Windows.Forms.Label();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlNavBar.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPoppel
            // 
            this.lblPoppel.AutoSize = true;
            this.lblPoppel.Font = new System.Drawing.Font("Gill Sans MT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoppel.Location = new System.Drawing.Point(90, 9);
            this.lblPoppel.Name = "lblPoppel";
            this.lblPoppel.Size = new System.Drawing.Size(100, 34);
            this.lblPoppel.TabIndex = 4;
            this.lblPoppel.Text = "POPPEL";
            // 
            // pnlNavBar
            // 
            this.pnlNavBar.BackColor = System.Drawing.Color.White;
            this.pnlNavBar.Controls.Add(this.btnCurrentOrders);
            this.pnlNavBar.Controls.Add(this.btnHome);
            this.pnlNavBar.Controls.Add(this.btnInventory);
            this.pnlNavBar.Location = new System.Drawing.Point(0, 53);
            this.pnlNavBar.Name = "pnlNavBar";
            this.pnlNavBar.Size = new System.Drawing.Size(964, 41);
            this.pnlNavBar.TabIndex = 9;
            // 
            // btnCurrentOrders
            // 
            this.btnCurrentOrders.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCurrentOrders.BackColor = System.Drawing.Color.White;
            this.btnCurrentOrders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCurrentOrders.FlatAppearance.BorderSize = 0;
            this.btnCurrentOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCurrentOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCurrentOrders.ForeColor = System.Drawing.Color.Black;
            this.btnCurrentOrders.Location = new System.Drawing.Point(602, 4);
            this.btnCurrentOrders.Name = "btnCurrentOrders";
            this.btnCurrentOrders.Size = new System.Drawing.Size(135, 31);
            this.btnCurrentOrders.TabIndex = 2;
            this.btnCurrentOrders.Text = "Current Orders";
            this.btnCurrentOrders.UseVisualStyleBackColor = false;
            this.btnCurrentOrders.Click += new System.EventHandler(this.btnCurrentOrders_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(219, 4);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(116, 31);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnInventory
            // 
            this.btnInventory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnInventory.BackColor = System.Drawing.Color.White;
            this.btnInventory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInventory.FlatAppearance.BorderSize = 0;
            this.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventory.ForeColor = System.Drawing.Color.Black;
            this.btnInventory.Location = new System.Drawing.Point(414, 4);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(116, 31);
            this.btnInventory.TabIndex = 1;
            this.btnInventory.Text = "Inventory";
            this.btnInventory.UseVisualStyleBackColor = false;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // lblUserID
            // 
            this.lblUserID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserID.AutoSize = true;
            this.lblUserID.Location = new System.Drawing.Point(795, 31);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(108, 16);
            this.lblUserID.TabIndex = 6;
            this.lblUserID.Text = "User ID: MKG001";
            // 
            // lblDept
            // 
            this.lblDept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDept.AutoSize = true;
            this.lblDept.Location = new System.Drawing.Point(779, 8);
            this.lblDept.Name = "lblDept";
            this.lblDept.Size = new System.Drawing.Size(139, 16);
            this.lblDept.TabIndex = 5;
            this.lblDept.Text = "Marketing Department";
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.AliceBlue;
            this.pnlHeader.Controls.Add(this.lblHeading);
            this.pnlHeader.Controls.Add(this.imgLogo);
            this.pnlHeader.Controls.Add(this.lblPoppel);
            this.pnlHeader.Controls.Add(this.lblUserID);
            this.pnlHeader.Controls.Add(this.lblDept);
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(944, 55);
            this.pnlHeader.TabIndex = 10;
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Gill Sans MT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(443, 9);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(57, 34);
            this.lblHeading.TabIndex = 7;
            this.lblHeading.Text = "Nav";
            // 
            // imgLogo
            // 
            this.imgLogo.Image = ((System.Drawing.Image)(resources.GetObject("imgLogo.Image")));
            this.imgLogo.Location = new System.Drawing.Point(12, 3);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(72, 44);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLogo.TabIndex = 3;
            this.imgLogo.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(12, 449);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 32);
            this.btnCancel.TabIndex = 25;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // NavbarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(942, 493);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.pnlNavBar);
            this.Controls.Add(this.pnlHeader);
            this.Name = "NavbarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NavBar";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NavbarForm_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResizeEnd += new System.EventHandler(this.Form2_ResizeEnd);
            this.pnlNavBar.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.Label lblPoppel;
        private System.Windows.Forms.Panel pnlNavBar;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label lblDept;
        private System.Windows.Forms.Panel pnlHeader;
        protected System.Windows.Forms.Label lblHeading;
        protected System.Windows.Forms.Button btnCurrentOrders;
        protected System.Windows.Forms.Button btnHome;
        protected System.Windows.Forms.Button btnInventory;
        protected System.Windows.Forms.Button btnCancel;
    }
}