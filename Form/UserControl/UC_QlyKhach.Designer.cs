
namespace BTL_Form
{
    partial class UC_QlyKhach
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
            this.components = new System.ComponentModel.Container();
            this.Ngaythue = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.CreateNewButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.Addbutton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.TenKhachHang = new Guna.UI2.WinForms.Guna2TextBox();
            this.SoChungMinhThu = new Guna.UI2.WinForms.Guna2TextBox();
            this.Sodienthoai = new Guna.UI2.WinForms.Guna2TextBox();
            this.QueQuan = new Guna.UI2.WinForms.Guna2TextBox();
            this.IDKhachHang = new Guna.UI2.WinForms.Guna2TextBox();
            this.TienCoc = new Guna.UI2.WinForms.Guna2TextBox();
            this.NoiLamviec = new Guna.UI2.WinForms.Guna2TextBox();
            this.GiaThue = new Guna.UI2.WinForms.Guna2TextBox();
            this.LoaiPhong = new Guna.UI2.WinForms.Guna2ComboBox();
            this.SoPhong = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Tangso = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Ngaythue
            // 
            this.Ngaythue.CheckedState.Parent = this.Ngaythue;
            this.Ngaythue.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.Ngaythue.HoverState.Parent = this.Ngaythue;
            this.Ngaythue.Location = new System.Drawing.Point(434, 241);
            this.Ngaythue.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.Ngaythue.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.Ngaythue.Name = "Ngaythue";
            this.Ngaythue.ShadowDecoration.Parent = this.Ngaythue;
            this.Ngaythue.Size = new System.Drawing.Size(295, 36);
            this.Ngaythue.TabIndex = 72;
            this.Ngaythue.Value = new System.DateTime(2022, 3, 1, 0, 0, 0, 0);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label13.Location = new System.Drawing.Point(429, 297);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(256, 25);
            this.label13.TabIndex = 70;
            this.label13.Text = "ID Khách hàng(Không điền)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label12.Location = new System.Drawing.Point(843, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 25);
            this.label12.TabIndex = 69;
            this.label12.Text = "Tầng";
            // 
            // Exit
            // 
            this.Exit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Exit.Location = new System.Drawing.Point(1189, 809);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(113, 47);
            this.Exit.TabIndex = 67;
            this.Exit.Text = "Thoát";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // CreateNewButton
            // 
            this.CreateNewButton.BackColor = System.Drawing.Color.Transparent;
            this.CreateNewButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.CreateNewButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.CreateNewButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.CreateNewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateNewButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CreateNewButton.Location = new System.Drawing.Point(1189, 384);
            this.CreateNewButton.Name = "CreateNewButton";
            this.CreateNewButton.Size = new System.Drawing.Size(113, 47);
            this.CreateNewButton.TabIndex = 66;
            this.CreateNewButton.Text = "Tạo mới";
            this.CreateNewButton.UseVisualStyleBackColor = false;
            this.CreateNewButton.Click += new System.EventHandler(this.CreateNewButton_Click);
            this.CreateNewButton.Enter += new System.EventHandler(this.CreateNewButton_Enter);
            this.CreateNewButton.Leave += new System.EventHandler(this.CreateNewButton_Leave);
            // 
            // DeleteButton
            // 
            this.DeleteButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.DeleteButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.DeleteButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DeleteButton.Location = new System.Drawing.Point(1189, 697);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(113, 47);
            this.DeleteButton.TabIndex = 65;
            this.DeleteButton.Text = "Xóa";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // Addbutton
            // 
            this.Addbutton.BackColor = System.Drawing.Color.Transparent;
            this.Addbutton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Addbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.Addbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.Addbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addbutton.ForeColor = System.Drawing.Color.Black;
            this.Addbutton.Location = new System.Drawing.Point(1189, 491);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(113, 47);
            this.Addbutton.TabIndex = 64;
            this.Addbutton.Text = "Thêm";
            this.Addbutton.UseVisualStyleBackColor = false;
            this.Addbutton.Click += new System.EventHandler(this.Addbutton_Click);
            // 
            // EditButton
            // 
            this.EditButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.EditButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.EditButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.EditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.EditButton.Location = new System.Drawing.Point(1189, 589);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(113, 47);
            this.EditButton.TabIndex = 63;
            this.EditButton.Text = "Cập nhật";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(82, 384);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(948, 472);
            this.dataGridView1.TabIndex = 62;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label11.Location = new System.Drawing.Point(843, 305);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 25);
            this.label11.TabIndex = 61;
            this.label11.Text = "Gíá thuê";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label10.Location = new System.Drawing.Point(843, 202);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 25);
            this.label10.TabIndex = 59;
            this.label10.Text = "Số phòng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label9.Location = new System.Drawing.Point(843, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 25);
            this.label9.TabIndex = 57;
            this.label9.Text = "Loại phòng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label8.Location = new System.Drawing.Point(429, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 25);
            this.label8.TabIndex = 55;
            this.label8.Text = "Ngày thuê";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label7.Location = new System.Drawing.Point(429, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 25);
            this.label7.TabIndex = 53;
            this.label7.Text = "Tiền cọc";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label6.Location = new System.Drawing.Point(429, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 25);
            this.label6.TabIndex = 51;
            this.label6.Text = "Nơi làm việc";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label5.Location = new System.Drawing.Point(77, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 25);
            this.label5.TabIndex = 49;
            this.label5.Text = "Quê quán";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.Location = new System.Drawing.Point(77, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 25);
            this.label4.TabIndex = 47;
            this.label4.Text = "Số điện thoại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(77, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 25);
            this.label3.TabIndex = 45;
            this.label3.Text = "Chứng minh nhân dân";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(77, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 25);
            this.label2.TabIndex = 43;
            this.label2.Text = "Tên khách hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, -36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 25);
            this.label1.TabIndex = 42;
            this.label1.Text = "Quản lý khách hàng";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
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
            this.TenKhachHang.Location = new System.Drawing.Point(82, 47);
            this.TenKhachHang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TenKhachHang.Name = "TenKhachHang";
            this.TenKhachHang.PasswordChar = '\0';
            this.TenKhachHang.PlaceholderText = "";
            this.TenKhachHang.SelectedText = "";
            this.TenKhachHang.ShadowDecoration.Parent = this.TenKhachHang;
            this.TenKhachHang.Size = new System.Drawing.Size(273, 36);
            this.TenKhachHang.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.TenKhachHang.TabIndex = 73;
            // 
            // SoChungMinhThu
            // 
            this.SoChungMinhThu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SoChungMinhThu.DefaultText = "";
            this.SoChungMinhThu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SoChungMinhThu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SoChungMinhThu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SoChungMinhThu.DisabledState.Parent = this.SoChungMinhThu;
            this.SoChungMinhThu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SoChungMinhThu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SoChungMinhThu.FocusedState.Parent = this.SoChungMinhThu;
            this.SoChungMinhThu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.SoChungMinhThu.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SoChungMinhThu.HoverState.Parent = this.SoChungMinhThu;
            this.SoChungMinhThu.Location = new System.Drawing.Point(82, 150);
            this.SoChungMinhThu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SoChungMinhThu.Name = "SoChungMinhThu";
            this.SoChungMinhThu.PasswordChar = '\0';
            this.SoChungMinhThu.PlaceholderText = "";
            this.SoChungMinhThu.SelectedText = "";
            this.SoChungMinhThu.ShadowDecoration.Parent = this.SoChungMinhThu;
            this.SoChungMinhThu.Size = new System.Drawing.Size(273, 36);
            this.SoChungMinhThu.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.SoChungMinhThu.TabIndex = 74;
            // 
            // Sodienthoai
            // 
            this.Sodienthoai.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Sodienthoai.DefaultText = "";
            this.Sodienthoai.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Sodienthoai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Sodienthoai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Sodienthoai.DisabledState.Parent = this.Sodienthoai;
            this.Sodienthoai.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Sodienthoai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Sodienthoai.FocusedState.Parent = this.Sodienthoai;
            this.Sodienthoai.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Sodienthoai.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Sodienthoai.HoverState.Parent = this.Sodienthoai;
            this.Sodienthoai.Location = new System.Drawing.Point(82, 235);
            this.Sodienthoai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Sodienthoai.Name = "Sodienthoai";
            this.Sodienthoai.PasswordChar = '\0';
            this.Sodienthoai.PlaceholderText = "";
            this.Sodienthoai.SelectedText = "";
            this.Sodienthoai.ShadowDecoration.Parent = this.Sodienthoai;
            this.Sodienthoai.Size = new System.Drawing.Size(273, 36);
            this.Sodienthoai.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.Sodienthoai.TabIndex = 75;
            // 
            // QueQuan
            // 
            this.QueQuan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.QueQuan.DefaultText = "";
            this.QueQuan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.QueQuan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.QueQuan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.QueQuan.DisabledState.Parent = this.QueQuan;
            this.QueQuan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.QueQuan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.QueQuan.FocusedState.Parent = this.QueQuan;
            this.QueQuan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.QueQuan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.QueQuan.HoverState.Parent = this.QueQuan;
            this.QueQuan.Location = new System.Drawing.Point(82, 327);
            this.QueQuan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.QueQuan.Name = "QueQuan";
            this.QueQuan.PasswordChar = '\0';
            this.QueQuan.PlaceholderText = "";
            this.QueQuan.SelectedText = "";
            this.QueQuan.ShadowDecoration.Parent = this.QueQuan;
            this.QueQuan.Size = new System.Drawing.Size(273, 36);
            this.QueQuan.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.QueQuan.TabIndex = 76;
            // 
            // IDKhachHang
            // 
            this.IDKhachHang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.IDKhachHang.DefaultText = "";
            this.IDKhachHang.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.IDKhachHang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.IDKhachHang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.IDKhachHang.DisabledState.Parent = this.IDKhachHang;
            this.IDKhachHang.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.IDKhachHang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.IDKhachHang.FocusedState.Parent = this.IDKhachHang;
            this.IDKhachHang.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.IDKhachHang.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.IDKhachHang.HoverState.Parent = this.IDKhachHang;
            this.IDKhachHang.Location = new System.Drawing.Point(434, 327);
            this.IDKhachHang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.IDKhachHang.Name = "IDKhachHang";
            this.IDKhachHang.PasswordChar = '\0';
            this.IDKhachHang.PlaceholderText = "";
            this.IDKhachHang.SelectedText = "";
            this.IDKhachHang.ShadowDecoration.Parent = this.IDKhachHang;
            this.IDKhachHang.Size = new System.Drawing.Size(295, 36);
            this.IDKhachHang.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.IDKhachHang.TabIndex = 77;
            // 
            // TienCoc
            // 
            this.TienCoc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TienCoc.DefaultText = "";
            this.TienCoc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TienCoc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TienCoc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TienCoc.DisabledState.Parent = this.TienCoc;
            this.TienCoc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TienCoc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TienCoc.FocusedState.Parent = this.TienCoc;
            this.TienCoc.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TienCoc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TienCoc.HoverState.Parent = this.TienCoc;
            this.TienCoc.Location = new System.Drawing.Point(434, 150);
            this.TienCoc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TienCoc.Name = "TienCoc";
            this.TienCoc.PasswordChar = '\0';
            this.TienCoc.PlaceholderText = "";
            this.TienCoc.SelectedText = "";
            this.TienCoc.ShadowDecoration.Parent = this.TienCoc;
            this.TienCoc.Size = new System.Drawing.Size(295, 36);
            this.TienCoc.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.TienCoc.TabIndex = 78;
            // 
            // NoiLamviec
            // 
            this.NoiLamviec.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NoiLamviec.DefaultText = "";
            this.NoiLamviec.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.NoiLamviec.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.NoiLamviec.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NoiLamviec.DisabledState.Parent = this.NoiLamviec;
            this.NoiLamviec.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NoiLamviec.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NoiLamviec.FocusedState.Parent = this.NoiLamviec;
            this.NoiLamviec.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.NoiLamviec.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NoiLamviec.HoverState.Parent = this.NoiLamviec;
            this.NoiLamviec.Location = new System.Drawing.Point(434, 47);
            this.NoiLamviec.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NoiLamviec.Name = "NoiLamviec";
            this.NoiLamviec.PasswordChar = '\0';
            this.NoiLamviec.PlaceholderText = "";
            this.NoiLamviec.SelectedText = "";
            this.NoiLamviec.ShadowDecoration.Parent = this.NoiLamviec;
            this.NoiLamviec.Size = new System.Drawing.Size(273, 36);
            this.NoiLamviec.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.NoiLamviec.TabIndex = 79;
            // 
            // GiaThue
            // 
            this.GiaThue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.GiaThue.DefaultText = "";
            this.GiaThue.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.GiaThue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.GiaThue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.GiaThue.DisabledState.Parent = this.GiaThue;
            this.GiaThue.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.GiaThue.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.GiaThue.FocusedState.Parent = this.GiaThue;
            this.GiaThue.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.GiaThue.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.GiaThue.HoverState.Parent = this.GiaThue;
            this.GiaThue.Location = new System.Drawing.Point(848, 335);
            this.GiaThue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GiaThue.Name = "GiaThue";
            this.GiaThue.PasswordChar = '\0';
            this.GiaThue.PlaceholderText = "";
            this.GiaThue.SelectedText = "";
            this.GiaThue.ShadowDecoration.Parent = this.GiaThue;
            this.GiaThue.Size = new System.Drawing.Size(285, 36);
            this.GiaThue.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.GiaThue.TabIndex = 83;
            // 
            // LoaiPhong
            // 
            this.LoaiPhong.BackColor = System.Drawing.Color.Transparent;
            this.LoaiPhong.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.LoaiPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LoaiPhong.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LoaiPhong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LoaiPhong.FocusedState.Parent = this.LoaiPhong;
            this.LoaiPhong.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.LoaiPhong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.LoaiPhong.HoverState.Parent = this.LoaiPhong;
            this.LoaiPhong.ItemHeight = 30;
            this.LoaiPhong.ItemsAppearance.Parent = this.LoaiPhong;
            this.LoaiPhong.Location = new System.Drawing.Point(848, 150);
            this.LoaiPhong.Name = "LoaiPhong";
            this.LoaiPhong.ShadowDecoration.Parent = this.LoaiPhong;
            this.LoaiPhong.Size = new System.Drawing.Size(288, 36);
            this.LoaiPhong.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.LoaiPhong.TabIndex = 84;
            this.LoaiPhong.SelectedIndexChanged += new System.EventHandler(this.LoaiPhong_SelectedIndexChanged);
            // 
            // SoPhong
            // 
            this.SoPhong.BackColor = System.Drawing.Color.Transparent;
            this.SoPhong.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.SoPhong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SoPhong.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SoPhong.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SoPhong.FocusedState.Parent = this.SoPhong;
            this.SoPhong.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.SoPhong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.SoPhong.HoverState.Parent = this.SoPhong;
            this.SoPhong.ItemHeight = 30;
            this.SoPhong.ItemsAppearance.Parent = this.SoPhong;
            this.SoPhong.Location = new System.Drawing.Point(848, 241);
            this.SoPhong.Name = "SoPhong";
            this.SoPhong.ShadowDecoration.Parent = this.SoPhong;
            this.SoPhong.Size = new System.Drawing.Size(288, 36);
            this.SoPhong.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.SoPhong.TabIndex = 85;
            this.SoPhong.SelectedIndexChanged += new System.EventHandler(this.SoPhong_SelectedIndexChanged);
            // 
            // Tangso
            // 
            this.Tangso.BackColor = System.Drawing.Color.Transparent;
            this.Tangso.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Tangso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Tangso.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Tangso.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Tangso.FocusedState.Parent = this.Tangso;
            this.Tangso.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Tangso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.Tangso.HoverState.Parent = this.Tangso;
            this.Tangso.ItemHeight = 30;
            this.Tangso.Items.AddRange(new object[] {
            "Khu nha nghi",
            "Nha don",
            "Nha san"});
            this.Tangso.ItemsAppearance.Parent = this.Tangso;
            this.Tangso.Location = new System.Drawing.Point(848, 47);
            this.Tangso.Name = "Tangso";
            this.Tangso.ShadowDecoration.Parent = this.Tangso;
            this.Tangso.Size = new System.Drawing.Size(288, 36);
            this.Tangso.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.Tangso.TabIndex = 86;
            // 
            // UC_QlyKhach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Tangso);
            this.Controls.Add(this.SoPhong);
            this.Controls.Add(this.LoaiPhong);
            this.Controls.Add(this.GiaThue);
            this.Controls.Add(this.NoiLamviec);
            this.Controls.Add(this.TienCoc);
            this.Controls.Add(this.IDKhachHang);
            this.Controls.Add(this.QueQuan);
            this.Controls.Add(this.Sodienthoai);
            this.Controls.Add(this.SoChungMinhThu);
            this.Controls.Add(this.TenKhachHang);
            this.Controls.Add(this.Ngaythue);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.CreateNewButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.Addbutton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UC_QlyKhach";
            this.Size = new System.Drawing.Size(1464, 978);
            this.Load += new System.EventHandler(this.UC_QlyKhach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DateTimePicker Ngaythue;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button CreateNewButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button Addbutton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2TextBox NoiLamviec;
        private Guna.UI2.WinForms.Guna2TextBox TienCoc;
        private Guna.UI2.WinForms.Guna2TextBox IDKhachHang;
        private Guna.UI2.WinForms.Guna2TextBox QueQuan;
        private Guna.UI2.WinForms.Guna2TextBox Sodienthoai;
        private Guna.UI2.WinForms.Guna2TextBox SoChungMinhThu;
        private Guna.UI2.WinForms.Guna2TextBox TenKhachHang;
        private Guna.UI2.WinForms.Guna2TextBox GiaThue;
        private Guna.UI2.WinForms.Guna2ComboBox LoaiPhong;
        private Guna.UI2.WinForms.Guna2ComboBox SoPhong;
        private Guna.UI2.WinForms.Guna2ComboBox Tangso;
    }
}
