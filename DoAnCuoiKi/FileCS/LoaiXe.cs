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
    class LoaiXe
    {
        MY_DB mydb = new MY_DB();

        public bool ThemLoaiXe(string loaiXe, int gia, int tong)
        {
            SqlCommand command = new SqlCommand("INSERT INTO LoaiXe (LoaiXe, Gia, TongViTri) VALUES (@loai, @gia, @tong)", mydb.getConnection);

            command.Parameters.Add("@loai", SqlDbType.VarChar).Value = loaiXe;
            command.Parameters.Add("@gia", SqlDbType.Int).Value = gia;
            command.Parameters.Add("@tong", SqlDbType.Int).Value = tong;

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


        public DataTable getLoaiXe(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }


        public bool XoaLoaiXe(string loaiXe)
        {
            SqlCommand command = new SqlCommand("DELETE FROM LoaiXe WHERE LoaiXe = @loai", mydb.getConnection);
            command.Parameters.Add("@loai", SqlDbType.VarChar).Value = loaiXe;

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

        public bool CapNhatLoaiXe(string loaiXe, int gia, int tong)
        {
            SqlCommand command = new SqlCommand("UPDATE LoaiXe SET Gia = @gia, TongViTri = @tong WHERE  LoaiXe = @loai", mydb.getConnection);

            command.Parameters.Add("@loai", SqlDbType.VarChar).Value = loaiXe;
            command.Parameters.Add("@gia", SqlDbType.Int).Value = gia;
            command.Parameters.Add("@tong", SqlDbType.Int).Value = tong;

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

        public bool KiemTraLoaiXe(string loaiXe)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM LoaiXe WHERE LoaiXe = @loai", mydb.getConnection);
            command.Parameters.Add("@loai", SqlDbType.VarChar).Value = loaiXe;

            DataTable table = this.getLoaiXe(command);
            if (table.Rows.Count > 0)
            {
                return true;    //Co xe nay trong du lieu
            }
            else
            {
                return false;
            }
        }
    }
}
