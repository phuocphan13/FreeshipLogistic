using System;
using System.Collections.Generic;
using System.Text;

namespace FSLogistic.Domain.Models
{
    public partial class Autocomplete
    {
        public int Id { get; set; }
        public int Type { get; set; }
        public string Data { get; set; }
    }
}
