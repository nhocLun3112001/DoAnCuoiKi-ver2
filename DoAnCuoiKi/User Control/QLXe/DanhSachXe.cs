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
    public partial class DanhSachXe : UserControl
    {
        public DanhSachXe()
        {
            InitializeComponent();
        }

        private void buttonGiu_Click(object sender, EventArgs e)
        {
            GiuXe giu = new GiuXe();
            giu.ShowDialog();
        }
    }
}
