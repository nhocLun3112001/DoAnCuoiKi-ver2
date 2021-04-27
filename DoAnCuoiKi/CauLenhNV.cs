using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKi
{
    class CauLenhNV
    {
        NhanVien nv = new NhanVien();
        public bool checkMaNV(string maNV)
        {
            
            SqlCommand command = new SqlCommand(" SELECT maNV FROM NhanVien WHERE maNV = " + maNV);
            DataTable table = nv.getNhanVien(command);
            if (table.Rows.Count > 0)
            {
                return true;   // Da ton tai id
            }
            else return false;   // Chua co id
        }

    }
}
