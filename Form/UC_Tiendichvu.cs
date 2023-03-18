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
    public partial class UC_Tiendichvu : UserControl
    {
        public UC_Tiendichvu()
        {
            InitializeComponent();
        }
        FunctionTest fn = new FunctionTest();
        ketnoiCSDL ketnoi = new ketnoiCSDL();
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

        private void UC_Tiendichvu_Load(object sender, EventArgs e)
        {
            query = "Select * From Tiendichvu";
            DataSet ds = fn.getData(query);
            DataGridView1.DataSource = ds.Tables[0];

            LaySoTang();
        
            Hienthidulieu();
        }
        private void Hienthidulieu()
        {
            SoPhong.DataBindings.Clear();
            SoPhong.DataBindings.Add("Text", DataGridView1.DataSource, "IDPHONG");

           Tangso.DataBindings.Clear();
           Tangso.DataBindings.Add("Text", DataGridView1.DataSource, "TANG");

            TenKhachHang.DataBindings.Clear();
            TenKhachHang.DataBindings.Add("Text", DataGridView1.DataSource, "TEN");

            Sodienthoai.DataBindings.Clear();
            Sodienthoai.DataBindings.Add("Text", DataGridView1.DataSource, "DIENTHOAI");

            IsGuixe.DataBindings.Clear();
            IsGuixe.DataBindings.Add("Text", DataGridView1.DataSource, "IsParking");

            IsGiatla.DataBindings.Clear();
            IsGiatla.DataBindings.Add("Text", DataGridView1.DataSource, "IsLaundrying");

            Tiendien.DataBindings.Clear();
            Tiendien.DataBindings.Add("Text", DataGridView1.DataSource, "TIENDIEN");

            Tiennuoc.DataBindings.Clear();
            Tiennuoc.DataBindings.Add("Text", DataGridView1.DataSource, "TIENNUOC");

            Tiendichvu.DataBindings.Clear();
            Tiendichvu.DataBindings.Add("Text", DataGridView1.DataSource, "TIENDICHVU");

        }
       
        public void LaySoTang()
        {
            DataTable dta = new DataTable();
            dta = ketnoi.LayDulieu("Select TANG FROM QuanLyKhachHang Group by TANG");
            Tangso.DataSource = dta;
            Tangso.DisplayMember = "TANG";
            Tangso.ValueMember = "TANG";
            Tangso.SelectedIndex=-1;
        }




       
        private void SoPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            query = "Select TEN,DIENTHOAI From Tiendichvu where IDPHONG='" + SoPhong.Text + "' ";
            DataSet ds = fn.getData(query);
            TenKhachHang.Text = ds.Tables[0].Rows[0][1].ToString();
            Sodienthoai.Text = ds.Tables[0].Rows[0][0].ToString();
        }

        private void UC_Tiendichvu_Enter(object sender, EventArgs e)
        {
            UC_Tiendichvu_Load(this, null);
        }

        private void Tangso_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            SoPhong.Items.Clear();
            TenKhachHang.Clear();
            Sodienthoai.Clear();

            //  query = "Select IDPHONG from Tiendichvu where TANG= '" + Tangso.Text + "' ";
            query = "Select IDPHONG FROM PHONGTRO where TANG= '" + Tangso.Text + "'";

            setcomboBox(query, SoPhong);
            
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            ClearAll();
        }
        public void ClearAll()
        {
            TenKhachHang.Clear();
            Sodienthoai.Clear();
            Tangso.SelectedIndex = -1;
            SoPhong.SelectedIndex = -1;
            IsGuixe.SelectedIndex=-1;
            IsGiatla.SelectedIndex=-1;

            Tiendichvu.Clear();
            Tiendien.Clear();
            Tiennuoc.Clear();
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            if (TenKhachHang.Text != "" && Sodienthoai.Text != "" && Tangso.Text != "" && SoPhong.Text != "" && IsGiatla.Text != "" && IsGuixe.Text != "" && Tiendien.Text != "" && Tiennuoc.Text != "" && Tiendichvu.Text != "")
            {
                    String IDPHONG = SoPhong.Text;
                    String TIENDIEN = Tiendien.Text;
                String TIENNUOC = Tiennuoc.Text;
                String TIENDICHVU = Tiendichvu.Text;
                String IsLaundrying = IsGiatla.Text;
                String IsParking = IsGuixe.Text;


                
                query = "Insert into DICHVU (IDPHONG, TIENDIEN, TIENNUOC, TIENDICHVU, IsLaundrying, IsParking) values ('" + IDPHONG + "','" + TIENDIEN + "',N'" + TIENNUOC + "','" + TIENDICHVU + "',N'" + IsLaundrying + "','" + IsParking + "')";
                fn.setData(query, "Thêm thành công.");

                UC_Tiendichvu_Load(this, null);
                ClearAll();
            }
            else
            {
                MessageBox.Show("Xin hãy điền dầy đủ thông tin.", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void UC_Tiendichvu_Leave(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (TenKhachHang.Text != "" && Sodienthoai.Text != "" && Tangso.Text != "" && SoPhong.Text != "" && IsGiatla.Text != "" && IsGuixe.Text != "" && Tiendien.Text != "" && Tiennuoc.Text != "" && Tiendichvu.Text != "")
            {
                String IDPHONG = SoPhong.Text;
                String TIENDIEN = Tiendien.Text;
                String TIENNUOC = Tiennuoc.Text;
                String TIENDICHVU = Tiendichvu.Text;
                String IsLaundrying = IsGiatla.Text;
                String IsParking = IsGuixe.Text;



                query = "Update DICHVU Set TIENDIEN='" + Tiendien.Text + "',TIENNUOC='" + Tiennuoc.Text + "',TIENDICHVU='" + Tiendichvu.Text + "',IsLaundrying='" + IsGiatla.Text + "',IsParking='" + IsGuixe.Text + "' where IDPHONG='" + SoPhong.Text + "'";


                fn.setData(query, "Cập nhật thành công.");

                UC_Tiendichvu_Load(this, null);

                ClearAll();
            }
            else
            {
                MessageBox.Show("Xin hãy điền dầy đủ thông tin.", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            String IDPHONG = SoPhong.Text;
            query = "Delete From DICHVU where IDPHONG='" + SoPhong.Text + "'";
            fn.setData(query, "Thực hiện xóa thành công.");

            UC_Tiendichvu_Load(this, null);
            ClearAll();
        }
        int custID;
        private void SoPhong_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            query = "Select TEN,DIENTHOAI,IDKHACHHANG From QuanLyKhachHang where IDPHONG='" + SoPhong.Text + "' ";
            DataSet ds = fn.getData(query);
            TenKhachHang.Text = ds.Tables[0].Rows[0][0].ToString();
            Sodienthoai.Text = ds.Tables[0].Rows[0][1].ToString();
            custID = int.Parse(ds.Tables[0].Rows[0][2].ToString());
        }
    }
}
