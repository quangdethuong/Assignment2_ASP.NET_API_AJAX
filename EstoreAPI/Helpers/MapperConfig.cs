using AutoMapper;
using BusinessObject;
using DataAccess;
using EstoreAPI.DTO.OrdersDTO;
using EstoreAPI.DTO.ProductsDTO;

namespace EstoreAPI.Helpers
{
    public class MapperConfig : Profile
    {

        public MapperConfig()
        {
            CreateMap<ProductDTO, Product>().ReverseMap();
            CreateMap<ProductCreateDTO, Product>().ReverseMap();
            CreateMap<ProductUpdateDTO, Product>().ReverseMap();
          

            CreateMap<OrderDTO, Order>();
            //CreateMap<OrderDetailDTO, OrderDetail>().ReverseMap();



        }
    }
}
