using FSLogistic.Model.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FSLogistic.Domain.Models
{
    public partial class Summary : BaseEntityModel
    {
        [MaxLength(256)]
        public string Title { get; set; }

        [MaxLength(256)]
        public string Note { get; set; }
        
        [Required]
        public decimal Total { get; set; }
    }
}
