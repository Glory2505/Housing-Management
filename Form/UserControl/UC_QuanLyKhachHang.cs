using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BTL_Form
{
    public partial class UC_QuanLyKhachHang : UserControl
    {
        public UC_QuanLyKhachHang()
        {
            InitializeComponent();
        }
        ketnoiCSDL ketnoi = new ketnoiCSDL();
        FunctionTest fn = new FunctionTest();
        String query;

        public void setcomboBox(string query, ComboBox combo)
        {
             SqlDataReader sdr = fn.getForCombo(query);
             while (sdr.Read())
             {
                 for (int i = 0; i < sdr.FieldCount; i++)
                 {
                     combo.Items.Add(sdr.GetValue(i).ToString());          
                 }

             }
             sdr.Close();

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void UC_QuanLyKhachHang_Load(object sender, EventArgs e)
        {
            query = "Select * From QuanLyKhachHang";
            DataSet ds = fn.getData(query);
            DataGridView1.DataSource = ds.Tables[0];


            LoadTK();
            setcomboBoxTest();
            Hienthidulieu();

        }
        private void Hienthidulieu()
        {
            TenKhachHang.DataBindings.Clear();
            TenKhachHang.DataBindings.Add("Text", DataGridView1.DataSource, "TEN");

            Sodienthoai.DataBindings.Clear();
            Sodienthoai.DataBindings.Add("Text", DataGridView1.DataSource, "DIENTHOAI");

            Chungminhthu.DataBindings.Clear();
            Chungminhthu.DataBindings.Add("Text", DataGridView1.DataSource, "CANCUOC");

            QueQuan.DataBindings.Clear();
            QueQuan.DataBindings.Add("Text", DataGridView1.DataSource, "QUEQUAN");

            NoiLamviec.DataBindings.Clear();
            NoiLamviec.DataBindings.Add("Text", DataGridView1.DataSource, "NOILAMVIEC");

            TienCoc.DataBindings.Clear();
            TienCoc.DataBindings.Add("Text", DataGridView1.DataSource, "TIENCOC");

            IDKhach.DataBindings.Clear();
            IDKhach.DataBindings.Add("Text", DataGridView1.DataSource, "IDKHACHHANG");


            //Ngaythue.DataBindings.Clear();
            // Ngaythue.DataBindings.Add("Text", dataGridView1.DataSource, "NGAYTHUE");              // DON'T WORK NO FUCKING DIEA ¯\_(ツ)_/¯
        }
        int RoomID;

        private void KieuPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
              GiaTien.Clear();
            SoPhong.Items.Clear();


            query = "Select IDPHONG From PHONGTRO  where  KIEUPHONG= N'" + KieuPhong.Text + "' and TANG= '" + Tangso.Text + "'  and TRANGTHAI='available'";

            setcomboBox(query, SoPhong);

        }

        private void SoPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
             query = "Select GIATIEN,IDPHONG From PHONGTRO where IDPHONG='" + SoPhong.Text + "' ";
             DataSet ds = fn.getData(query);
             GiaTien.Text = ds.Tables[0].Rows[0][0].ToString();
             RoomID = int.Parse(ds.Tables[0].Rows[0][1].ToString());

        }

        private void Tangso_SelectedIndexChanged(object sender, EventArgs e)
        {
            KieuPhong.Items.Clear();
            SoPhong.Items.Clear();
            GiaTien.Clear();
            query = "Select KIEUPHONG from PHONGTRO where TANG= '" + Tangso.Text + "' Group by KIEUPHONG  ";
            setcomboBox(query, KieuPhong);

        }
        public void setcomboBoxTest()
        {
            DataTable dta = new DataTable();

             dta = ketnoi.LayDulieu("Select TANG FROM PHONGTRO  Group by TANG");
             Tangso.DataSource = dta;
             Tangso.DisplayMember = "TANG";
             Tangso.ValueMember = "TANG";
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            ClearAll();
        }
        public void ClearAll()
        {
             TenKhachHang.Clear();
             Sodienthoai.Clear();
             Chungminhthu.Clear();
             QueQuan.Clear();

             NoiLamviec.Clear();
             TienCoc.Clear();
             NgayThue.ResetText();

             Tangso.SelectedIndex = -1;
             KieuPhong.SelectedIndex = -1;
             SoPhong.SelectedIndex = -1;
             GiaTien.Clear();
        }

        private void UC_QuanLyKhachHang_Enter(object sender, EventArgs e)
        {
            UC_QuanLyKhachHang_Load(this, null);
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
             if (TenKhachHang.Text != "" && Chungminhthu.Text != "" && Sodienthoai.Text != "" && QueQuan.Text != "" && NoiLamviec.Text != "" && TienCoc.Text != "" && NgayThue.Text != "" && Tangso.Text != "" && KieuPhong.Text != "" && SoPhong.Text != "" && GiaTien.Text != "")
            {
                String TEN = TenKhachHang.Text;
                string CANCUOC = Chungminhthu.Text;
                Int64 DIENTHOAI = Int64.Parse(Sodienthoai.Text);
                String QUEQUAN = QueQuan.Text;
                String NOILAMVIEC = NoiLamviec.Text;
                Int64 TIENCOC = Int64.Parse(TienCoc.Text);
                String NGAYTHUE = NgayThue.Text;





                query = "Insert into KHACHHANG (IDPHONG,TEN, CANCUOC, DIENTHOAI, QUEQUAN, NOILAMVIEC, TIENCOC, NGAYTHUE) values (" + RoomID + ",N'" + TEN + "'," + CANCUOC + ",'" + DIENTHOAI + "',N'" + QUEQUAN + "',N'" + NOILAMVIEC + "','" + TIENCOC + "','" + NGAYTHUE + "') Update PHONGTRO set TRANGTHAI = 'NA' WHERE IDPHONG='" + SoPhong.Text + "'";

                fn.setData(query, "Phòng số:" + SoPhong.Text + " Cập nhật thành công.");
                UC_QuanLyKhachHang_Load(this, null);
                ClearAll();
            }
            else
            {
                MessageBox.Show("Xin hãy điền đầy đủ các trường.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (TenKhachHang.Text != "" && Chungminhthu.Text != "" && Sodienthoai.Text != "" && QueQuan.Text != "" && NoiLamviec.Text != "" && TienCoc.Text != "" && NgayThue.Text != "")
{
    String TEN = TenKhachHang.Text;
    string CANCUOC = Chungminhthu.Text;
    Int64 DIENTHOAI = Int64.Parse(Sodienthoai.Text);
    String QUEQUAN = QueQuan.Text;
    String NOILAMVIEC = NoiLamviec.Text;
    Int64 TIENCOC = Int64.Parse(TienCoc.Text);
    String NGAYTHUE = NgayThue.Text;
    string IDKHACHHANG = IDKhach.Text;


    query = "Update KHACHHANG Set TEN=N'" + TenKhachHang.Text + "',CANCUOC='" + Chungminhthu.Text + "',DIENTHOAI='" + Sodienthoai.Text + "',QUEQUAN=N'" + QueQuan.Text + "',NOILAMVIEC=N'" + NoiLamviec.Text + "',TIENCOC='" + TienCoc.Text + "',NGAYTHUE='" + NgayThue.Text + "'  where IDKHACHHANG='" + IDKhach.Text + "'";



    fn.setData(query, "Cập nhật thành công.");
                UC_QuanLyKhachHang_Load(this, null);
                ClearAll();
}
else
{
    MessageBox.Show("Xin hãy điền đầy đủ các trường.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
}

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
             string IDKHACHHANG = IDKhach.Text;
            query = "Delete From KHACHHANG where IDKHACHHANG='" + IDKhach.Text + "'";

            fn.setData(query, "Thực hiện xóa thành công.");

            UC_QuanLyKhachHang_Load(this, null);
            ClearAll();

        }

        private void UC_QuanLyKhachHang_Leave(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {

        }

        private void TabTKKhach_Click(object sender, EventArgs e)
        {

        }

        private void LoadTK()
        {
            query = "Select * From QuanLyKhachHang";
            DataSet ds = fn.getData(query);
            DatagridView2.DataSource = ds.Tables[0];
            LaySoTang();
            LaySoPhong();

        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            string sqltk;
            if (OptionTimSDT.Checked == true)
            {
                TKSoPhong.SelectedIndex = -1;
                TKTang.SelectedIndex = -1;
                TKTenKhach.Text = "";

                sqltk = "Select * From QuanLyKhachHang where DIENTHOAI like '" + TKSoDT.Text + "' ";
                dta = ketnoi.LayDulieu(sqltk);
            }
            else if (OptTimTen.Checked == true)
            {
                TKSoDT.Text = "";
                TKSoPhong.SelectedIndex = -1;
                TKTang.SelectedIndex = -1;

                sqltk = "Select * From QuanLyKhachHang where TEN like '%" + TKTenKhach.Text + "%' ";
                dta = ketnoi.LayDulieu(sqltk);
            }
            else if (OptionTimSoPhong.Checked == true)
            {
                TKSoDT.Text = "";
                TKTenKhach.Text = "";
                TKTang.SelectedIndex = -1;


                sqltk = "Select * From QuanLyKhachHang where IDPHONG like '" + TKSoPhong.Text + "' ";
                dta = ketnoi.LayDulieu(sqltk);
            }
            else if (OpTionTimTang.Checked == true)
            {
                TKSoDT.Text = "";
                TKTenKhach.Text = "";
                TKSoPhong.SelectedIndex = -1;

                sqltk = "Select * From QuanLyKhachHang where TANG like '" + TKTang.Text + "' ";
                dta = ketnoi.LayDulieu(sqltk);
            }
            else
            {
                MessageBox.Show("Chua lua chon muc tim kiem.", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            DatagridView2.DataSource = dta;
        }

        public void LaySoPhong()
        {
            DataTable dta = new DataTable();

            dta = ketnoi.LayDulieu("Select IDPHONG FROM QuanLyKhachHang  ");
            TKSoPhong.DataSource = dta;
            TKSoPhong.DisplayMember = "IDPHONG";
            TKSoPhong.ValueMember = "IDPHONG";
        }

        public void LaySoTang()
        {
            DataTable dta = new DataTable();

            dta = ketnoi.LayDulieu("Select TANG FROM QuanLyKhachHang Group by TANG");
            TKTang.DataSource = dta;
            TKTang.DisplayMember = "TANG";
            TKTang.ValueMember = "TANG";
        }

        private void LoadBackButton_Click(object sender, EventArgs e)
        {
            UC_QuanLyKhachHang_Load(sender, e);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
