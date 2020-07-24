using AutoMapper;
using FSLogistic.Core.Consts;
using FSLogistic.Core.Helpers;
using FSLogistic.Core.Repositories;
using FSLogistic.Core.UoW;
using FSLogistic.Domain.Models;
using FSLogistic.Model.Customer;
using FSLogistic.Model.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace FSLogistic.Service.Customer
{
    public class CustomerService : BaseService, ICustomerService
    {
        private readonly IRepository<Domain.Models.Customer> _customerRepository;

        public CustomerService(IRepository<Domain.Models.Customer> customerRepository,
            IPrincipal principal, IHttpContextAccessor context,
            IRepository<Domain.Models.Account> accountRepository, IUnitOfWork unitOfWork,
            IMapper mapper) : base(principal, context, accountRepository, unitOfWork, mapper)
        {
            _customerRepository = customerRepository;
        }

        public async Task<ResponeModel<List<CustomerModel>>> GetDataCustomer()
        {
            var listCustomerEntity = await _customerRepository.GetAll().Where(x => x.IsActive).ToListAsync();
            if (listCustomerEntity.Count == 0)
            {
                return SetResponeData<List<CustomerModel>>(CustomerMessage.CustomerGetFailedMessage, ResponeStatusEnum.Failed, null);
            }
            var customer = _mapper.Map<List<Domain.Models.Customer>, List<CustomerModel>>(listCustomerEntity);
            return SetResponeData(CustomerMessage.CustomerGetSuccessedMessage, ResponeStatusEnum.Successed, customer);
        }

        public async Task<ResponeModel<CustomerCreateModel>> CreateCustomer(CustomerCreateModel data)
        {
            if (!ValidationForCreateModel(data))
            {
                return SetResponeData<CustomerCreateModel>(CustomerMessage.CustomerCreateFailedMessage, ResponeStatusEnum.Failed, null);
            }

            var codeEntity = await _customerRepository.GetAll().AnyAsync(x => x.Code == data.Code && x.IsActive);
            if (codeEntity)
            {
                return SetResponeData<CustomerCreateModel>(CustomerMessage.CustomerExistedMessage, ResponeStatusEnum.Failed, null);
            }

            var customer = _mapper.Map<CustomerCreateModel, Domain.Models.Customer>(data);

            AddInfoDataForEntity(customer, true);
            customer.IsActive = true;
            await _customerRepository.InsertAsync(customer);

            bool isSuccessed = _unitOfWork.SaveChanges();
            if (!isSuccessed)
            {
                return SetResponeData<CustomerCreateModel>(CustomerMessage.CustomerCreateFailedMessage, ResponeStatusEnum.Failed, null);
            }
            return SetResponeData<CustomerCreateModel>(CustomerMessage.CustomerCreateSuccessedMessage, ResponeStatusEnum.Successed, null);
        }

        private bool ValidationForCreateModel(CustomerCreateModel data)
        {
            if (!ValidationHelper.CheckNullObject(data))
            {
                return false;
            }
            if (!ValidationHelper.ValidationForName(data.Name))
            {
                return false;
            }
            if (!ValidationHelper.ValidationForCode(data.Code))
            {
                return false;
            }

            var distObj = _mapper.Map<CustomerCreateModel, ValidateDistModel>(data);
            if (!ValidationHelper.CheckNumberObject(distObj))
            {
                return false;
            }
            return true;
        }
    }
}
