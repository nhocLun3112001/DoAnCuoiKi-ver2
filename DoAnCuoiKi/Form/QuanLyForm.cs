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
    public partial class QuanLyForm : Form
    {
        public QuanLyForm()
        {
            InitializeComponent();
        }

        private void buttonThongTin_Click(object sender, EventArgs e)
        {
            ThongTinNV info = new ThongTinNV();
            this.paneMain.Controls.Clear();
            this.paneMain.Controls.Add(info);
        }

        private void buttonDoiMK_Click(object sender, EventArgs e)
        {
            DoiMK mk = new DoiMK();
            this.paneMain.Controls.Clear();
            this.paneMain.Controls.Add(mk);
        }

        private void buttonDS_Click(object sender, EventArgs e)
        {
            DanhSachNV ds = new DanhSachNV();
            this.paneMain.Controls.Clear();
            this.paneMain.Controls.Add(ds);
        }

        private void buttonDSBP_Click(object sender, EventArgs e)
        {
            BoPhan bp = new BoPhan();
            this.paneMain.Controls.Clear();
            this.paneMain.Controls.Add(bp);
        }

        private void buttonQLTK_Click(object sender, EventArgs e)
        {
            QuanLyTk qltk = new QuanLyTk();
            this.paneMain.Controls.Clear();
            this.paneMain.Controls.Add(qltk);
        }

        private void buttonQLXe_Click(object sender, EventArgs e)
        {
            QuanLyXe qlx = new QuanLyXe();
            this.paneMain.Controls.Clear();
            this.paneMain.Controls.Add(qlx);
        }

        private void buttonQLVe_Click(object sender, EventArgs e)
        {
            QuanLyVe qlve = new QuanLyVe();
            this.paneMain.Controls.Clear();
            this.paneMain.Controls.Add(qlve);
        }

        private void buttonBaiXe_Click(object sender, EventArgs e)
        {
            QuanLyBaiDoXe qlbd = new QuanLyBaiDoXe();
            this.paneMain.Controls.Clear();
            this.paneMain.Controls.Add(qlbd);
        }

        private void buttonQLCV_Click(object sender, EventArgs e)
        {
            QuanLyCongViec qlcv = new QuanLyCongViec();
            this.paneMain.Controls.Clear();
            this.paneMain.Controls.Add(qlcv);
        }

        private void buttonDSHD_Click(object sender, EventArgs e)
        {
            DanhSachHopDong ds = new DanhSachHopDong();
            this.paneMain.Controls.Clear();
            this.paneMain.Controls.Add(ds);
        }

       

        private void buttonTKHopDong_Click(object sender, EventArgs e)
        {
            TKHopDong tkHD = new TKHopDong();
            this.paneMain.Controls.Clear();
            this.paneMain.Controls.Add(tkHD);
        }

        private void buttonTKXe_Click(object sender, EventArgs e)
        {
            TKXe tkXe = new TKXe();
            this.paneMain.Controls.Clear();
            this.paneMain.Controls.Add(tkXe);
        }

        private void buttonTKNV_Click(object sender, EventArgs e)
        {
            TKNhanVien tkNV = new TKNhanVien();
            this.paneMain.Controls.Clear();
            this.paneMain.Controls.Add(tkNV);
        }

        private void buttonDoanhThu_Click(object sender, EventArgs e)
        {
            TKDoanhThu tkDT = new TKDoanhThu();
            this.paneMain.Controls.Clear();
            this.paneMain.Controls.Add(tkDT);
        }

        private void buttonDSCV_Click(object sender, EventArgs e)
        {
            QuanLyCongViec qlcv = new QuanLyCongViec();
            this.paneMain.Controls.Clear();
            this.paneMain.Controls.Add(qlcv);
        }

        private void buttonChamCong_Click(object sender, EventArgs e)
        {
            ChamCong CC = new ChamCong();
            this.paneMain.Controls.Clear();
            this.paneMain.Controls.Add(CC);
        }

        private void buttonLuong_Click(object sender, EventArgs e)
        {
            TinhLuong luong = new TinhLuong();
            this.paneMain.Controls.Clear();
            this.paneMain.Controls.Add(luong);
        }
    }
}
