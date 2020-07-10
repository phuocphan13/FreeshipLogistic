using AutoMapper;
using FSLogistic.Domain.Models;
using FSLogistic.Model.Bill_Shipper;
using FSLogistic.Model.Customer;
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
            CreateMap<Bill_ShipperModel, Domain.Models.Bill>().ReverseMap();
        }
    }
}
