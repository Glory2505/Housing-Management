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
    public partial class UC_QlyPhongTro : UserControl
    {
        FunctionTest fn = new FunctionTest();
        ketnoiCSDL ketnoi = new ketnoiCSDL();
        String query;
        public UC_QlyPhongTro()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void UC_QlyPhongTro_Load(object sender, EventArgs e)
        {
            query = "Select * From PHONGTRO";
            DataSet ds = fn.getData(query);
            DataGridView1.DataSource = ds.Tables[0];
            Hienthidulieu();
        }
        private void Hienthidulieu()
        {
            Sophong.DataBindings.Clear();
            Sophong.DataBindings.Add("Text", DataGridView1.DataSource, "IDPHONG");

            Tangso.DataBindings.Clear();
            Tangso.DataBindings.Add("Text", DataGridView1.DataSource, "TANG");

            KieuPhong.DataBindings.Clear();
            KieuPhong.DataBindings.Add("Text", DataGridView1.DataSource, "KIEUPHONG");

            Succhua.DataBindings.Clear();
            Succhua.DataBindings.Add("Text", DataGridView1.DataSource, "SUCCHUA");

            GiaTien.DataBindings.Clear();
            GiaTien.DataBindings.Add("Text", DataGridView1.DataSource, "GIATIEN");


            TienIch.DataBindings.Clear();
            TienIch.DataBindings.Add("Text", DataGridView1.DataSource, "TENTIENICH");

            Tinhtrangphong.DataBindings.Clear();
            Tinhtrangphong.DataBindings.Add("Text", DataGridView1.DataSource, "TRANGTHAI");



        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            if (Sophong.Text != "" && Tangso.Text != "" && KieuPhong.Text != "" && TienIch.Text != "" && Succhua.Text != "" && GiaTien.Text != "")
            {
                String IDPHONG = Sophong.Text;
                String TANG = Tangso.Text;
                String KIEUPHONG = KieuPhong.Text;
                String SUCCHUA = Succhua.Text;
                String TENTIENICH = TienIch.Text;
                String GIATIEN = GiaTien.Text;

                query = "Insert into PHONGTRO (IDPHONG,TANG,KIEUPHONG,SUCCHUA,TENTIENICH,GIATIEN) values ('" + IDPHONG + "','" + TANG + "',N'" + KIEUPHONG + "','" + SUCCHUA + "',N'" + TENTIENICH + "','" + GIATIEN + "')";
                fn.setData(query, "Added.");

                UC_QlyPhongTro_Load(this, null);
                ClearAll();
            }
            else
            {
                MessageBox.Show("Xin hãy điền dầy đủ thông tin.", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void ClearAll()
        {
            Sophong.Clear();
            Tangso.Clear();
            KieuPhong.SelectedIndex = -1;
            TienIch.Clear();
            Succhua.Clear();
            GiaTien.Clear();
        }

        private void tabPage1_Leave(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void tabPage1_Enter(object sender, EventArgs e)
        {
            UC_QlyPhongTro_Load(this, null);
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (Sophong.Text != "" && Tangso.Text != "" && KieuPhong.Text != "" && TienIch.Text != "" && Succhua.Text != "" && GiaTien.Text != "" && Tinhtrangphong.Text != "")
            {
                String IDPHONG = Sophong.Text;
                String TANG = Tangso.Text;
                String KIEUPHONG = KieuPhong.Text;
                String SUCCHUA = Succhua.Text;
                String TENTIENICH = TienIch.Text;
                String GIATIEN = GiaTien.Text;
                String TRANGTHAI = Tinhtrangphong.Text;



                query = "Update PHONGTRO Set TANG='" + Tangso.Text + "',KIEUPHONG=N'" + KieuPhong.Text + "',SUCCHUA='" + Succhua.Text + "',TENTIENICH=N'" + TienIch.Text + "',GIATIEN='" + GiaTien.Text + "',TRANGTHAI='" + Tinhtrangphong.Text + "' where IDPHONG='" + Sophong.Text + "'";


                fn.setData(query, "Cập nhật thành công.");

                UC_QlyPhongTro_Load(this, null);
                ClearAll();
            }
            else
            {
                MessageBox.Show("Xin hãy điền dầy đủ thông tin.", "Cảnh báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            String IDPHONG = Sophong.Text;
            query = "Delete From PHONGTRO where IDPHONG='" + Sophong.Text + "'";
            fn.setData(query, "Thực hiện xóa thành công.");

            UC_QlyPhongTro_Load(this, null);
            ClearAll();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            query = "Select * From PHONGTRO";
            DataSet ds = fn.getData(query);
            DatagridView2.DataSource = ds.Tables[0];

            setcomboBoxTest();

        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            DataTable dta = new DataTable();
            string sqltk;
            if (OptionTimTang.Checked == true)
            {
                TKSoPhong.Text = "";
                sqltk = "Select * From PHONGTRO where TANG like '" + CboTangso.Text + "' ";
                dta = ketnoi.LayDulieu(sqltk);
            }
            else if (OptTimSophong.Checked == true)
            {
                CboTangso.SelectedIndex = -1;
                sqltk = "Select * From PHONGTRO where IDPHONG like '" + TKSoPhong.Text + "' ";
                dta = ketnoi.LayDulieu(sqltk);
            }
            DatagridView2.DataSource = dta;
        }

        private void tabPage2_Leave(object sender, EventArgs e)
        {

        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            tabPage2_Click(this, null);
        }

        private void LoadBackButton_Click(object sender, EventArgs e)
        {
            tabPage2_Click(sender, e);
        }
        public void setcomboBoxTest()
        {
            DataTable dta = new DataTable();

             dta = ketnoi.LayDulieu("Select TANG FROM PHONGTRO  Group by TANG");
            CboTangso.DataSource = dta;
            CboTangso.DisplayMember = "TANG";
            CboTangso.ValueMember = "TANG";
        }

        private void UC_QlyPhongTro_Leave(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void tabControl1_Leave(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {

        }

        private void Tinhtrangphong_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }
