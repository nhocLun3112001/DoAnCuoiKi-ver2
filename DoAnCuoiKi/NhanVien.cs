using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKi
{
    class NhanVien
    {
        MY_DB mydb = new MY_DB();


        public bool themNhanVien(string maNV, string tenNV, string maBP,string maCV, string gender, DateTime bdate, string address, string cmnd, string phone, int heSoLuong, DateTime ngayVaoLam, string nangLuc ,MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("INSERT INTO NhanVien (maNV, tenNV, maBoPhan, maChucVu, gioiTinh, ngaySinh, diaChi, CMND, SDT, heSoLuong, ngayVaoLam, nangLuc, picture)" +
                "VALUES (@maNV, @tenNV, @maBP, @maCV, @gdr, @ngSinh, @dChi, @cmnd, @sdt, @hsl, @ngayVaoLam, @nl, @pic)", mydb.getConnection);

            command.Parameters.Add("@maNV", SqlDbType.VarChar).Value = maNV;
            command.Parameters.Add("@tenNV", SqlDbType.VarChar).Value = tenNV;
            command.Parameters.Add("@maBP", SqlDbType.VarChar).Value = maBP;
            command.Parameters.Add("@maCV", SqlDbType.VarChar).Value = maCV;
            command.Parameters.Add("@gdr", SqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@ngSinh", SqlDbType.DateTime).Value = gender;
            command.Parameters.Add("@dChi", SqlDbType.VarChar).Value = address;
            command.Parameters.Add("@cmnd", SqlDbType.VarChar).Value = cmnd;
            command.Parameters.Add("@sdt", SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@hsl", SqlDbType.Int).Value = heSoLuong;
            command.Parameters.Add("@ngayVaoLam", SqlDbType.DateTime).Value = ngayVaoLam;
            command.Parameters.Add("@nl", SqlDbType.VarChar).Value = nangLuc;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();

            mydb.openConnection();

            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }

        }



        public DataTable getNhanVien(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool xoaNhanVien(int maNV)
        {
            SqlCommand command = new SqlCommand("DELETE FROM nhanvien WHERE maNV = @maNV", mydb.getConnection);
            command.Parameters.Add("maNV", SqlDbType.VarChar).Value = maNV;
            mydb.openConnection();
            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }
        }

        public bool capNhatNhanVien(string maNV, string tenNV, string maBP, string maCV, string gender, DateTime bdate, string address, string cmnd, string phone, int heSoLuong, DateTime ngayVaoLam, string nangLuc, MemoryStream picture)
        {
            SqlCommand command = new SqlCommand("UPDATE NhanVien SET  tenNV = @tenNV, maBoPhan = @maBP, maChucVu  = @maCV, gioiTinh = @gdr, ngaySinh =@ngSinh, " +
                "diaChi = @dChi, CMND = @cmnd, SDT = @sdt, heSoLuong = @hsl, ngayVaoLam = @ngayVaoLam, nangLuc = @nl, picture =  @pic WHERE maNV = @maNV", mydb.getConnection);

            command.Parameters.Add("@maNV", SqlDbType.VarChar).Value = maNV;
            command.Parameters.Add("@tenNV", SqlDbType.VarChar).Value = tenNV;
            command.Parameters.Add("@maBP", SqlDbType.VarChar).Value = maBP;
            command.Parameters.Add("@maCV", SqlDbType.VarChar).Value = maCV;
            command.Parameters.Add("@gdr", SqlDbType.VarChar).Value = gender;
            command.Parameters.Add("@ngSinh", SqlDbType.DateTime).Value = gender;
            command.Parameters.Add("@dChi", SqlDbType.VarChar).Value = address;
            command.Parameters.Add("@cmnd", SqlDbType.VarChar).Value = cmnd;
            command.Parameters.Add("@sdt", SqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@hsl", SqlDbType.Int).Value = heSoLuong;
            command.Parameters.Add("@ngayVaoLam", SqlDbType.DateTime).Value = ngayVaoLam;
            command.Parameters.Add("@nl", SqlDbType.VarChar).Value = nangLuc;
            command.Parameters.Add("@pic", SqlDbType.Image).Value = picture.ToArray();

            mydb.openConnection();

            if ((command.ExecuteNonQuery() == 1))
            {
                mydb.closeConnection();
                return true;
            }
            else
            {
                mydb.closeConnection();
                return false;
            }

        }



    }

}
