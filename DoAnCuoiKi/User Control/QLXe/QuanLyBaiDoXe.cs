using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCuoiKi
{
    public partial class QuanLyBaiDoXe : UserControl
    {
        public QuanLyBaiDoXe()
        {
            InitializeComponent();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            ThongTinBaiDoXe edit = new ThongTinBaiDoXe();
            edit.ShowDialog();

        }
    }
}
