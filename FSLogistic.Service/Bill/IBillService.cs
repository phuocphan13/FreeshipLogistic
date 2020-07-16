using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FSLogistic.Service.Bill
{
    public interface IBillService
    {
        Task<List<Domain.Models.Bill>> Get();
        Task<Domain.Models.Bill> GetById(int id);

        Task<List<Domain.Models.Bill>> SearchByDate(DateTime date);

        Task<List<Domain.Models.Bill>> SearchByCustomerId(int customerId);

        Task<List<Domain.Models.Bill>> SearchByCustomer(string name);
        Task<List<Domain.Models.Bill>> SearchByShipperId(int shipperId);
        Task<List<Domain.Models.Bill>> SearchByShipper(string name);
        Task<List<Domain.Models.Bill>> SearchByDistrict(District district);

    }
}
