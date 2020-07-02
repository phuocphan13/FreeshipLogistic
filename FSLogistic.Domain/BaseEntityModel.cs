using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FSLogistic.Domain.Models
{
    public class BaseEntityModel
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public DateTime CreatedDate { get; set; }

        [Required]
        public int CreatedBy { get; set; }
        
        public DateTime? UpdatedDate { get; set; }
        
        public int? UpdatedBy { get; set; }
    }
}
