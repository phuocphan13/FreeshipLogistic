using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Text;

namespace FSLogistic.Domain.Models
{
    public partial class Bill : BaseEntityModel
    {
        public string BillCode { get; set; }

        [StringLength(256)]
        public string ReceiverName { get; set; }

        [StringLength(500)]
        public string Address { get; set; }
        
        [Required]
        public int District { get; set; }

        //[RegularExpression(@"^\$?\d+(\.(\d{2}))?$")]
        [Required]
        public string PhoneNumber { get; set; }
        
        public string CustomerNote { get; set; }
        
        public decimal Total { get; set; }
        
        public decimal Fee { get; set; }
        
        public decimal AdvanceMoney { get; set; }
        
        [Required]
        public BillDeliveryStatus Status { get; set; }
        
        public string StaffNote { get; set; }
        
        public DateTime DoneDate { get; set; }

        [ForeignKey("Customer")]
        public int CustomerId { get; set; }

        public Customer Customer { get; set; }

        [ForeignKey("Account")]
        public int AccountId { get; set; }

        public Account Account { get; set; }
    }
}
