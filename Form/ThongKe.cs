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
    public partial class ThongKe : UserControl
    {
        public ThongKe()
        {
            InitializeComponent();
        }

        FunctionTest fn = new FunctionTest();
        String query;

        private void ThongKe_Load(object sender, EventArgs e)
        {
            query = "Select * from HOADON";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void ThongKe_Enter(object sender, EventArgs e)
        {
            ThongKe_Load(this, null);
        }

        private void LoadBackButton_Click(object sender, EventArgs e)
        {

            ThongKe_Load(sender, e);
        }
    }
}
