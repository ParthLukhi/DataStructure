using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class Task
    {
        private int task_id;
        private string task_name;
        private string task_project;
        private string task_desciption;
        private string task_status;
        public static Dictionary<string, Task> Tasks = new();

        public Task(
            int task_id, 
            string task_name, 
            string task_project, 
            string task_desciption, 
            string task_status)
        {
            this.task_id = task_id;
            this.task_name = task_name;
            this.task_project = task_project;
            this.task_desciption = task_desciption;
            this.task_status = task_status;
        }

        public static void AddTask(Task t)
        {
            Tasks.Add(t.task_name, t);
        }

        public static Dictionary<string, Task>.ValueCollection GetAllTasks()
        {
            return Tasks.Values;
        }

        public static void RemoveTask(string tname)
        {
            Tasks.Remove(tname);
        }

        public static void ClearTask()
        {
            Tasks.Clear();
        }

        public static HashSet<string> GetAllTaskName()
        {
            return Tasks.Keys.ToHashSet<string>();
        }

        public override string ToString()
        {
            return "Task ID: " +this.task_id+ "\nTask Name: " + this.task_name +
                "\nProject Name: " + this.task_project + "\n Description: " + this.task_desciption +
                "\n Status: " + this.task_status + "\n";
        }
    }

}
