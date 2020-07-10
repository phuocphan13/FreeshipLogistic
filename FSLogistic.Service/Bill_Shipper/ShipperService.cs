using AutoMapper;
using FSLogistic.Core.Repositories;
using FSLogistic.Core.UoW;
using FSLogistic.Domain.Models;
using FSLogistic.Model.Bill_Shipper;
using FSLogistic.Model.Customer;
using FSLogistic.Model.Shared;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace FSLogistic.Service.Bill_Shipper
{
    public class ShipperService : BaseService, IShipperService
    {
        private readonly IRepository<Domain.Models.Bill> _billShipperRepository;

        public ShipperService(IRepository<Domain.Models.Bill> billShipperRepository,
            IPrincipal principal, IHttpContextAccessor context,
            IRepository<Domain.Models.Account> accountRepository, IUnitOfWork unitOfWork,
            IMapper mapper) : base(principal, context, accountRepository, unitOfWork, mapper)
        {
            _billShipperRepository = billShipperRepository;
        }

        public async Task<ResponeModel<List<Bill_ShipperModel>>> GetDataBillShipper()
        {
            var listCustomerEntity = await _billShipperRepository.GetAllListAsync();
            if (listCustomerEntity == null)
            {
                return SetResponeData<List<Bill_ShipperModel>>("Load Thất Bại", ResponeStatusEnum.Failed, null);
            }
            else
            {
                var shipper = _mapper.Map<List<Domain.Models.Bill>, List<Bill_ShipperModel>>(listCustomerEntity);
                return SetResponeData("Load Thành Công", ResponeStatusEnum.Successed, shipper);
            }
        }
    }
}
