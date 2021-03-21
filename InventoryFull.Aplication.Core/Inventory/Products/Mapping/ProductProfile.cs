using AutoMapper;
using InventoryFull.Aplication.Dto.Inventory.Products;
using InventoryFull.Domain.Core.Inventory.Product;

namespace InventoryFull.Aplication.Core.Inventory.Products.Mapping
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<ProductEntity, ProductDto>().ReverseMap();
            CreateMap<ProductEntity, ProductRequestDto>().ReverseMap();
            CreateMap<ProductEntity, ProductResponseDto>().ReverseMap();
        }
    }
}