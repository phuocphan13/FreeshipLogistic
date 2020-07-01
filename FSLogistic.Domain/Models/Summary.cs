using FSLogistic.Model.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FSLogistic.Domain.Models
{
    public partial class Summary:BaseModel
    {
        public string Title { get; set; }
        public string Note { get; set; }
        public string Total { get; set; }
        
    }
}
