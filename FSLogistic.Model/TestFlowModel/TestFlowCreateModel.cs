using FSLogistic.Model.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace FSLogistic.Model.TestFlowModel
{
    public class TestFlowCreateModel:BaseModel
    {
        public string Title { get; set; }
        public string Note { get; set; }
        public string Total { get; set; }
    }
}
