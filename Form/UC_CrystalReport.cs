using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_Form
{
    public partial class UC_CrystalReport : UserControl
    {
        public UC_CrystalReport()
        {
            InitializeComponent();
        }
        ketnoiCSDL ketnoi = new ketnoiCSDL();
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            DataTable dta = ketnoi.LayDulieu("Select * from DICHVU");
            cboNhapmadv.DataSource = dta;
            cboNhapmadv.DisplayMember = "IDDICHVUPHONG";
            cboNhapmadv.ValueMember = "IDDICHVUPHONG";
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            string sqltk = "Select * from DICHVU where IDDICHVUPHONG like'" + cboNhapmadv.Text + "'";
            dta = ketnoi.LayDulieu(sqltk);
            baocaodichvu1 baocaodichvu = new baocaodichvu1(); // khởi tạo báo cáo
            baocaodichvu.SetDataSource(dta);
            CRV_BAOCAO.ReportSource = baocaodichvu;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void UC_CrystalReport_Load(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            DataTable dta = ketnoi.LayDulieu("Select * from PHONGTRO");
            cboNhapmaphong.DataSource = dta;
            cboNhapmaphong.DisplayMember = "IDPHONG";
            cboNhapmaphong.ValueMember = "IDPHONG";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            string sqltk = "Select * from PHONGTRO where IDPHONG like'" + cboNhapmaphong.Text + "'";
            dta = ketnoi.LayDulieu(sqltk);
            baocaophong1 baocaophong = new baocaophong1(); // khởi tạo báo cáo
            baocaophong.SetDataSource(dta);
            CR_BangPhong.ReportSource = baocaophong;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
