using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FSLogistic.Domain.Models
{
    public partial class Account : BaseEntityModel
    {
        [Required]
        [MaxLength(10)]
        public string Code { get; set; }

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }

        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }

        public bool IsActive { get; set; }

        public Guid Guid { get; set; }

        [NotMapped]
        public string Name { 
            get
            {
                return $"{LastName} {FirstName}";
            }
        }
    }
}
