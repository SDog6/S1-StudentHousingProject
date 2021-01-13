using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulingProject
{
    public class Schedule
    {
        private string name;
        private string chore;
        private string date;

        public string Name { set {this.name = value;} get { return this.name; } }

        public Schedule(string chore,string date)
        {
            this.name = "";
            this.chore = chore;
            this.date = date;
        }
        public Schedule(string name, string chore, string date)
        {
            this.name = name;
            this.chore = chore;
            this.date = date;
        }

        public string GetInfo()
        {
            if(name == "")
            {
                return $"{chore} needs doing on the {date} [!]";
            }
            else
            {
                return $"{name} will be: {chore} on: {date}";
            }
        }
    }
}
