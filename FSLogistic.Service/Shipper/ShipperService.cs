using AutoMapper;
using FSLogistic.Core.Consts;
using FSLogistic.Core.Helpers;
using FSLogistic.Core.Repositories;
using FSLogistic.Core.UoW;
using FSLogistic.Domain.Models;
using FSLogistic.Model.Bill_Shipper;
using FSLogistic.Model.Customer;
using FSLogistic.Model.Shared;
using FSLogistic.Model.Shipper;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace FSLogistic.Service.Bill_Shipper
{
    public class ShipperService : BaseService, IShipperService
    {
        private readonly IRepository<Domain.Models.Bill> _billRepository;
        private readonly IRepository<Domain.Models.Customer> _customerRepository;

        public ShipperService(IRepository<Domain.Models.Bill> billRepository,
            IRepository<Domain.Models.Customer> customerRepository,
            IRepository<Domain.Models.Account> accountRepository,
            IPrincipal principal, IHttpContextAccessor context,
            IUnitOfWork unitOfWork,
            IMapper mapper) : base(principal, context, accountRepository, unitOfWork, mapper)
        {
            _billRepository = billRepository;
            _customerRepository = customerRepository;
        }

        public async Task<ResponeModel<List<ShipperBillModel>>> GetDataShipper()
        {
            var listBills = new List<ShipperBillModel>();
            var billsEntity = await _billRepository.GetAll().Include(x => x.Account).Include(x => x.Customer).ToListAsync();

            if (billsEntity.Count == 0)
                return SetResponeData<List<ShipperBillModel>>(Message.GetFailedMessage, ResponeStatusEnum.Failed, null);

            var accountsEntity = await _accountRepository.GetAll().Where(x => x.IsActive).Select(x => x.Id).ToListAsync();
            var customersEntity = await _customerRepository.GetAll().Where(x => x.IsActive).Select(x => x.Id).ToListAsync();

            foreach (var bill in billsEntity)
            {
                var item = new ShipperBillModel();

                var customer = customersEntity.Any(x => x == bill.CustomerId);
                if (!customer)
                    item.Code = Message.GetCustomerFailedMessage;
                 
                var account = accountsEntity.Any(x => x == bill.AccountId);
                if (!account)
                    item.Name = Message.GetAccountFailedMessage;

                item = _mapper.Map<Bill, ShipperBillModel>(bill);

                item.Code = bill.Customer.Code;

                item.Name = bill.Account.Name;

                item.Status = TransformHelper.CheckBillDeliveryStatus(bill.Status);

                item.DoneDate = TransformHelper.ConvertDatetimeToString(bill.DoneDate);

                listBills.Add(item);
            }
            return SetResponeData(Message.GetSuccessedMessage, ResponeStatusEnum.Successed, listBills);
        }
    }
}
