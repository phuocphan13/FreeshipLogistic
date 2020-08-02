using AutoMapper;
using FSLogistic.Core.Consts;
using FSLogistic.Core.Helpers;
using FSLogistic.Core.Repositories;
using FSLogistic.Core.UoW;
using FSLogistic.Model.Admin;
using FSLogistic.Model.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;

namespace FSLogistic.Service.Admin
{
    public class AdminService : BaseService, IAdminService
    {
        private readonly IRepository<Domain.Models.Bill> _billRepository;
        private readonly IRepository<Domain.Models.Customer> _customerRepository;
        public AdminService(IRepository<Domain.Models.Bill> billRepository,
            IRepository<Domain.Models.Customer> customerRepository,
            IRepository<Domain.Models.Account> accountRepository,
            IPrincipal principal, IHttpContextAccessor context,
            IUnitOfWork unitOfWork,
            IMapper mapper) : base(principal, context, accountRepository, unitOfWork, mapper)
        {
            _billRepository = billRepository;
            _customerRepository = customerRepository;
        }

        public async Task<ResponeModel<List<AdminBillModel>>> GetDataAdmin()
        {
            var listBills = new List<AdminBillModel>();

            var billsEntity = await _billRepository.GetAll().Include(x => x.Account).Include(x => x.Customer).ToListAsync();
            
            if (billsEntity == null)
                return SetResponeData<List<AdminBillModel>>(Message.GetFailedMessage, ResponeStatusEnum.Failed, null);

            var accountsEntity = await _accountRepository.GetAll().Where(x => x.IsActive).Select(x => x.Id).ToListAsync();
            var customersEntity = await _customerRepository.GetAll().Where(x => x.IsActive).Select(x => x.Id).ToListAsync();

            foreach (var bill in billsEntity)
            {
                var item = new AdminBillModel();

                var customer = customersEntity.Any(x => x == bill.CustomerId);
                if (!customer)
                    item.Code = Message.GetCustomerFailedMessage;

                var account = accountsEntity.Any(x => x == bill.AccountId);
                if (!account)
                    item.Name = Message.GetAccountFailedMessage;

                item = _mapper.Map<Domain.Models.Bill, AdminBillModel>(bill);

                item.Code = bill.Customer.Code;

                item.Name = bill.Account.Name;

                item.Status = CheckBillDeliveryStatus(bill.Status);

                item.DoneDate = TransformHelper.ConvertDatetimeToString(bill.DoneDate);

                listBills.Add(item);
            }
            return SetResponeData(Message.GetSuccessedMessage, ResponeStatusEnum.Successed, listBills);
        }

        private string CheckBillDeliveryStatus(BillDeliveryStatus data)
        {
            if (data == BillDeliveryStatus.Done)
            {
                return DeliveryStatusMessage.DoneMessage;
            }

            if (data == BillDeliveryStatus.NotDone)
            {
                return DeliveryStatusMessage.NotDoneMessage;
            }

            if (data == BillDeliveryStatus.Returned)
            {
                return DeliveryStatusMessage.ReturnedMessage;
            }

            return null;
        }
    }
}
