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
    public partial class TKDoanhThu : UserControl
    {
        public TKDoanhThu()
        {
            InitializeComponent();
        }

        private void buttonDS_Click(object sender, EventArgs e)
        {
            tkDoanhThuDinhKy tk = new tkDoanhThuDinhKy();
            this.panelView.Controls.Clear();
            this.panelView.Controls.Add(tk);
        }

        private void buttonGiu_Click(object sender, EventArgs e)
        {
            tkDoanhThuTheoNgay tk = new tkDoanhThuTheoNgay();

            this.panelView.Controls.Clear();
            this.panelView.Controls.Add(tk);
        }
    }
}
