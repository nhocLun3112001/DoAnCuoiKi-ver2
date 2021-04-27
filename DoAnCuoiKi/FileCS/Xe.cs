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
    class Xe
    {
        MY_DB mydb = new MY_DB();
        
        public bool ThemXe(string maXe, string loaiXe, DateTime ngayVao,  MemoryStream image1, MemoryStream image2)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Xe (MaXe, LoaiXe, NgayVaoBen, Image1, Image2)" +
                "VALUES (@ma, @loai, @vao, @img1, img2)", mydb.getConnection);

            command.Parameters.Add("@ma", SqlDbType.VarChar).Value = maXe;
            command.Parameters.Add("@loai", SqlDbType.VarChar).Value = loaiXe;
            command.Parameters.Add("@vao", SqlDbType.DateTime).Value = ngayVao;
            command.Parameters.Add("@img1", SqlDbType.Image).Value = image1.ToArray();
            command.Parameters.Add("@img2", SqlDbType.Image).Value = image2.ToArray();

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

        public bool ThemNgayXuatBen( DateTime ngayXuatBen)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Xe (NgayXuatBen)" +
                "VALUES (@ra)", mydb.getConnection);
            command.Parameters.Add("@ra", SqlDbType.DateTime).Value = ngayXuatBen;
      
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


        public DataTable getXe(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }


        public bool XoaXe(string maXe)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Xe WHERE MaXe = @ma", mydb.getConnection);
            command.Parameters.Add("@ma", SqlDbType.VarChar).Value = maXe;

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

        public bool CapNhatXe(string maXe, string loaiXe, DateTime ngayVao, DateTime ngayRa, MemoryStream image1, MemoryStream image2)
        {
            SqlCommand command = new SqlCommand("UPDATE Xe SET  LoaiXe = @loai, NgayVaoBen = @vao, NgayXuatBen = @ra, Image1 = @img1, "
                + "Image2 = @img2 WHERE  MaXe = @ma", mydb.getConnection);

            command.Parameters.Add("@ma", SqlDbType.VarChar).Value = maXe;
            command.Parameters.Add("@loai", SqlDbType.VarChar).Value = loaiXe;
            command.Parameters.Add("@vao", SqlDbType.DateTime).Value = ngayVao;
            command.Parameters.Add("@ra", SqlDbType.DateTime).Value = ngayRa;
            command.Parameters.Add("@img1", SqlDbType.Image).Value = image1.ToArray();
            command.Parameters.Add("@img2", SqlDbType.Image).Value = image2.ToArray();

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

        public bool KiemTraMaXe(string maXe)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Xe WHERE MaXe = @ma", mydb.getConnection);
            command.Parameters.Add("@ma", SqlDbType.VarChar).Value = maXe;

            DataTable table = this.getXe(command);
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
