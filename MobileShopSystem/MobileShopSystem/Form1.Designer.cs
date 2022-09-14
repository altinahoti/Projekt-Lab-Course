
namespace MobileShopSystem
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnVerify = new Guna.UI2.WinForms.Guna2Button();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnExitt = new Guna.UI2.WinForms.Guna2Button();
            this.btnMinimize = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnCustomers = new Guna.UI2.WinForms.Guna2Button();
            this.btnCustomerRecords = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddNewPhone = new Guna.UI2.WinForms.Guna2Button();
            this.btnStock = new Guna.UI2.WinForms.Guna2Button();
            this.Panel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.uC_CustomerRecords1 = new MobileShopSystem.AllUserControl.UC_CustomerRecords();
            this.uC_AddNewPhone1 = new MobileShopSystem.AllUserControl.UC_AddNewPhone();
            this.uC_Customer1 = new MobileShopSystem.AllUserControl.UC_Customer();
            this.uC_Stock1 = new MobileShopSystem.AllUserControl.UC_Stock();
            this.uC_Delete1 = new MobileShopSystem.AllUserControl.UC_Delete();
            this.uC_Login1 = new MobileShopSystem.AllUserControl.UC_Login();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse5 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse6 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnVerify);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.btnExitt);
            this.panel1.Controls.Add(this.btnMinimize);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnCustomers);
            this.panel1.Controls.Add(this.btnCustomerRecords);
            this.panel1.Controls.Add(this.btnAddNewPhone);
            this.panel1.Controls.Add(this.btnStock);
            this.panel1.Location = new System.Drawing.Point(0, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1355, 66);
            this.panel1.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.CheckedState.Parent = this.btnCancel;
            this.btnCancel.CustomImages.Parent = this.btnCancel;
            this.btnCancel.FillColor = System.Drawing.Color.Magenta;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.HoverState.Parent = this.btnCancel;
            this.btnCancel.Location = new System.Drawing.Point(1186, 40);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.ShadowDecoration.Parent = this.btnCancel;
            this.btnCancel.Size = new System.Drawing.Size(84, 26);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnVerify
            // 
            this.btnVerify.CheckedState.Parent = this.btnVerify;
            this.btnVerify.CustomImages.Parent = this.btnVerify;
            this.btnVerify.FillColor = System.Drawing.Color.Magenta;
            this.btnVerify.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerify.ForeColor = System.Drawing.Color.Black;
            this.btnVerify.HoverState.Parent = this.btnVerify;
            this.btnVerify.Location = new System.Drawing.Point(1082, 40);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.ShadowDecoration.Parent = this.btnVerify;
            this.btnVerify.Size = new System.Drawing.Size(84, 26);
            this.btnVerify.TabIndex = 16;
            this.btnVerify.Text = "Verify";
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BorderColor = System.Drawing.Color.White;
            this.txtPassword.BorderThickness = 2;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.Parent = this.txtPassword;
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.FocusedState.Parent = this.txtPassword;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.HoverState.Parent = this.txtPassword;
            this.txtPassword.Location = new System.Drawing.Point(1079, 7);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '+';
            this.txtPassword.PlaceholderText = "";
            this.txtPassword.SelectedText = "";
            this.txtPassword.ShadowDecoration.Parent = this.txtPassword;
            this.txtPassword.Size = new System.Drawing.Size(191, 26);
            this.txtPassword.TabIndex = 15;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnExitt
            // 
            this.btnExitt.BackColor = System.Drawing.Color.Fuchsia;
            this.btnExitt.CheckedState.Parent = this.btnExitt;
            this.btnExitt.CustomImages.Parent = this.btnExitt;
            this.btnExitt.FillColor = System.Drawing.Color.Black;
            this.btnExitt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExitt.ForeColor = System.Drawing.Color.White;
            this.btnExitt.HoverState.Parent = this.btnExitt;
            this.btnExitt.Image = global::MobileShopSystem.Properties.Resources.cancel_50px;
            this.btnExitt.ImageSize = new System.Drawing.Size(30, 30);
            this.btnExitt.Location = new System.Drawing.Point(1322, 0);
            this.btnExitt.Name = "btnExitt";
            this.btnExitt.ShadowDecoration.Parent = this.btnExitt;
            this.btnExitt.Size = new System.Drawing.Size(25, 25);
            this.btnExitt.TabIndex = 13;
            this.btnExitt.Click += new System.EventHandler(this.btnExitt_Click_1);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Fuchsia;
            this.btnMinimize.CheckedState.Parent = this.btnMinimize;
            this.btnMinimize.CustomImages.Parent = this.btnMinimize;
            this.btnMinimize.FillColor = System.Drawing.Color.Black;
            this.btnMinimize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.HoverState.Parent = this.btnMinimize;
            this.btnMinimize.Image = global::MobileShopSystem.Properties.Resources.minimize_window_25pxdf;
            this.btnMinimize.ImageSize = new System.Drawing.Size(30, 30);
            this.btnMinimize.Location = new System.Drawing.Point(1291, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.ShadowDecoration.Parent = this.btnMinimize;
            this.btnMinimize.Size = new System.Drawing.Size(25, 25);
            this.btnMinimize.TabIndex = 14;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.BorderRadius = 20;
            this.btnDelete.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnDelete.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnDelete.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.btnDelete.CheckedState.Parent = this.btnDelete;
            this.btnDelete.CustomImages.Parent = this.btnDelete;
            this.btnDelete.FillColor = System.Drawing.Color.Fuchsia;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.HoverState.Parent = this.btnDelete;
            this.btnDelete.Image = global::MobileShopSystem.Properties.Resources.remove_25px;
            this.btnDelete.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDelete.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDelete.Location = new System.Drawing.Point(861, 27);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ShadowDecoration.Parent = this.btnDelete;
            this.btnDelete.Size = new System.Drawing.Size(211, 42);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "     Delete Phone Record";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.BorderRadius = 20;
            this.btnCustomers.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCustomers.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnCustomers.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.btnCustomers.CheckedState.Parent = this.btnCustomers;
            this.btnCustomers.CustomImages.Parent = this.btnCustomers;
            this.btnCustomers.FillColor = System.Drawing.Color.Fuchsia;
            this.btnCustomers.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCustomers.ForeColor = System.Drawing.Color.White;
            this.btnCustomers.HoverState.Parent = this.btnCustomers;
            this.btnCustomers.Image = global::MobileShopSystem.Properties.Resources.customer_25px;
            this.btnCustomers.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCustomers.ImageSize = new System.Drawing.Size(30, 30);
            this.btnCustomers.Location = new System.Drawing.Point(205, 27);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.ShadowDecoration.Parent = this.btnCustomers;
            this.btnCustomers.Size = new System.Drawing.Size(210, 42);
            this.btnCustomers.TabIndex = 10;
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnCustomerRecords
            // 
            this.btnCustomerRecords.BorderRadius = 20;
            this.btnCustomerRecords.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCustomerRecords.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnCustomerRecords.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.btnCustomerRecords.CheckedState.Parent = this.btnCustomerRecords;
            this.btnCustomerRecords.CustomImages.Parent = this.btnCustomerRecords;
            this.btnCustomerRecords.FillColor = System.Drawing.Color.Fuchsia;
            this.btnCustomerRecords.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCustomerRecords.ForeColor = System.Drawing.Color.White;
            this.btnCustomerRecords.HoverState.Parent = this.btnCustomerRecords;
            this.btnCustomerRecords.Image = global::MobileShopSystem.Properties.Resources.search_25px;
            this.btnCustomerRecords.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCustomerRecords.ImageSize = new System.Drawing.Size(30, 30);
            this.btnCustomerRecords.Location = new System.Drawing.Point(618, 27);
            this.btnCustomerRecords.Name = "btnCustomerRecords";
            this.btnCustomerRecords.ShadowDecoration.Parent = this.btnCustomerRecords;
            this.btnCustomerRecords.Size = new System.Drawing.Size(218, 42);
            this.btnCustomerRecords.TabIndex = 9;
            this.btnCustomerRecords.Text = "Customer Records";
            this.btnCustomerRecords.Click += new System.EventHandler(this.btnCustomerRecords_Click);
            // 
            // btnAddNewPhone
            // 
            this.btnAddNewPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAddNewPhone.BorderRadius = 20;
            this.btnAddNewPhone.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnAddNewPhone.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnAddNewPhone.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.btnAddNewPhone.CheckedState.Parent = this.btnAddNewPhone;
            this.btnAddNewPhone.CustomImages.Parent = this.btnAddNewPhone;
            this.btnAddNewPhone.FillColor = System.Drawing.Color.Fuchsia;
            this.btnAddNewPhone.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAddNewPhone.ForeColor = System.Drawing.Color.White;
            this.btnAddNewPhone.HoverState.Parent = this.btnAddNewPhone;
            this.btnAddNewPhone.Image = global::MobileShopSystem.Properties.Resources.mobile_25px;
            this.btnAddNewPhone.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAddNewPhone.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAddNewPhone.Location = new System.Drawing.Point(3, 28);
            this.btnAddNewPhone.Name = "btnAddNewPhone";
            this.btnAddNewPhone.ShadowDecoration.Parent = this.btnAddNewPhone;
            this.btnAddNewPhone.Size = new System.Drawing.Size(196, 42);
            this.btnAddNewPhone.TabIndex = 7;
            this.btnAddNewPhone.Text = "Add New Phone";
            this.btnAddNewPhone.Click += new System.EventHandler(this.btnAddNewPhone_Click);
            // 
            // btnStock
            // 
            this.btnStock.BorderRadius = 20;
            this.btnStock.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnStock.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnStock.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(221)))));
            this.btnStock.CheckedState.Parent = this.btnStock;
            this.btnStock.CustomImages.Parent = this.btnStock;
            this.btnStock.FillColor = System.Drawing.Color.Fuchsia;
            this.btnStock.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnStock.ForeColor = System.Drawing.Color.White;
            this.btnStock.HoverState.Parent = this.btnStock;
            this.btnStock.Image = global::MobileShopSystem.Properties.Resources.neutral_trading_25px;
            this.btnStock.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnStock.ImageSize = new System.Drawing.Size(30, 30);
            this.btnStock.Location = new System.Drawing.Point(421, 24);
            this.btnStock.Name = "btnStock";
            this.btnStock.ShadowDecoration.Parent = this.btnStock;
            this.btnStock.Size = new System.Drawing.Size(191, 45);
            this.btnStock.TabIndex = 8;
            this.btnStock.Text = "Stock";
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // Panel2
            // 
            this.Panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Panel2.Controls.Add(this.uC_CustomerRecords1);
            this.Panel2.Controls.Add(this.uC_AddNewPhone1);
            this.Panel2.Controls.Add(this.uC_Customer1);
            this.Panel2.Controls.Add(this.uC_Stock1);
            this.Panel2.Controls.Add(this.uC_Delete1);
            this.Panel2.Controls.Add(this.uC_Login1);
            this.Panel2.Location = new System.Drawing.Point(3, 81);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(1352, 497);
            this.Panel2.TabIndex = 1;
            // 
            // uC_CustomerRecords1
            // 
            this.uC_CustomerRecords1.BackColor = System.Drawing.Color.White;
            this.uC_CustomerRecords1.Location = new System.Drawing.Point(5, 5);
            this.uC_CustomerRecords1.Margin = new System.Windows.Forms.Padding(5);
            this.uC_CustomerRecords1.Name = "uC_CustomerRecords1";
            this.uC_CustomerRecords1.Size = new System.Drawing.Size(2133, 1177);
            this.uC_CustomerRecords1.TabIndex = 0;
            // 
            // uC_AddNewPhone1
            // 
            this.uC_AddNewPhone1.BackColor = System.Drawing.Color.White;
            this.uC_AddNewPhone1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uC_AddNewPhone1.Location = new System.Drawing.Point(4, 1191);
            this.uC_AddNewPhone1.Margin = new System.Windows.Forms.Padding(4);
            this.uC_AddNewPhone1.Name = "uC_AddNewPhone1";
            this.uC_AddNewPhone1.Size = new System.Drawing.Size(1502, 1065);
            this.uC_AddNewPhone1.TabIndex = 1;
            // 
            // uC_Customer1
            // 
            this.uC_Customer1.BackColor = System.Drawing.Color.White;
            this.uC_Customer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uC_Customer1.Location = new System.Drawing.Point(4, 2264);
            this.uC_Customer1.Margin = new System.Windows.Forms.Padding(4);
            this.uC_Customer1.Name = "uC_Customer1";
            this.uC_Customer1.Size = new System.Drawing.Size(1550, 800);
            this.uC_Customer1.TabIndex = 2;
            // 
            // uC_Stock1
            // 
            this.uC_Stock1.BackColor = System.Drawing.Color.White;
            this.uC_Stock1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uC_Stock1.ForeColor = System.Drawing.Color.Fuchsia;
            this.uC_Stock1.Location = new System.Drawing.Point(4, 3072);
            this.uC_Stock1.Margin = new System.Windows.Forms.Padding(4);
            this.uC_Stock1.Name = "uC_Stock1";
            this.uC_Stock1.Size = new System.Drawing.Size(1600, 1000);
            this.uC_Stock1.TabIndex = 3;
            // 
            // uC_Delete1
            // 
            this.uC_Delete1.BackColor = System.Drawing.Color.White;
            this.uC_Delete1.Location = new System.Drawing.Point(4, 4080);
            this.uC_Delete1.Margin = new System.Windows.Forms.Padding(4);
            this.uC_Delete1.Name = "uC_Delete1";
            this.uC_Delete1.Size = new System.Drawing.Size(1600, 800);
            this.uC_Delete1.TabIndex = 4;
            // 
            // uC_Login1
            // 
            this.uC_Login1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.uC_Login1.Location = new System.Drawing.Point(4, 4888);
            this.uC_Login1.Margin = new System.Windows.Forms.Padding(4);
            this.uC_Login1.Name = "uC_Login1";
            this.uC_Login1.Size = new System.Drawing.Size(1099, 738);
            this.uC_Login1.TabIndex = 5;
            this.uC_Login1.VisibleChanged += new System.EventHandler(this.uC_Login1_VisibleChanged);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 30;
            this.guna2Elipse2.TargetControl = this;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 30;
            this.guna2Elipse3.TargetControl = this.panel1;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.BorderRadius = 30;
            this.guna2Elipse4.TargetControl = this;
            // 
            // guna2Elipse5
            // 
            this.guna2Elipse5.BorderRadius = 30;
            this.guna2Elipse5.TargetControl = this.Panel2;
            // 
            // guna2Elipse6
            // 
            this.guna2Elipse6.BorderRadius = 30;
            this.guna2Elipse6.TargetControl = this.Panel2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1367, 579);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.Panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel Panel2;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnStock;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button btnCustomers;
        private Guna.UI2.WinForms.Guna2Button btnAddNewPhone;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Button btnExitt;
        private Guna.UI2.WinForms.Guna2Button btnMinimize;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private Guna.UI2.WinForms.Guna2Button btnCustomerRecords;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2Button btnVerify;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private AllUserControl.UC_CustomerRecords uC_CustomerRecords1;
        private AllUserControl.UC_AddNewPhone uC_AddNewPhone1;
        private AllUserControl.UC_Customer uC_Customer1;
        private AllUserControl.UC_Stock uC_Stock1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse5;
        private AllUserControl.UC_Delete uC_Delete1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse6;
        private AllUserControl.UC_Login uC_Login1;
    }
}