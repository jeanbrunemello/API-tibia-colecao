using ApiTibiaColecao.Dto;
using ApiTibiaColecao.Models;
using AutoMapper;

namespace ApiTibiaColecao.AutoMapperProfiles
{
    public class ItemProfile : Profile
    {
        public ItemProfile()
        {
            CreateMap<Item, GetItemDto>();
            CreateMap<CreateItemDto, Item>();
            CreateMap<UpdateItemDto, Item>();
        }
    }
}
