using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class CustomerDAO
    {
        private static CustomerDAO instance;

        public static CustomerDAO Instance
        {
            get { 
                if (instance == null) 
                    instance = new CustomerDAO(); // nếu chưa có thì tạo mới
                return CustomerDAO.instance; // trả về instance đã tạo
            }
            private set { CustomerDAO.instance = value; } //Không cho bên ngoài gán lại
        }

        public DataTable ReadAllCustomer() //lấy toàn bộ danh sách khách hàng từ database
                                           //bằng cách gọi stored procedure (thủ tục lưu trữ)
        {
            String query = @"USP_layTatCaKhachHang";
            DataTable dt = DataProvider.Instance.ExecuteQuery(query, new object[] { });
            return dt;
        }

        public bool addCustomerDAO(String name, int birth, String phoneNumber, int point, String address)
        {

            String query = "dbo.USP_themKhachHang @TenKhachHang ,  @DiaChi , @NamSinh , @SoDienThoai ,  @Diem ";
            try
            {
                DataProvider.Instance.ExecuteNonQuery(query, new object[] { name, address, birth, phoneNumber, point });
                return true;
            }
            catch
            {
                return false;
            }

        }

        public int deleteCustomerDAO(int CustomerID)
        {
            try
            {
                string query = "dbo.USP_xoaKhachHang @CustomerId";
                int rowsAffected = DataProvider.Instance.ExecuteNonQuery(query, new object[] { CustomerID });
                return rowsAffected; // trả về số dòng bị ảnh hưởng
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public int updateCustomerDAO(int id, string name, string address, int birth, string phone, int point)
        {
            try
            {
                string query = "USP_capNhatKhachHang @CusId , @name , @address , @birth , @phone , @point";
                int rowsAffected = DataProvider.Instance.ExecuteNonQuery(query, new object[] { id, name, address, birth, phone, point });
                return rowsAffected; // trả về số dòng bị ảnh hưởng
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        
        // --Các hàm sử dụng cho chức năng đặt vé--

        //hàm lấy sdt
        public DataTable getCustomerDAO(string phoneNumber)
        {
            string query = "USP_layThongTinKhachHang @Sdt ";
            try
            {
                return DataProvider.Instance.ExecuteQuery(query, new object[] { phoneNumber });
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Lỗi khi gọi thủ tục USP_layThongTinKhachHang: {ex.Message}");
                return null;
            }
        }

        //hàm check sdt phải là thành viên?
        public byte isMemberDAO(string phoneNumber)
        {
            string query = "Select dbo.FUNC_laThanhVien ( @phone )";
            byte kq;
            try
            {
                kq = Convert.ToByte(DataProvider.Instance.ExecuteScalar(query, new object[] { phoneNumber }));
            }
            catch( Exception ex) 
            {
                // error
                Console.WriteLine($"Lỗi khi gọi FUNC_laThanhVien: {ex.Message}");
                kq = 2;
            }
            return kq;
        }

        //Cộng điểm tích lũy
        public bool updatePointDAO(string phoneNumber, int bonus)
        {
            string query = "USP_congDiemTichLuy @Sdt , @bonus ";
            try
            {
                DataProvider.Instance.ExecuteNonQuery(query, new object[] { phoneNumber, bonus });
                return true;
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Lỗi khi gọi thủ tục USP_congDiemTichLuy: {ex.Message}");
                return false;
            }
        }

        // sử dụng điểm
        public bool usePointDAO(string phoneNumber)
        {
            string query = "USP_suDungDiemTichLuy @Sdt ";
            try
            {
                DataProvider.Instance.ExecuteNonQuery(query, new object[] { phoneNumber });
                return true;
            }
            catch(Exception ex) 
            {
                Console.WriteLine($"Lỗi khi gọi thủ tục USP_suDungDiemTichLuy: {ex.Message}");
                return false;
            }
        }

        //cập nhật điểm
        public void rollbackPoint(int point, string phoneNumber)
        {
            string query = "USP_capNhatDiem @Diem , @Sdt ";
            try
            {
                DataProvider.Instance.ExecuteNonQuery(query, new object[] { point, phoneNumber });
            }
            catch(Exception ex) 
            {
                Console.WriteLine($"Lỗi khi gọi thủ tục USP_capNhatDiem: {ex.Message}");
                Debug.WriteLine("Error");
            }

        }




    }
}
