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
    public partial class UC_QlyKhach : UserControl
    {
        public UC_QlyKhach()
        {
            InitializeComponent();
        }
       /* FunctionTest fn = new FunctionTest();
        ketnoiCSDL ketnoi = new ketnoiCSDL();
        string query;*/
     

        private void UC_QlyKhach_Load(object sender, EventArgs e)
        {
          /*  query = "Select * From QuanLyKhachHang";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];

            setcomboBoxTest();
            Hienthidulieu();*/
        }

        public void setCombobox(string query, ComboBox combo)
        {
           /* SqlDataReader sdr = fn.getForCombo(query);
            while (sdr.Read())
            {
                for (int i = 0; i < sdr.FieldCount; i++)
                {
                    combo.Items.Add(sdr.GetValue(i).ToString());          
                }

            }
            sdr.Close();*/
        }

        private void Hienthidulieu()
        {
           /* TenKhachHang.DataBindings.Clear();
            TenKhachHang.DataBindings.Add("Text", dataGridView1.DataSource, "TEN");

            SoChungMinhThu.DataBindings.Clear();
            SoChungMinhThu.DataBindings.Add("Text", dataGridView1.DataSource, "CANCUOC");

            Sodienthoai.DataBindings.Clear();
            Sodienthoai.DataBindings.Add("Text", dataGridView1.DataSource, "DIENTHOAI");

            QueQuan.DataBindings.Clear();
            QueQuan.DataBindings.Add("Text", dataGridView1.DataSource, "QUEQUAN");

            NoiLamviec.DataBindings.Clear();
            NoiLamviec.DataBindings.Add("Text", dataGridView1.DataSource, "NOILAMVIEC");

            TienCoc.DataBindings.Clear();
            TienCoc.DataBindings.Add("Text", dataGridView1.DataSource, "TIENCOC");


            IDKhachHang.DataBindings.Clear();
            IDKhachHang.DataBindings.Add("Text", dataGridView1.DataSource, "IDKHACHHANG");

            //Ngaythue.DataBindings.Clear();
            // Ngaythue.DataBindings.Add("Text", dataGridView1.DataSource, "NGAYTHUE");              // DON'T WORK NO FUCKING DIEA ¯\_(ツ)_/¯*/
        }

        

        private void LoaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
           /* GiaThue.Clear();
            SoPhong.Items.Clear();


            query = "Select IDPHONG From PHONGTRO  where  SUCCHUA= '" + GiaThue.Text + "' and Tang= '" + Tangso.Text + "'  and TRANGTHAI='false'";

            setCombobox(query, SoPhong);*/
        }
        int RoomID;

        private void SoPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
           /* query = "Select GIATIEN,IDPHONG From PHONGTRO where IDPHONG='" + SoPhong.Text + "' ";
            DataSet ds = fn.getData(query);
            GiaThue.Text = ds.Tables[0].Rows[0][0].ToString();
            RoomID = int.Parse(ds.Tables[0].Rows[0][1].ToString());*/
        }

        private void Tangso_TextChanged(object sender, EventArgs e)
        {
           /* LoaiPhong.Items.Clear();
            SoPhong.Items.Clear();
            GiaThue.Clear();
            query = "Select SUCCHUA from PHONGTRO where Tang= '" + Tangso.Text + "' Group by SUCCHUA  ";
            setCombobox(query, LoaiPhong);*?
        }
        public void setcomboBoxTest()
        {
           /* DataTable dta = new DataTable();

            dta = ketnoi.LayDulieu("Select Tang FROM PHONGTRO  Group by Tang");
            Tangso.DataSource = dta;
            Tangso.DisplayMember = "Tang";
            Tangso.ValueMember = "Tang";*/
        }

        private void CreateNewButton_Click(object sender, EventArgs e)
        {
           // ClearAll();
        }
        public void ClearAll()
        {
           /* TenKhachHang.Clear();
            SoChungMinhThu.Clear();
            Sodienthoai.Clear();
            QueQuan.Clear();

            NoiLamviec.Clear();
            TienCoc.Clear();
            Ngaythue.ResetText();

            Tangso.SelectedIndex = -1;
            LoaiPhong.SelectedIndex = -1;
            SoPhong.SelectedIndex = -1;
            GiaThue.Clear();*/
        }

        private void CreateNewButton_Leave(object sender, EventArgs e)
        {
           // ClearAll();
        }

        private void CreateNewButton_Enter(object sender, EventArgs e)
        {
          //  UC_QlyKhach_Load(this, null);
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
          /*  if (TenKhachHang.Text != "" && SoChungMinhThu.Text != "" && Sodienthoai.Text != "" && QueQuan.Text != "" && NoiLamviec.Text != "" && TienCoc.Text != "" && Ngaythue.Text != "" && Tangso.Text != "" && LoaiPhong.Text != "" && SoPhong.Text != "" && GiaThue.Text != "")
            {
                String TEN = TenKhachHang.Text;
                string CANCUOC = SoChungMinhThu.Text;
                Int64 DIENTHOAI = Int64.Parse(Sodienthoai.Text);
                String QUEQUAN = QueQuan.Text;
                String NOILAMVIEC = NoiLamviec.Text;
                Int64 TIENCOC = Int64.Parse(TienCoc.Text);
                String NGAYTHUE = Ngaythue.Text;





                query = "Insert into KHACHHANG (IDPHONG,TEN, CANCUOC, DIENTHOAI, QUEQUAN, NOILAMVIEC, TIENCOC, NGAYTHUE) values (" + RoomID + ",'" + TEN + "'," + CANCUOC + ",'" + DIENTHOAI + "','" + QUEQUAN + "','" + NOILAMVIEC + "','" + TIENCOC + "','" + NGAYTHUE + "') Update PHONGTRO set TRANGTHAI = 'true' WHERE IDPHONG='" + SoPhong.Text + "'";

                fn.setData(query, "Phòng số:" + SoPhong.Text + "Cập nhật thành công.");
                UC_QlyKhach_Load(this, null);
                ClearAll();
            }
            else
            {
                MessageBox.Show("Xin hãy điền đầy đủ các trường.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }*/
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
         /*   if (TenKhachHang.Text != "" && SoChungMinhThu.Text != "" && Sodienthoai.Text != "" && QueQuan.Text != "" && NoiLamviec.Text != "" && TienCoc.Text != "" && Ngaythue.Text != "")
            {
                String TEN = TenKhachHang.Text;
                string CANCUOC = SoChungMinhThu.Text;
                Int64 DIENTHOAI = Int64.Parse(Sodienthoai.Text);
                String QUEQUAN = QueQuan.Text;
                String NOILAMVIEC = NoiLamviec.Text;
                Int64 TIENCOC = Int64.Parse(TienCoc.Text);
                String NGAYTHUE = Ngaythue.Text;
                string IDKHACHHANG = IDKhachHang.Text;



                // chua xong

                query = "Update KHACHHANG Set TEN='" + TenKhachHang.Text + "',CANCUOC='" + SoChungMinhThu.Text + "',DIENTHOAI='" + Sodienthoai.Text + "',QUEQUAN='" + QueQuan.Text + "',NOILAMVIEC='" + NoiLamviec.Text + "',TIENCOC='" + TienCoc.Text + "',NGAYTHUE='" + Ngaythue.Text + "'  where IDKHACHHANG='" + IDKhachHang.Text + "'";



                fn.setData(query, "Cập nhật thành công.");
                UC_QlyKhach_Load(this, null);
                ClearAll();
            }
            else
            {
                MessageBox.Show("Xin hãy điền đầy đủ các trường.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }*/
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
           /* string IDKHACHHANG = IDKhachHang.Text;
            query = "Delete From KHACHHANG where IDKHACHHANG='" + IDKhachHang.Text + "'";
            fn.setData(query, "Thực hiện xóa thành công.");

            UC_QlyKhach_Load(this, null);
            ClearAll();*/
        }

        private void Exit_Click(object sender, EventArgs e)
        {
         //   this.Visible = false;
        }
    }
}
