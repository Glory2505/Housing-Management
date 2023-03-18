
namespace BTL_Form
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.CRbutton = new Guna.UI2.WinForms.Guna2Button();
            this.CheckoutButton = new Guna.UI2.WinForms.Guna2Button();
            this.HousingManagementButton = new Guna.UI2.WinForms.Guna2Button();
            this.TKbutton = new Guna.UI2.WinForms.Guna2Button();
            this.ServiceManagement = new Guna.UI2.WinForms.Guna2Button();
            this.CustomerManagement = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.MinimizeButton = new System.Windows.Forms.PictureBox();
            this.Date = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.PictureBox();
            this.MaximizeButton = new System.Windows.Forms.PictureBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.MainPanel = new System.Windows.Forms.Panel();
            this.uC_CrystalReport1 = new BTL_Form.UC_CrystalReport();
            this.thongKe1 = new BTL_Form.ThongKe();
            this.uC_ThanhToan1 = new BTL_Form.UC_ThanhToan();
            this.uC_Tiendichvu1 = new BTL_Form.UC_Tiendichvu();
            this.uC_QuanLyKhachHang1 = new BTL_Form.UC_QuanLyKhachHang();
            this.uC_QlyPhongTro1 = new BTL_Form.UC_QlyPhongTro();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaximizeButton)).BeginInit();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolTip2
            // 
            this.toolTip2.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip2_Popup);
            // 
            // toolTip3
            // 
            this.toolTip3.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip3_Popup);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.CRbutton);
            this.panel1.Controls.Add(this.CheckoutButton);
            this.panel1.Controls.Add(this.HousingManagementButton);
            this.panel1.Controls.Add(this.TKbutton);
            this.panel1.Controls.Add(this.ServiceManagement);
            this.panel1.Controls.Add(this.CustomerManagement);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 703);
            this.panel1.TabIndex = 3;
            // 
            // CRbutton
            // 
            this.CRbutton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.CRbutton.CheckedState.FillColor = System.Drawing.Color.White;
            this.CRbutton.CheckedState.ForeColor = System.Drawing.Color.Lime;
            this.CRbutton.CheckedState.Parent = this.CRbutton;
            this.CRbutton.CustomImages.Parent = this.CRbutton;
            this.CRbutton.FillColor = System.Drawing.Color.Empty;
            this.CRbutton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CRbutton.ForeColor = System.Drawing.Color.White;
            this.CRbutton.HoverState.Parent = this.CRbutton;
            this.CRbutton.Location = new System.Drawing.Point(4, 575);
            this.CRbutton.Name = "CRbutton";
            this.CRbutton.ShadowDecoration.Parent = this.CRbutton;
            this.CRbutton.Size = new System.Drawing.Size(221, 65);
            this.CRbutton.TabIndex = 7;
            this.CRbutton.Text = "Báo cáo";
            this.CRbutton.Click += new System.EventHandler(this.CRbutton_Click);
            // 
            // CheckoutButton
            // 
            this.CheckoutButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.CheckoutButton.CheckedState.FillColor = System.Drawing.Color.White;
            this.CheckoutButton.CheckedState.ForeColor = System.Drawing.Color.Lime;
            this.CheckoutButton.CheckedState.Parent = this.CheckoutButton;
            this.CheckoutButton.CustomImages.Parent = this.CheckoutButton;
            this.CheckoutButton.FillColor = System.Drawing.Color.Empty;
            this.CheckoutButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckoutButton.ForeColor = System.Drawing.Color.White;
            this.CheckoutButton.HoverState.Parent = this.CheckoutButton;
            this.CheckoutButton.Location = new System.Drawing.Point(10, 419);
            this.CheckoutButton.Name = "CheckoutButton";
            this.CheckoutButton.ShadowDecoration.Parent = this.CheckoutButton;
            this.CheckoutButton.Size = new System.Drawing.Size(215, 65);
            this.CheckoutButton.TabIndex = 6;
            this.CheckoutButton.Text = "Thanh toán";
            this.CheckoutButton.Click += new System.EventHandler(this.CheckoutButton_Click);
            // 
            // HousingManagementButton
            // 
            this.HousingManagementButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.HousingManagementButton.CheckedState.FillColor = System.Drawing.Color.White;
            this.HousingManagementButton.CheckedState.ForeColor = System.Drawing.Color.Lime;
            this.HousingManagementButton.CheckedState.Parent = this.HousingManagementButton;
            this.HousingManagementButton.CustomImages.Parent = this.HousingManagementButton;
            this.HousingManagementButton.FillColor = System.Drawing.Color.Empty;
            this.HousingManagementButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HousingManagementButton.ForeColor = System.Drawing.Color.White;
            this.HousingManagementButton.HoverState.Parent = this.HousingManagementButton;
            this.HousingManagementButton.Location = new System.Drawing.Point(4, 197);
            this.HousingManagementButton.Name = "HousingManagementButton";
            this.HousingManagementButton.ShadowDecoration.Parent = this.HousingManagementButton;
            this.HousingManagementButton.Size = new System.Drawing.Size(221, 65);
            this.HousingManagementButton.TabIndex = 2;
            this.HousingManagementButton.Text = "Quản lý phòng trọ";
            this.HousingManagementButton.Click += new System.EventHandler(this.HousingManagementButton_Click);
            // 
            // TKbutton
            // 
            this.TKbutton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.TKbutton.CheckedState.FillColor = System.Drawing.Color.White;
            this.TKbutton.CheckedState.ForeColor = System.Drawing.Color.Lime;
            this.TKbutton.CheckedState.Parent = this.TKbutton;
            this.TKbutton.CustomImages.Parent = this.TKbutton;
            this.TKbutton.FillColor = System.Drawing.Color.Empty;
            this.TKbutton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TKbutton.ForeColor = System.Drawing.Color.White;
            this.TKbutton.HoverState.Parent = this.TKbutton;
            this.TKbutton.Location = new System.Drawing.Point(3, 493);
            this.TKbutton.Name = "TKbutton";
            this.TKbutton.ShadowDecoration.Parent = this.TKbutton;
            this.TKbutton.Size = new System.Drawing.Size(221, 65);
            this.TKbutton.TabIndex = 5;
            this.TKbutton.Text = "Thống kê";
            this.TKbutton.Click += new System.EventHandler(this.TKbutton_Click);
            // 
            // ServiceManagement
            // 
            this.ServiceManagement.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.ServiceManagement.CheckedState.FillColor = System.Drawing.Color.White;
            this.ServiceManagement.CheckedState.ForeColor = System.Drawing.Color.Lime;
            this.ServiceManagement.CheckedState.Parent = this.ServiceManagement;
            this.ServiceManagement.CustomImages.Parent = this.ServiceManagement;
            this.ServiceManagement.FillColor = System.Drawing.Color.Empty;
            this.ServiceManagement.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServiceManagement.ForeColor = System.Drawing.Color.White;
            this.ServiceManagement.HoverState.Parent = this.ServiceManagement;
            this.ServiceManagement.Location = new System.Drawing.Point(7, 345);
            this.ServiceManagement.Name = "ServiceManagement";
            this.ServiceManagement.ShadowDecoration.Parent = this.ServiceManagement;
            this.ServiceManagement.Size = new System.Drawing.Size(215, 65);
            this.ServiceManagement.TabIndex = 4;
            this.ServiceManagement.Text = "Quản lý tiền dịch vụ";
            this.ServiceManagement.Click += new System.EventHandler(this.ServiceManagement_Click);
            // 
            // CustomerManagement
            // 
            this.CustomerManagement.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.CustomerManagement.CheckedState.FillColor = System.Drawing.Color.White;
            this.CustomerManagement.CheckedState.ForeColor = System.Drawing.Color.Lime;
            this.CustomerManagement.CheckedState.Parent = this.CustomerManagement;
            this.CustomerManagement.CustomImages.Parent = this.CustomerManagement;
            this.CustomerManagement.FillColor = System.Drawing.Color.Empty;
            this.CustomerManagement.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerManagement.ForeColor = System.Drawing.Color.White;
            this.CustomerManagement.HoverState.Parent = this.CustomerManagement;
            this.CustomerManagement.Location = new System.Drawing.Point(4, 271);
            this.CustomerManagement.Name = "CustomerManagement";
            this.CustomerManagement.ShadowDecoration.Parent = this.CustomerManagement;
            this.CustomerManagement.Size = new System.Drawing.Size(221, 65);
            this.CustomerManagement.TabIndex = 3;
            this.CustomerManagement.Text = "Quản lý Khách hàng";
            this.CustomerManagement.Click += new System.EventHandler(this.CustomerManagement_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(228, 202);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hệ thống quản lý nhà trọ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BTL_Form.Properties.Resources.apartment;
            this.pictureBox1.Location = new System.Drawing.Point(57, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.MinimizeButton);
            this.panel3.Controls.Add(this.Date);
            this.panel3.Controls.Add(this.CloseButton);
            this.panel3.Controls.Add(this.MaximizeButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(228, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(958, 56);
            this.panel3.TabIndex = 0;
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizeButton.Image = ((System.Drawing.Image)(resources.GetObject("MinimizeButton.Image")));
            this.MinimizeButton.Location = new System.Drawing.Point(784, 12);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(32, 32);
            this.MinimizeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MinimizeButton.TabIndex = 2;
            this.MinimizeButton.TabStop = false;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            this.MinimizeButton.MouseHover += new System.EventHandler(this.MinimizeButton_MouseHover);
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.BackColor = System.Drawing.Color.White;
            this.Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.Date.Location = new System.Drawing.Point(6, 12);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(19, 20);
            this.Date.TabIndex = 0;
            this.Date.Text = "!!";
            this.Date.Click += new System.EventHandler(this.label2_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.Image = ((System.Drawing.Image)(resources.GetObject("CloseButton.Image")));
            this.CloseButton.Location = new System.Drawing.Point(896, 12);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(32, 32);
            this.CloseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.CloseButton.TabIndex = 0;
            this.CloseButton.TabStop = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            this.CloseButton.MouseHover += new System.EventHandler(this.CloseButton_MouseHover);
            // 
            // MaximizeButton
            // 
            this.MaximizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaximizeButton.Image = ((System.Drawing.Image)(resources.GetObject("MaximizeButton.Image")));
            this.MaximizeButton.Location = new System.Drawing.Point(840, 12);
            this.MaximizeButton.Name = "MaximizeButton";
            this.MaximizeButton.Size = new System.Drawing.Size(33, 32);
            this.MaximizeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.MaximizeButton.TabIndex = 1;
            this.MaximizeButton.TabStop = false;
            this.MaximizeButton.Click += new System.EventHandler(this.pictureBox2_Click);
            this.MaximizeButton.MouseHover += new System.EventHandler(this.pictureBox2_MouseHover);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // MainPanel
            // 
            this.MainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainPanel.Controls.Add(this.uC_CrystalReport1);
            this.MainPanel.Controls.Add(this.thongKe1);
            this.MainPanel.Controls.Add(this.uC_ThanhToan1);
            this.MainPanel.Controls.Add(this.uC_Tiendichvu1);
            this.MainPanel.Controls.Add(this.uC_QuanLyKhachHang1);
            this.MainPanel.Controls.Add(this.uC_QlyPhongTro1);
            this.MainPanel.Location = new System.Drawing.Point(238, 62);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(936, 628);
            this.MainPanel.TabIndex = 3;
            // 
            // uC_CrystalReport1
            // 
            this.uC_CrystalReport1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uC_CrystalReport1.BackColor = System.Drawing.Color.White;
            this.uC_CrystalReport1.Location = new System.Drawing.Point(10, 6);
            this.uC_CrystalReport1.Name = "uC_CrystalReport1";
            this.uC_CrystalReport1.Size = new System.Drawing.Size(936, 628);
            this.uC_CrystalReport1.TabIndex = 5;
            // 
            // thongKe1
            // 
            this.thongKe1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.thongKe1.BackColor = System.Drawing.Color.White;
            this.thongKe1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thongKe1.Location = new System.Drawing.Point(9, 10);
            this.thongKe1.Margin = new System.Windows.Forms.Padding(6);
            this.thongKe1.Name = "thongKe1";
            this.thongKe1.Size = new System.Drawing.Size(950, 581);
            this.thongKe1.TabIndex = 4;
            // 
            // uC_ThanhToan1
            // 
            this.uC_ThanhToan1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uC_ThanhToan1.BackColor = System.Drawing.Color.White;
            this.uC_ThanhToan1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uC_ThanhToan1.Location = new System.Drawing.Point(17, 16);
            this.uC_ThanhToan1.Margin = new System.Windows.Forms.Padding(6);
            this.uC_ThanhToan1.Name = "uC_ThanhToan1";
            this.uC_ThanhToan1.Size = new System.Drawing.Size(937, 581);
            this.uC_ThanhToan1.TabIndex = 3;
            this.uC_ThanhToan1.Visible = false;
            // 
            // uC_Tiendichvu1
            // 
            this.uC_Tiendichvu1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uC_Tiendichvu1.BackColor = System.Drawing.Color.White;
            this.uC_Tiendichvu1.Location = new System.Drawing.Point(8, 7);
            this.uC_Tiendichvu1.Name = "uC_Tiendichvu1";
            this.uC_Tiendichvu1.Size = new System.Drawing.Size(936, 628);
            this.uC_Tiendichvu1.TabIndex = 2;
            // 
            // uC_QuanLyKhachHang1
            // 
            this.uC_QuanLyKhachHang1.AllowDrop = true;
            this.uC_QuanLyKhachHang1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uC_QuanLyKhachHang1.AutoScroll = true;
            this.uC_QuanLyKhachHang1.BackColor = System.Drawing.Color.White;
            this.uC_QuanLyKhachHang1.Location = new System.Drawing.Point(4, 0);
            this.uC_QuanLyKhachHang1.Name = "uC_QuanLyKhachHang1";
            this.uC_QuanLyKhachHang1.Size = new System.Drawing.Size(932, 628);
            this.uC_QuanLyKhachHang1.TabIndex = 1;
            // 
            // uC_QlyPhongTro1
            // 
            this.uC_QlyPhongTro1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uC_QlyPhongTro1.BackColor = System.Drawing.Color.White;
            this.uC_QlyPhongTro1.Location = new System.Drawing.Point(4, 4);
            this.uC_QlyPhongTro1.Name = "uC_QlyPhongTro1";
            this.uC_QlyPhongTro1.Size = new System.Drawing.Size(936, 628);
            this.uC_QlyPhongTro1.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.ClientSize = new System.Drawing.Size(1186, 703);
            this.ControlBox = false;
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaximizeButton)).EndInit();
            this.MainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2Button HousingManagementButton;
        private Guna.UI2.WinForms.Guna2Button CustomerManagement;
        private Guna.UI2.WinForms.Guna2Button TKbutton;
        private Guna.UI2.WinForms.Guna2Button ServiceManagement;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox MinimizeButton;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.PictureBox CloseButton;
        private System.Windows.Forms.PictureBox MaximizeButton;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Panel MainPanel;
        private UC_QlyPhongTro uC_QlyPhongTro1;
        private UC_QuanLyKhachHang uC_QuanLyKhachHang1;
        private Guna.UI2.WinForms.Guna2Button CheckoutButton;
        private UC_Tiendichvu uC_Tiendichvu1;
        private UC_ThanhToan uC_ThanhToan1;
        private ThongKe thongKe1;
        private Guna.UI2.WinForms.Guna2Button CRbutton;
        private UC_CrystalReport uC_CrystalReport1;
    }
}