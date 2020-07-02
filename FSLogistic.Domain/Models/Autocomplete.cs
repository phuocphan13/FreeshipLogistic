using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FSLogistic.Domain.Models
{
    public partial class Autocomplete
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public AutocompleteType Type { get; set; }

        [Column(TypeName = "nvarchar(MAX)")]
        public string Data { get; set; }
    }
}
