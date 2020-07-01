using AutoMapper;
using FSLogistic.Core.Extensions;
using FSLogistic.Core.Repositories;
using FSLogistic.Core.UoW;
using FSLogistic.Domain.Models;
using FSLogistic.Domain.UoW;
using FSLogistic.Model.Shared;
using FSLogistic.Model.TestFlowModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace FSLogistic.Service.TestFlow
{
    public class TestFlowService : BaseService, ITestFlowService
    {
        private readonly IRepository<Summary> _testflowRepository;
        private readonly IUnitOfWork _unitOfWork;
        public TestFlowService(IRepository<Summary> testflowRepository, IUnitOfWork unitOfWork)
        {
            _testflowRepository = testflowRepository;
            _unitOfWork = unitOfWork;
        }
        public async Task<List<Summary>> Get()
        {
            var listTest = await _testflowRepository.GetAllListAsync();
            return listTest;
        }

        public ResponeModel<Summary> Create(Summary testFlowCreate)
        {
            if (testFlowCreate == null)
            {
                return SetResponeData<Summary>("null", ResponeStatusEnum.Null, null);
            }
            AddInfoDataForEntity(testFlowCreate, true);
            
            _testflowRepository.Insert(testFlowCreate);
            var isSuccess = _unitOfWork.SaveChanges();
            if (!isSuccess)
                return SetResponeData<Summary>("FAIl", ResponeStatusEnum.Failed, null);
            return SetResponeData<Summary>("SUCCESS", ResponeStatusEnum.Successed, testFlowCreate);


        }
    }
}
