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
    public partial class HopDong : Form
    {
        public HopDong()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            NoiDungHD nd = new NoiDungHD();
            nd.ShowDialog();
        }
    }
}
