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
    public partial class FormMain : Form
    {

      
        public FormMain()
        {
            InitializeComponent();


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           
            if ( WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
            this.WindowState = FormWindowState.Normal;

        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(MaximizeButton, "Maximize");
        }

        private void toolTip2_Popup(object sender, PopupEventArgs e)
        {

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            System.Windows.Forms.Application.ExitThread();
        }

        private void CloseButton_MouseHover(object sender, EventArgs e)
        {
            toolTip2.SetToolTip(CloseButton, "Exit");
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
          
        }

        private void toolTip3_Popup(object sender, PopupEventArgs e)
        {

        }

        private void MinimizeButton_MouseHover(object sender, EventArgs e)
        {
            toolTip3.SetToolTip(MinimizeButton, "Minimize");
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            timer1.Start();
            uC_QlyPhongTro1.Visible = false;
            uC_QuanLyKhachHang1.Visible = false;
            uC_Tiendichvu1.Visible=false;
            thongKe1.Visible = false;
            uC_ThanhToan1.Visible = false;
            uC_CrystalReport1.Visible = false;
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Date.Text = DateTime.Now.ToString("dd-MMM-yyyy hh:mm:ss tt");
        }

     

        private void HousingManagementButton_Click(object sender, EventArgs e)
        {
            uC_QlyPhongTro1.Visible = true;
            uC_QuanLyKhachHang1.Visible = false;
            uC_Tiendichvu1.Visible=false;
            uC_QlyPhongTro1.BringToFront();
            uC_ThanhToan1.Visible = false;
            thongKe1.Visible = false;
            uC_CrystalReport1.Visible = false;
        }

        private void CustomerManagement_Click(object sender, EventArgs e)
        {

           uC_QuanLyKhachHang1.Visible = true;
           uC_QlyPhongTro1.Visible = false;
            uC_Tiendichvu1.Visible=false;
            uC_QuanLyKhachHang1.BringToFront();
            uC_ThanhToan1.Visible = false;
            thongKe1.Visible = false;
            uC_CrystalReport1.Visible = false;
        }

        private void ServiceManagement_Click(object sender, EventArgs e)
        {
            uC_Tiendichvu1.Visible=true;
            uC_Tiendichvu1.BringToFront();
            uC_QlyPhongTro1.Visible = false;
            uC_QuanLyKhachHang1.Visible = false;
            uC_ThanhToan1.Visible = false;
            thongKe1.Visible = false;
            uC_CrystalReport1.Visible = false;
        }

        private void TKbutton_Click(object sender, EventArgs e) // THỐNG KÊ
        {
            thongKe1.Visible = true;
            thongKe1.BringToFront();
            uC_QlyPhongTro1.Visible = false;
            uC_QuanLyKhachHang1.Visible = false;
            uC_Tiendichvu1.Visible = false;
            uC_ThanhToan1.Visible = false;
            uC_CrystalReport1.Visible = false;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CheckoutButton_Click(object sender, EventArgs e)
        {
            uC_ThanhToan1.Visible = true;
            uC_ThanhToan1.BringToFront();
            uC_QlyPhongTro1.Visible = false;
            uC_QuanLyKhachHang1.Visible = false;
            uC_Tiendichvu1.Visible = false;
            thongKe1.Visible = false;
            uC_CrystalReport1.Visible = false;
        }

        private void CRbutton_Click(object sender, EventArgs e)
        {
            uC_QlyPhongTro1.Visible = false;
            uC_QuanLyKhachHang1.Visible = false;
            uC_Tiendichvu1.Visible = false;
            thongKe1.Visible = false;
            uC_ThanhToan1.Visible = false;
            uC_CrystalReport1.Visible = true;
            uC_CrystalReport1.BringToFront();
        }
    }
}
