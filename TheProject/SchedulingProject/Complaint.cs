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
        private string CStatus;


        public int CDay { get { return this.Cday; } }
        public int Cmonth { get { return this.CMonth; } }

        public int Cyear { get { return this.CYear; } }

        public string Cstatus { get { return this.CStatus; } set { this.CStatus = value; } }

        public Complaint(string complaint, int Cday, int CMonth, int CYear, string CStatus)
        {

            this.complaint = complaint;
            this.Cday = Cday;
            this.CMonth = CMonth;
            this.CYear = CYear;
            this.CStatus = CStatus;
        }
        public Complaint(int Cday, int CMonth, int CYear)
        {


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
            return $"{GetDate()}\t{complaint} ~: {CStatus}";

        }



    }
}

