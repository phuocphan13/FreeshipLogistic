using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Text;

namespace FSLogistic.Domain.Models
{
    public partial class Bill:BaseTable
    {
        public Customer Customer { get; set; }
        public string ReceiverName { get; set; }
        public string Address { get; set; }
        public int District { get; set; }
        public string PhoneNumber { get; set; }
        public string CustomerNote { get; set; }
        public Account Account { get; set; }
        public string Total { get; set; }
        public string Fee { get; set; }
        public string AdvanceMoney { get; set; }
        public int Status { get; set; }
        public string StaffNote { get; set; }
        public DateTime DoneDate { get; set; }
    }
}
