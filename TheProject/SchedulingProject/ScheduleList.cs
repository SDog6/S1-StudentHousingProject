using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulingProject
{
    public class ScheduleList
    {
        private static List<Schedule> myScheduleList;

        public ScheduleList()
        {
            myScheduleList = new List<Schedule>();
            myScheduleList.Add(new Schedule("Leo", "cleaning the kitchen", "1.8.2021"));
        }

        public void AddSchedule(string name, string chore, string date)
        {
            myScheduleList.Add(new Schedule(name, chore, date));
        }

        public List<Schedule> GetScheduleList()
        {
            return myScheduleList.ToList() ;
        }

        public void RemoveChore(int index)
        {
            if(index > -1)
            {
                myScheduleList.RemoveAt(index);
            }
        }
    }
}
