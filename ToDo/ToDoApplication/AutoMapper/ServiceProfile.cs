using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Domain.Entities;
using ToDoApplication.Dtos.Item;
using ToDoApplication.Interfaces;

namespace ToDoApplication.AutoMapper
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
