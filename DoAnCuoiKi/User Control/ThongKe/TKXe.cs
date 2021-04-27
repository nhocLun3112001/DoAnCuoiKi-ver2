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
    public partial class TKXe : UserControl
    {
        public TKXe()
        {
            InitializeComponent();
        }

        private void buttonDS_Click(object sender, EventArgs e)
        {
            TkXeDaVaoBen tk = new TkXeDaVaoBen();
            this.panelView.Controls.Clear();
            this.panelView.Controls.Add(tk);
        }

        private void buttonGiu_Click(object sender, EventArgs e)
        {
            TkXeHienTai tk = new TkXeHienTai();
            this.panelView.Controls.Clear();
            this.panelView.Controls.Add(tk);
        }
    }
}
