﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FSLogistic.Model.Admin
{
    public class AdminBillModel
    {
        public string BillCode { get; set; }

        public string Code { get; set; }

        public string ReceiverName { get; set; }

        public string Address { get; set; }

        public int District { get; set; }

        public string PhoneNumber { get; set; }

        public string CustomerNote { get; set; }

        public string Name { get; set; }

        public decimal Total { get; set; }

        public decimal Fee { get; set; }

        public decimal AdvanceMoney { get; set; }

        public string Status { get; set; }

        public string StaffNote { get; set; }

        public string DoneDate { get; set; }
    }
}