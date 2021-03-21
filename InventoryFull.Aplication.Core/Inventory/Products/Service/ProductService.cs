using AutoMapper;
using InventoryFull.Aplication.Dto.Inventory.Products;
using InventoryFull.Domain.Core.Inventory.Category;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InventoryFull.Aplication.Core.Inventory.Products.Service
{
    internal class ProductService : IProductService
    {
        private readonly ICategoryRepository _repoProducts;
        private readonly IMapper _mapper;

        public ProductService(ICategoryRepository repoProducts, IMapper mapper)
        {
            _mapper = mapper;
            _repoProducts = repoProducts;
        }
        public Task<ProductResponseDto> Create(ProductRequestDto request)
        {
            throw new System.NotImplementedException();
        }

        public bool Delete(ProductRequestDto request)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<ProductDto> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public bool Update(ProductRequestDto request)
        {
            throw new System.NotImplementedException();
        }
    }
}
