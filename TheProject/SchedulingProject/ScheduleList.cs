using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulingProject
{
    public class ScheduleList
    {
        private List<Schedule> myScheduleList;

        public ScheduleList()
        {
            myScheduleList = new List<Schedule>();
        }

        public void AddSchedule(string name, string chore, string date)
        {
            myScheduleList.Add(new Schedule(name, chore, date));
        }

        public List<Schedule> GetScheduleList()
        {
            return myScheduleList;
        }

        public void RemoveChore(int index)
        {
            myScheduleList.RemoveAt(index);
        }
    }
}
