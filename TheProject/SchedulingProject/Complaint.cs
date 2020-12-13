using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulingProject
{
    class Complaint
    {
        private string complaint;
        private int Cday;
        private int CMonth;
        private int CYear;




        public Complaint(string complaint, int Cday, int CMonth, int CYear)
        {

            this.complaint = complaint;
            this.Cday = Cday;
            this.CMonth = CMonth;
            this.CYear = CYear;

        }


        public string GetComplaint()
        {
            return this.complaint;
        }
        public string GetDate()
        {
            return $"{Cday}/{CMonth}/{CYear}";
        }

        public string GetInfo()
        {
            return $"{GetDate()}\t{complaint}";

        }



    }
}

