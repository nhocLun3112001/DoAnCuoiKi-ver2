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
    public partial class QuanLyTk : UserControl
    {
        public QuanLyTk()
        {
            InitializeComponent();
        }

        private void buttonTaoTk_Click(object sender, EventArgs e)
        {
            TaoTK tk = new TaoTK();
            this.panelMain.Controls.Clear();
            this.panelMain.Controls.Add(tk);
        }

        private void buttonSuaTk_Click(object sender, EventArgs e)
        {
            SuaTk tk = new SuaTk();
            this.panelMain.Controls.Clear();
            this.panelMain.Controls.Add(tk);
        }
    }
}
