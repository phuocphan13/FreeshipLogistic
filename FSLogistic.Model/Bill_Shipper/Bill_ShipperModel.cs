using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FSLogistic.Model.Bill_Shipper
{
    public class Bill_ShipperModel
    {
        public string Code { get; set; }

        public string Customer { get; set; }

        [StringLength(256)]
        public string ReceiverName { get; set; }

        public string Address { get; set; }

        [Required]
        public int District { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        public string CustomerNote { get; set; }

        public decimal Total { get; set; }

        public int Status { get; set; }

        public string StaffNote { get; set; }

        public DateTime DoneDate { get; set; }
    }
}
