namespace BTL_Form
{
    partial class UC_CrystalReport
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.optNhapmadv = new System.Windows.Forms.RadioButton();
            this.btnThoat = new System.Windows.Forms.Button();
            this.cboNhapmadv = new System.Windows.Forms.ComboBox();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.CRV_BAOCAO = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.optNhapmaphong = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.cboNhapmaphong = new System.Windows.Forms.ComboBox();
            this.btnTimkiemPhong = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.CR_BangPhong = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(6, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(930, 620);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Click += new System.EventHandler(this.tabControl1_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(922, 594);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Báo cáo dịch vụ";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(922, 594);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Báo cáo phòng";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.CRV_BAOCAO);
            this.groupBox2.Location = new System.Drawing.Point(13, 116);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(885, 446);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.optNhapmadv);
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.cboNhapmadv);
            this.groupBox1.Controls.Add(this.btnTimkiem);
            this.groupBox1.Location = new System.Drawing.Point(17, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(881, 94);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // optNhapmadv
            // 
            this.optNhapmadv.AutoSize = true;
            this.optNhapmadv.Checked = true;
            this.optNhapmadv.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optNhapmadv.Location = new System.Drawing.Point(4, 24);
            this.optNhapmadv.Margin = new System.Windows.Forms.Padding(2);
            this.optNhapmadv.Name = "optNhapmadv";
            this.optNhapmadv.Size = new System.Drawing.Size(252, 28);
            this.optNhapmadv.TabIndex = 4;
            this.optNhapmadv.TabStop = true;
            this.optNhapmadv.Text = "Nhập mã dịch vụ phòng";
            this.optNhapmadv.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(737, 28);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(115, 34);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // cboNhapmadv
            // 
            this.cboNhapmadv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNhapmadv.FormattingEnabled = true;
            this.cboNhapmadv.Location = new System.Drawing.Point(286, 26);
            this.cboNhapmadv.Margin = new System.Windows.Forms.Padding(2);
            this.cboNhapmadv.Name = "cboNhapmadv";
            this.cboNhapmadv.Size = new System.Drawing.Size(275, 28);
            this.cboNhapmadv.TabIndex = 2;
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimkiem.Location = new System.Drawing.Point(597, 28);
            this.btnTimkiem.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(117, 34);
            this.btnTimkiem.TabIndex = 0;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // CRV_BAOCAO
            // 
            this.CRV_BAOCAO.ActiveViewIndex = -1;
            this.CRV_BAOCAO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CRV_BAOCAO.Cursor = System.Windows.Forms.Cursors.Default;
            this.CRV_BAOCAO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CRV_BAOCAO.Location = new System.Drawing.Point(2, 16);
            this.CRV_BAOCAO.Name = "CRV_BAOCAO";
            this.CRV_BAOCAO.Size = new System.Drawing.Size(881, 428);
            this.CRV_BAOCAO.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.optNhapmaphong);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.cboNhapmaphong);
            this.groupBox3.Controls.Add(this.btnTimkiemPhong);
            this.groupBox3.Location = new System.Drawing.Point(18, 19);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(864, 79);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // optNhapmaphong
            // 
            this.optNhapmaphong.AutoSize = true;
            this.optNhapmaphong.Checked = true;
            this.optNhapmaphong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optNhapmaphong.Location = new System.Drawing.Point(13, 28);
            this.optNhapmaphong.Margin = new System.Windows.Forms.Padding(2);
            this.optNhapmaphong.Name = "optNhapmaphong";
            this.optNhapmaphong.Size = new System.Drawing.Size(178, 28);
            this.optNhapmaphong.TabIndex = 4;
            this.optNhapmaphong.TabStop = true;
            this.optNhapmaphong.Text = "Nhập mã phòng";
            this.optNhapmaphong.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(670, 20);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cboNhapmaphong
            // 
            this.cboNhapmaphong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNhapmaphong.FormattingEnabled = true;
            this.cboNhapmaphong.Location = new System.Drawing.Point(205, 28);
            this.cboNhapmaphong.Margin = new System.Windows.Forms.Padding(2);
            this.cboNhapmaphong.Name = "cboNhapmaphong";
            this.cboNhapmaphong.Size = new System.Drawing.Size(275, 28);
            this.cboNhapmaphong.TabIndex = 2;
            // 
            // btnTimkiemPhong
            // 
            this.btnTimkiemPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimkiemPhong.Location = new System.Drawing.Point(537, 20);
            this.btnTimkiemPhong.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimkiemPhong.Name = "btnTimkiemPhong";
            this.btnTimkiemPhong.Size = new System.Drawing.Size(117, 34);
            this.btnTimkiemPhong.TabIndex = 0;
            this.btnTimkiemPhong.Text = "Tìm kiếm";
            this.btnTimkiemPhong.UseVisualStyleBackColor = true;
            this.btnTimkiemPhong.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.CR_BangPhong);
            this.groupBox4.Location = new System.Drawing.Point(13, 116);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(868, 436);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox2";
            // 
            // CR_BangPhong
            // 
            this.CR_BangPhong.ActiveViewIndex = -1;
            this.CR_BangPhong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CR_BangPhong.Cursor = System.Windows.Forms.Cursors.Default;
            this.CR_BangPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CR_BangPhong.Location = new System.Drawing.Point(2, 15);
            this.CR_BangPhong.Margin = new System.Windows.Forms.Padding(2);
            this.CR_BangPhong.Name = "CR_BangPhong";
            this.CR_BangPhong.Size = new System.Drawing.Size(864, 419);
            this.CR_BangPhong.TabIndex = 0;
            this.CR_BangPhong.ToolPanelWidth = 150;
            // 
            // UC_CrystalReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabControl1);
            this.Name = "UC_CrystalReport";
            this.Size = new System.Drawing.Size(936, 628);
            this.Load += new System.EventHandler(this.UC_CrystalReport_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton optNhapmadv;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ComboBox cboNhapmadv;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.TabPage tabPage2;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer CRV_BAOCAO;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton optNhapmaphong;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cboNhapmaphong;
        private System.Windows.Forms.Button btnTimkiemPhong;
        private System.Windows.Forms.GroupBox groupBox4;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer CR_BangPhong;
    }
}
