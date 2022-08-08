using AutoMapper;
using MetaMarket.Application.DTOs;
using MetaMarket.Domain.Entities;

namespace MetaMarket.Application.AutoMapper;

/// <summary>
/// 
/// </summary>
public class DomainToDtoMappingProfile : Profile
{
    public DomainToDtoMappingProfile()
    {
        CreateMap<BaseEntity, BaseEntityDto>().ReverseMap();
        CreateMap<Cart, CartDto>().ReverseMap();
        CreateMap<Client, ClientDto>().ReverseMap();
        CreateMap<Position, PositionDto>().ReverseMap();
        CreateMap<ProductCategory, ProductCategoryDto>().ReverseMap();
        CreateMap<Product, ProductDto>().ReverseMap();
        CreateMap<Sale, SaleDto>().ReverseMap();
        CreateMap<SalePurchase, SalePurchaseDto>().ReverseMap();
        CreateMap<Salesperson, SalespersonDto>().ReverseMap();
        CreateMap<User, UserDto>().ReverseMap();
    }
}