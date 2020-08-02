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
                return SetResponeData<List<CustomerModel>>(Message.GetFailedMessage, ResponeStatusEnum.Failed, null);
            }
            var customer = _mapper.Map<List<Domain.Models.Customer>, List<CustomerModel>>(listCustomerEntity);
            return SetResponeData(Message.GetSuccessedMessage, ResponeStatusEnum.Successed, customer);
        }

        public async Task<ResponeModel<Domain.Models.Customer>> CreateCustomer(CustomerCreateModel data)
        {
            if (!ValidationForCreateModel(data))
            {
                return SetResponeData<Domain.Models.Customer>(CustomerMessage.CustomerValidateFailedMessage, ResponeStatusEnum.Failed, null);
            }

            var codeEntity = await _customerRepository.GetAll().AnyAsync(x => x.Code == data.Code && x.IsActive);
            if (codeEntity)
            {
                return SetResponeData<Domain.Models.Customer>(CustomerMessage.CustomerExistedMessage, ResponeStatusEnum.Existed, null);
            }

            var customer = _mapper.Map<CustomerCreateModel, Domain.Models.Customer>(data);

            AddInfoDataForEntity(customer, true);
            customer.IsActive = true;
            await _customerRepository.InsertAsync(customer);

            bool isSuccessed = _unitOfWork.SaveChanges();
            if (!isSuccessed)
            {
                return SetResponeData<Domain.Models.Customer>(CustomerMessage.CustomerCreateFailedMessage, ResponeStatusEnum.Failed, null);
            }
            return SetResponeData(CustomerMessage.CustomerCreateSuccessedMessage, ResponeStatusEnum.Successed, customer);
        }

        public async Task<ResponeModel<CustomerModel>> UpdateCustomer(CustomerModel data)
        {
            if (!ValidationForUpdateModel(data))
            {
                return SetResponeData<CustomerModel>(CustomerMessage.CustomerCreateFailedMessage, ResponeStatusEnum.Failed, null);
            }

            var isExisted = await _customerRepository.GetAll().AnyAsync(x => x.IsActive && x.Code == data.Code);
            if (!isExisted)
            {
                return SetResponeData<CustomerModel>(CustomerMessage.CustomerNotExistedMessage, ResponeStatusEnum.NotExisted, null);
            }

            var customerEntity = await _customerRepository.FirstOrDefaultAsync(x => x.Id == data.Id);
            if (customerEntity != null)
            {
                customerEntity = _mapper.Map(data, customerEntity);

                customerEntity.IsActive = true;

                AddInfoDataForEntity(customerEntity, false);
                _customerRepository.Update(customerEntity);
                bool isSaveChangeSuccessed = _unitOfWork.SaveChanges();
                if (!isSaveChangeSuccessed)
                {
                    return SetResponeData<CustomerModel>(CustomerMessage.CustomerUpdateFailedMessage, ResponeStatusEnum.Failed, null);
                }
                return SetResponeData<CustomerModel>(CustomerMessage.CustomerUpdateSuccessedMessage, ResponeStatusEnum.Successed, null);
            }
            return SetResponeData<CustomerModel>(CustomerMessage.CustomerUpdateFailedMessage, ResponeStatusEnum.Failed, null);
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

        private bool ValidationForUpdateModel(CustomerModel data)
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

            var distObj = _mapper.Map<CustomerModel, ValidateDistModel>(data);
            if (!ValidationHelper.CheckNumberObject(distObj))
            {
                return false;
            }
            return true;
        }
    }
}
