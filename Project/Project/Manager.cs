using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class Manager
    {
        private int mgr_id;
        private string mgr_fname;
        private string mgr_lname;
        private string mgr_dept;
        private int sal;
        private HashSet<string> employees;
        public static Dictionary<int, Manager> manager = new();

        public Manager(int mgr_id, 
            string mgr_fname,
            string mgr_lname,
            string mgr_dept,
            int sal)
        {
            this.mgr_id = mgr_id;
            this.mgr_fname = mgr_fname;
            this.mgr_lname = mgr_lname;
            this.mgr_dept = mgr_dept;
            this.sal = sal;
            this.employees = new HashSet<string>();
        }

        public static void AddManager(Manager m)
        {
            manager.Add(m.mgr_id, m);
        }

        public static Dictionary<int, Manager>.ValueCollection GetManagers()
        {
            return manager.Values;
        }

        public static void RemoveManager(int id)
        {
            manager.Remove(id);
        }

        public static void ClearManager()
        {
            manager.Clear();
        }

        public static void AddEmpToManager(int mgr_id, int id)
        {
            manager[mgr_id].employees.Add(id.ToString());
        }

        public static List<Manager> GetManagersByEmp(int id) { 
            List<Manager> list = new List<Manager>();
            foreach (Manager m in manager.Values)
            {
                if (m.employees.Contains(id.ToString()))
                {
                    list.Add(m);
                }
            }
            return list;
        }

        public override string ToString()
        {
            return "Manager ID: " + this.mgr_id.ToString() + "\nManager First Name:" + this.mgr_fname +
                "\nManager Last Name: " + this.mgr_lname + "\nManager Department: " + this.mgr_dept +
                "\nManager Salary: " + this.sal.ToString() + "\n"; 
        }
    }
}
