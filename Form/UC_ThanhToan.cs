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
    public partial class UC_ThanhToan : UserControl
    {
        

        public UC_ThanhToan()
        {
            InitializeComponent();
        }

        FunctionTest fn = new FunctionTest();
        String query;

        private void UC_ThanhToan_Load(object sender, EventArgs e)
        {
            query = "Select * from ThanhToanTien";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void TienIch_TextChanged(object sender, EventArgs e)
        {
            if(TienIch.Text != "")
            {
                query = "Select * From ThanhToanTien where TEN like '%" + TienIch.Text + "%'";
                DataSet ds = fn.getData(query);
                dataGridView1.DataSource = ds.Tables[0];
            } else
            {
                UC_ThanhToan_Load(this, null);
            }
        }

       
        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // 
        }

        private void SoPhong_TextChanged(object sender, EventArgs e)
        {
            // 
        }

        String id;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                TenKhachHang.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                SoPhong.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                TongTien.Text = dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TenKhachHang.Text != "")
            {
                if (MessageBox.Show("Are you sure?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    query = "insert into HOADON (IDPHONG, IDKHACHHANG, TENKHACHHANG, NGAYTHANHTOAN, THANHTOAN) values (" + SoPhong.Text +", " + id + ", N'" + TenKhachHang.Text + "', '" + NgayThanhToan.Value + "', " + TongTien.Text + ")";
                    fn.setData(query, "Thanh toán thành công");
                    UC_ThanhToan_Load(this, null);
                    ClearAll();
                }
            }
            else
            {
                MessageBox.Show("Chưa lựa chọn khách hàng!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void ClearAll()
        {
            TenKhachHang.Clear();
            SoPhong.Clear();
            TongTien.Clear();
            NgayThanhToan.ResetText();
        }

        private void UC_ThanhToan_Load_1(object sender, EventArgs e)
        {
            query = "Select * from ThanhToanTien";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
