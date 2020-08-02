﻿using FSLogistic.Model.Customer;
using FSLogistic.Model.Shared;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FSLogistic.Service.Customer
{
    public interface ICustomerService
    {
        Task<ResponeModel<List<CustomerModel>>> GetDataCustomer();

        Task<ResponeModel<Domain.Models.Customer>> CreateCustomer(CustomerCreateModel data);

        Task<ResponeModel<CustomerModel>> UpdateCustomer(CustomerModel data);
    }
}
