using FSLogistic.Core.Repositories;
using FSLogistic.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FSLogistic.Service.Product
{
    public class ProductService : IProductService
    {
        private readonly IRepository<Domain.Models.Product> _productRepository;

        public ProductService(IRepository<Domain.Models.Product> productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<List<Domain.Models.Product>> Get()
        {
            var listProducts = await _productRepository.GetAllListAsync();
            return listProducts;
        }
    }
}
