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
            CreateMap<AdminBillModel, Domain.Models.Bill>().ReverseMap();
            CreateMap<CustomerCreateModel, Domain.Models.Customer>().ReverseMap();
            CreateMap<CustomerCreateModel, ValidateDistModel>().ReverseMap();
            CreateMap<CustomerModel, ValidateDistModel>().ReverseMap();
            CreateMap<CustomerUpdateModel, Domain.Models.Customer>().ReverseMap();
            CreateMap<CustomerModel, CustomerUpdateModel>().ReverseMap();
        }
    }
}
