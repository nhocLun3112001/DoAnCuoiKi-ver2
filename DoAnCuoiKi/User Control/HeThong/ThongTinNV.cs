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
    public partial class ThongTinNV : UserControl
    {
        public ThongTinNV()
        {
            InitializeComponent();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (this.buttonEdit.Text == "Sửa")
            {
                this.textBoxMaNV.Enabled = true;
                this.textBoxMaBP.Enabled = true;
                this.textBoxCMND.Enabled = true;
                this.textBoxSDT.Enabled = true;
                this.textBoxNangLuc.Enabled = true;
                this.textBoxDiaChi.Enabled = true;
                this.textBoxTenNV.Enabled = true;
                this.buttonUploadImg.Enabled = true;
                this.dateTimePickerBirth.Enabled = true;
                this.buttonEdit.Text = "Lưu";
            }
            else
            {

            }
        }
    }
}
