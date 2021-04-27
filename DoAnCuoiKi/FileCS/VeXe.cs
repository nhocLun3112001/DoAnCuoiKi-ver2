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
    class VeXe
    {
        MY_DB mydb = new MY_DB();

        public bool ThemVeXe(string maVe, string loaiVe)
        {
            SqlCommand command = new SqlCommand("INSERT INTO VeXe (MaVe, LoaiVe) VALUES (@ma, @loai)", mydb.getConnection);

            command.Parameters.Add("@ma", SqlDbType.VarChar).Value = maVe;
            command.Parameters.Add("@loai", SqlDbType.VarChar).Value = loaiVe;

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


        public DataTable getVe(SqlCommand command)
        {
            command.Connection = mydb.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }


        public bool XoaVe(string maVe)
        {
            SqlCommand command = new SqlCommand("DELETE FROM VeXe WHERE MaVe = @ma", mydb.getConnection);
            command.Parameters.Add("@ma", SqlDbType.VarChar).Value = maVe;

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

        public bool CapNhatXe(string maVe, string loaiVe)
        {
            SqlCommand command = new SqlCommand("UPDATE VeXe SET LoaiVe = @loai WHERE  MaVe = @ma", mydb.getConnection);

            command.Parameters.Add("@ma", SqlDbType.VarChar).Value = maVe;
            command.Parameters.Add("@loai", SqlDbType.VarChar).Value = loaiVe;

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

        public bool KiemTraMaXe(string maVe)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM VeXe WHERE MaVe = @ma", mydb.getConnection);
            command.Parameters.Add("@ma", SqlDbType.VarChar).Value = maVe;

            DataTable table = this.getVe(command);
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
