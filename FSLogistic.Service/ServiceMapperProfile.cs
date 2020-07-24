using AutoMapper;
using FSLogistic.Model.Admin;
using FSLogistic.Model.Customer;
using FSLogistic.Model.Shipper;

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
            CreateMap<CustomerCreateModel, Domain.Models.Customer>().ReverseMap();
            CreateMap<CustomerCreateModel, ValidateDistModel>().ReverseMap();
        }
    }
}
