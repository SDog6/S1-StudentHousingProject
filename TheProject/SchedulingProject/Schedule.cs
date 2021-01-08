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

        public Schedule(string name, string chore, string date)
        {
            this.name = name;
            this.chore = chore;
            this.date = date;
        }

        public string GetInfo()
        {
            return $"Name: {name} \n Chore: {chore} \n  Date: {date}";
        }
    }
}
