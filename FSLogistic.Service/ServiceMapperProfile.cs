using AutoMapper;
using FSLogistic.Domain.Models;
using FSLogistic.Model.Customer;
using FSLogistic.Model.TestFlowModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace FSLogistic.Service
{
    public class ServiceMapperProfile : Profile
    {
        public ServiceMapperProfile()
        {
            //CreateMap<Domain.Models.Owner, OwnerModalModel>().ReverseMap();
            CreateMap<TestFlowCreateModel, Summary>();
            CreateMap<CustomerModel, Domain.Models.Customer>().ReverseMap();
            CreateMap<AddCustomerModel, Domain.Models.Customer>().ReverseMap();
        }
    }
}
