using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ToDo.Domain.Entities;
using ToDo.Domain.Interface;
using ToDoApplication.Dtos.Item;
using ToDoApplication.Interfaces;

namespace ToDoApplication.Services
{
    public class ItemService: IItemService
    {
        private readonly IItemRepository repository;
        private readonly IMapper mapper;

        public ItemService(IItemRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;

        }

        public Task CreateItemAsync(ItemRequestDTO itemRequestDTO)
        {
            try
            {
                this.repository.AddAsync();

            }
            catch (Exception e)
            {
                
            }
        }

        public Task<ItemResponseDTO> GetItemsAsync()
        {
            try
            {
                var response = this.repository.GetAllAsync();
                return response;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
