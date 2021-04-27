using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        CauLenhNV clNV = new CauLenhNV();
        private void buttonEdit_Click(object sender, EventArgs e)
        {
           

        }

        private void buttonUploadImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image (*.jpg; *.png; *.gif)| *.jpg; *.png; *.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                this.pictureBoxImage.Image = Image.FromFile(opf.FileName);
            }
        }

        public bool verif()
        {
            if ((textBoxMaNV.Text.Trim() == "")
                    || (textBoxCMND.Text.Trim() == "")
                    || (textBoxDiaChi.Text.Trim() == "")
                    || (textBoxMaBP.Text.Trim() == "")
                    || (pictureBoxImage.Image == null)
                    || (textBoxNangLuc.Text.Trim() == "")
                    || (textBoxSDT.Text.Trim() == "")
                    || (textBoxNangLuc.Text.Trim() == "")
                    || (textBoxTenNV.Text.Trim() == "")
                    )
            {
                return false;
            }
            else return true;
        }

    }
}
