using AutoMapper;
using FSLogistic.Domain.Models;
using FSLogistic.Model.Admin;
using FSLogistic.Model.Bill_Admin;
using FSLogistic.Model.Bill_Shipper;
using FSLogistic.Model.Customer;
using FSLogistic.Model.Shipper;
using System;
using System.Collections.Generic;
using System.Text;

namespace FSLogistic.Service
{
    public class ServiceMapperProfile : Profile
    {
        public ServiceMapperProfile()
        {
            CreateMap<CustomerModel, Domain.Models.Customer>().ReverseMap();
            CreateMap<ShipperBillModel, Domain.Models.Bill>().ReverseMap();
            CreateMap<AddCustomerModel, Domain.Models.Customer>().ReverseMap();
            CreateMap<AdminBillModel, Domain.Models.Bill>().ReverseMap();
        }
    }
}
