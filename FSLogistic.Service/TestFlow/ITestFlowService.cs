using FSLogistic.Domain.Models;
using FSLogistic.Model.Shared;
using FSLogistic.Model.TestFlowModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FSLogistic.Service.TestFlow
{
    public interface ITestFlowService
    {
        Task<List<Summary>> Get();
        ResponeModel<Summary> Create(Summary testFlowCreate);
    }
}
