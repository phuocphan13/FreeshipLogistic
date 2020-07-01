using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FSLogistic.Domain.Models
{
    public partial class Customer:BaseTable
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Q1 { get; set; }
        public string Q2 { get; set; }
        public string Q3 { get; set; }
        public string Q4 { get; set; }
        public string Q5 { get; set; }
        public string Q6 { get; set; }
        public string Q7 { get; set; }
        public string Q8 { get; set; }
        public string Q9 { get; set; }
        public string Q10 { get; set; }
        public string Q11 { get; set; }
        public string Q12 { get; set; }
        public string QTD { get; set; }
        public string QGV { get; set; }
        public string QBTH { get; set; }
        public string QTB { get; set; }
        public string QTP { get; set; }
        public string QBTN { get; set; }
        public string QPN { get; set; }
        public string Qcc { get; set; }
        public string QHM { get; set; }
        public string QBC { get; set; }
        public string QNB { get; set; }
        public string QCG { get; set; }
        

    }
}
