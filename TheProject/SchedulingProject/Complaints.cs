using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulingProject
{
    class Complaints
    {
        public static List<Complaint> Complaintlist;

        public Complaints()
        {
            Complaintlist = new List<Complaint>();
            Complaintlist.Add(new Complaint("The shower head sometimes breaks", 5, 1, 2021));
        }


        public void AddComplaint(int Day, int Month, int Year, string complaint)
        {

            // Complaintlist.Add(new Complaint(complaint, Year, Month, Day ));
            Complaintlist.Add(new Complaint(complaint, Day, Month, Year));
        }
        public List<Complaint> GetComplaintslist()
        {
            return Complaintlist.ToList();

        }
        public bool RemoveFromlist(int Selected)
        {
            if (Selected > -1)
            {
                Complaintlist.RemoveAt(Selected);
                return true;
            }
            else
            {
                return false;
            }

        }
   
        public Complaint[] FilterList(int day, int month, int year)
        {
            List<Complaint> temp = new List<Complaint>();
            foreach (Complaint item in Complaintlist)
            {
                if (item.CDay == day && item.Cmonth == month && item.Cyear == year)
                {
                    temp.Add(item);
                }
            }
            return temp.ToArray();
        }

        

    }

}

