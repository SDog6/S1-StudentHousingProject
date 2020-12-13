using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulingProject
{
    public class Discussion
    {
        private string name;
        private string date;
        private string debate;

        public Discussion(string name,string date,string debate)
        {
            this.name = name;
            this.date = date;
            this.debate = debate;
        }

        public string GetInfo()
        {
            return $"{date} - {name}: {debate} ";
        }
    }
}
