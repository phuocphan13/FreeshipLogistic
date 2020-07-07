using AutoMapper;
using FSLogistic.Core.Repositories;
using FSLogistic.Core.UoW;
using FSLogistic.Model.Customer;
using FSLogistic.Model.Shared;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
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
            IMapper mapper) : base(principal,context,accountRepository,unitOfWork,mapper)
        {
            _customerRepository = customerRepository;
        }

        public async Task<ResponeModel<List<CustomerModel>>> GetDataCustomer()
        {
            var listCustomerEntity = await _customerRepository.GetAllListAsync();
            if (listCustomerEntity == null)
            {
                return SetResponeData<List<CustomerModel>>("Load Thất Bại", ResponeStatusEnum.Null, null);
            }
            else
            {
                var customer = _mapper.Map<List<Domain.Models.Customer>, List<CustomerModel>>(listCustomerEntity);
                return SetResponeData("Load Thành Công", ResponeStatusEnum.Successed, customer);
            }
        }
    }
}
