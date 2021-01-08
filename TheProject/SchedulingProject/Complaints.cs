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

    }
}
