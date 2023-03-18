
namespace BTL_Form
{
    partial class UC_ThanhToan
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TienIch = new Guna.UI2.WinForms.Guna2TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TenKhachHang = new Guna.UI2.WinForms.Guna2TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.SoPhong = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TongTien = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NgayThanhToan = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thanh Toán Phòng Trọ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tìm Kiếm Tên Khách Hàng:";
            // 
            // TienIch
            // 
            this.TienIch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TienIch.DefaultText = "";
            this.TienIch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TienIch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TienIch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TienIch.DisabledState.Parent = this.TienIch;
            this.TienIch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TienIch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TienIch.FocusedState.Parent = this.TienIch;
            this.TienIch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TienIch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TienIch.HoverState.Parent = this.TienIch;
            this.TienIch.Location = new System.Drawing.Point(68, 99);
            this.TienIch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TienIch.Name = "TienIch";
            this.TienIch.PasswordChar = '\0';
            this.TienIch.PlaceholderText = "";
            this.TienIch.SelectedText = "";
            this.TienIch.ShadowDecoration.Parent = this.TienIch;
            this.TienIch.Size = new System.Drawing.Size(349, 43);
            this.TienIch.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.TienIch.TabIndex = 23;
            this.TienIch.TextChanged += new System.EventHandler(this.TienIch_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(37, 178);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(877, 243);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // TenKhachHang
            // 
            this.TenKhachHang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TenKhachHang.DefaultText = "";
            this.TenKhachHang.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TenKhachHang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TenKhachHang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TenKhachHang.DisabledState.Parent = this.TenKhachHang;
            this.TenKhachHang.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TenKhachHang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TenKhachHang.FocusedState.Parent = this.TenKhachHang;
            this.TenKhachHang.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TenKhachHang.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TenKhachHang.HoverState.Parent = this.TenKhachHang;
            this.TenKhachHang.Location = new System.Drawing.Point(45, 491);
            this.TenKhachHang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TenKhachHang.Name = "TenKhachHang";
            this.TenKhachHang.PasswordChar = '\0';
            this.TenKhachHang.PlaceholderText = "";
            this.TenKhachHang.SelectedText = "";
            this.TenKhachHang.ShadowDecoration.Parent = this.TenKhachHang;
            this.TenKhachHang.Size = new System.Drawing.Size(175, 36);
            this.TenKhachHang.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.TenKhachHang.TabIndex = 48;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label15.Location = new System.Drawing.Point(40, 461);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(160, 25);
            this.label15.TabIndex = 47;
            this.label15.Text = "Tên khách hàng:";
            // 
            // SoPhong
            // 
            this.SoPhong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SoPhong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SoPhong.DefaultText = "";
            this.SoPhong.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SoPhong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SoPhong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SoPhong.DisabledState.Parent = this.SoPhong;
            this.SoPhong.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SoPhong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SoPhong.FocusedState.Parent = this.SoPhong;
            this.SoPhong.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.SoPhong.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SoPhong.HoverState.Parent = this.SoPhong;
            this.SoPhong.Location = new System.Drawing.Point(317, 491);
            this.SoPhong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SoPhong.Name = "SoPhong";
            this.SoPhong.PasswordChar = '\0';
            this.SoPhong.PlaceholderText = "";
            this.SoPhong.SelectedText = "";
            this.SoPhong.ShadowDecoration.Parent = this.SoPhong;
            this.SoPhong.Size = new System.Drawing.Size(133, 36);
            this.SoPhong.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.SoPhong.TabIndex = 50;
            this.SoPhong.TextChanged += new System.EventHandler(this.SoPhong_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(312, 461);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 25);
            this.label3.TabIndex = 49;
            this.label3.Text = "Số Phòng:";
            // 
            // TongTien
            // 
            this.TongTien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TongTien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TongTien.DefaultText = "";
            this.TongTien.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TongTien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TongTien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TongTien.DisabledState.Parent = this.TongTien;
            this.TongTien.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TongTien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TongTien.FocusedState.Parent = this.TongTien;
            this.TongTien.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TongTien.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TongTien.HoverState.Parent = this.TongTien;
            this.TongTien.Location = new System.Drawing.Point(523, 491);
            this.TongTien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TongTien.Name = "TongTien";
            this.TongTien.PasswordChar = '\0';
            this.TongTien.PlaceholderText = "";
            this.TongTien.SelectedText = "";
            this.TongTien.ShadowDecoration.Parent = this.TongTien;
            this.TongTien.Size = new System.Drawing.Size(146, 36);
            this.TongTien.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.TongTien.TabIndex = 52;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.Location = new System.Drawing.Point(518, 461);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 25);
            this.label4.TabIndex = 51;
            this.label4.Text = "Tổng Tiền:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label5.Location = new System.Drawing.Point(676, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 25);
            this.label5.TabIndex = 53;
            this.label5.Text = "Ngày Thanh Toán";
            // 
            // NgayThanhToan
            // 
            this.NgayThanhToan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NgayThanhToan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.NgayThanhToan.Location = new System.Drawing.Point(668, 99);
            this.NgayThanhToan.Name = "NgayThanhToan";
            this.NgayThanhToan.Size = new System.Drawing.Size(213, 29);
            this.NgayThanhToan.TabIndex = 54;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button1.ForeColor = System.Drawing.Color.SeaShell;
            this.button1.Location = new System.Drawing.Point(722, 457);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 70);
            this.button1.TabIndex = 55;
            this.button1.Text = "Thanh Toán";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UC_ThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NgayThanhToan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TongTien);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SoPhong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TenKhachHang);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TienIch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "UC_ThanhToan";
            this.Size = new System.Drawing.Size(937, 581);
            this.Load += new System.EventHandler(this.UC_ThanhToan_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox TienIch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Guna.UI2.WinForms.Guna2TextBox TenKhachHang;
        private System.Windows.Forms.Label label15;
        private Guna.UI2.WinForms.Guna2TextBox SoPhong;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox TongTien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker NgayThanhToan;
        private System.Windows.Forms.Button button1;
    }
}
