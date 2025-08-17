using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAO
{
    public class StaffDAO
    {

        private static StaffDAO instance;

        public static StaffDAO Instance
        {
            get { if (instance == null) instance = new StaffDAO(); return StaffDAO.instance; }
            private set { StaffDAO.instance = value; }
        }

        public DataTable readAllStaff()
        {
            String query = "select * from dbo.FUNC_layTatCaNhanVien ( )";
            try
            {
                return DataProvider.Instance.ExecuteQuery(query, new object[] { });
            }
            catch
            {
                return null;
            }

        }

        public bool addStaffDAO(String id, String name, DateTime birth, String address, String phone, int identity)
        {
            String query = "USP_themNhanVien @idNV , @HoTen , @NgaySinh , @DiaChi , @SDT , @CMND ";
            try
            {
                DataProvider.Instance.ExecuteNonQuery(query, new object[] { id, name, birth, address, phone, identity });
                return true;
            }
            catch
            {
                return false;
            }

        }

        public bool deleteStaffDAO(String staffId)
        {
            String query = "dbo.USP_xoaNhanVien @StaffId ";
            try
            {
                DataProvider.Instance.ExecuteNonQuery(query, new object[] { staffId });
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool updateStaffDAO(String id, String name, DateTime birth, String address, String phone, int number)
        {
            String query = "dbo.USP_capNhatNhanVien @id , @name , @birth , @address , @phone , @identity ";
            try
            {
                DataProvider.Instance.ExecuteNonQuery(query, new object[] { id, name, birth, address, phone, number });
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
