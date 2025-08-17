using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace BUS
{
    public class StaffBUS
    {
        private static StaffBUS instance;
        public static StaffBUS Instance
        {
            get { if (instance == null) instance = new StaffBUS(); return StaffBUS.instance; }
            private set { StaffBUS.instance = value; }
        }


        public DataTable getListStaff()
        {
            return StaffDAO.Instance.readAllStaff();
        }


        public bool addStaff(String id, String name, DateTime birth, String address, String phone, int identity)
        {
            if (StaffDAO.Instance.addStaffDAO(id, name, birth, address, phone, identity))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool deleteStaffBUS(string id)
        {
            if (StaffDAO.Instance.deleteStaffDAO(id))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool updateStaffBUS(String id, String name, DateTime birth, String address, String phone, int number)
        {
            if (StaffDAO.Instance.updateStaffDAO(id, name, birth, address, phone, number))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
