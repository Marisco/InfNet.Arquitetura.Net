using AutoMapper;
using ToDo.Application.Dtos.Item;
using ToDo.Domain.Entities;

namespace ToDo.Application.AutoMapper
{
    public class ServiceProfile : Profile
    {
        public ServiceProfile()
        {
            CreateMap<Item, ItemResponseDTO>()
                .ForMember(destino => destino.CreatedAt,
                    acao => acao.MapFrom(origem => origem.CreatedAt.ToString("dd/MM/yyy HH:mm")));

        }

    }
}
