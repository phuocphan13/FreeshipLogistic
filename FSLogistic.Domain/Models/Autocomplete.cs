﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FSLogistic.Domain.Models
{
    public partial class Autocomplete
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public int Type { get; set; }
        
        public string Data { get; set; }
    }
}
