using System;
using System.Collections.Generic;
using System.Text;

namespace FSLogistic.Model.Shared
{
    public class ResponeModel<T>
    {
        public ResponeStatusEnum ResponeStatus { get; set; }

        public string Message { get; set; }

        public T Data { get; set; }
    }
}
