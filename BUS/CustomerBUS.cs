using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class CustomerBUS
    {
        private static CustomerBUS instance;

        public static CustomerBUS Instance
        {
            get
            {
                if (instance == null) instance = new CustomerBUS();
                return instance;
            }
        }

        public DataTable getListCustomer()
        {
            return CustomerDAO.Instance.ReadAllCustomer();
        }

        public bool addCustomer(string name, int birth, string phoneNumber, int point, string address)
        {
            return CustomerDAO.Instance.addCustomerDAO(name, birth, phoneNumber, point, address);
        }

        public int deleteCustomer(int CustomerID)
        {
            return CustomerDAO.Instance.deleteCustomerDAO(CustomerID);
        }

        public int  updateCustomerBUS(int id, String name, String address, int birth, String phone, int point)
        {
            return CustomerDAO.Instance.updateCustomerDAO(id, name, address, birth, phone, point);
        }

        public DataTable getCustomer(String phoneNumber)
        {
            return CustomerDAO.Instance.getCustomerDAO(phoneNumber);
        }
        public byte isMember(string phoneNumber)
        {
            return CustomerDAO.Instance.isMemberDAO(phoneNumber);
        }

        public bool updatePointBUS(string phoneNumber, int bonus)
        {
            return CustomerDAO.Instance.updatePointDAO(phoneNumber, bonus);
        }

        public bool usePointBUS(string phoneNumber)
        {
            return CustomerDAO.Instance.usePointDAO(phoneNumber);
        }

        public void rollbackPoint(int point, string phoneNumber)
        {
            CustomerDAO.Instance.rollbackPoint(point, phoneNumber);
        }

    }
}
