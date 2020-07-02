using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FSLogistic.Domain.Models
{
    public partial class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
    }
}
