using System;
using System.Collections.Generic;
using System.Text;

namespace FSLogistic.Model.Shared
{
    public class BaseModel
    {
        public int Id { get; set; }

        public int CompanyId { get; set; }

        public bool IsActive { get; set; }

        public DateTime CreatedDate { get; set; }

        public int CreatedBy { get; set; }

        public DateTime UpdatedDate { get; set; }

        public int UpdatedBy { get; set; }
    }
}
