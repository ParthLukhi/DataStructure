using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class Employee
    {
        private int id;
        private string emp_fname;
        private string emp_lname;
        private string emp_dpt;
        private int sal;
        //private string mgr_id;
        private HashSet<string> task_name;
        private static Dictionary<int, Employee> employees = new();
        public Employee(    
            int id, string emp_fname, string emp_lname, string emp_dpt, int sal)
        {
            this.id = id;
            this.emp_fname = emp_fname;
            this.emp_lname = emp_lname;
            this.emp_dpt = emp_dpt;
            this.sal = sal;
            this.task_name = new HashSet<string>();
        }

        public static void AddEmp(Employee e)
        {
            employees.Add(e.id, e);
        }

        public static Dictionary<int, Employee>.ValueCollection GetEmployees()
        {
            return employees.Values;
        }

        public static void RemoveEmp(int id)
        {
            employees.Remove(id);
        }

        public static void AddTaskToEmp(int id, string task_name)
        {
            employees[id].task_name.Add(task_name);
        }

        public static SortedSet<Employee> GetEmpByTaskName(string task_name)
        {
            SortedSet<Employee> employee = new SortedSet<Employee>();
            foreach(Employee e in employees.Values)
            {
                if (e.task_name.Contains(task_name))
                {
                    employee.Add(e);
                }
            }
            return employee;
        }

        public static HashSet<string> GetEmpTaskName(int id)
        {
            return employees[id].task_name;
        }

        public override string ToString()
        {
            return "Id: " + this.id.ToString() + "\nFirst Name:" + this.emp_fname +"\nLast Name: " + this.emp_lname +
                "\nDepartment: " + this.emp_dpt + "\nSalary: " + this.sal.ToString();
        }

    }
}
