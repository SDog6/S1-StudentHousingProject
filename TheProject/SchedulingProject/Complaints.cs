using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulingProject
{
    class Complaints
    {
        public List<Complaint> Complaintlist;

        public Complaints()
        {
            this.Complaintlist = new List<Complaint>();
        }


        public void AddComplaint(  int Day, int Month, int Year , string complaint )
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
