using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FSLogistic.Domain.Models
{
    public partial class Account:BaseTable
    {
        public string Code { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
    }
}
