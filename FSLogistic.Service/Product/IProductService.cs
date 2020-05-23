using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FSLogistic.Service.Product
{
    public interface IProductService
    {
        Task<List<Domain.Models.Product>> Get();
    }
}
