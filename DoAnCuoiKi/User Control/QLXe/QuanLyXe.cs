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
    public partial class QuanLyXe : UserControl
    {
        public QuanLyXe()
        {
            InitializeComponent();
        }

        private void buttonDS_Click(object sender, EventArgs e)
        {
            DanhSachXe ds = new DanhSachXe();
            this.panelView.Controls.Clear();
            this.panelView.Controls.Add(ds);
        }

        private void buttonGiu_Click(object sender, EventArgs e)
        {
            DanhSachXeGiu ds = new DanhSachXeGiu();
            this.panelView.Controls.Clear();
            this.panelView.Controls.Add(ds);
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            DanhSachHopDong ds = new DanhSachHopDong();
            this.panelView.Controls.Clear();
            this.panelView.Controls.Add(ds);
        }

    
     
    }
}
