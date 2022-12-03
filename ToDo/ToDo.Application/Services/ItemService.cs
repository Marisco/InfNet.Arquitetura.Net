using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ToDo.Domain.Entities;
using ToDo.Domain.Interface;
using ToDo.Application.Dtos.Item;
using ToDo.Application.Interfaces;

namespace ToDo.Application.Services
{
    public class ItemService : IItemService
    {
        private readonly IItemRepository repository;
        private readonly IMapper mapper;

        public ItemService(IItemRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;

        }

        public async Task DeleteItemAsync(Guid id)
        {
            try
            {
                await this.repository.DeleteAsync(id);

            }
            catch (Exception e)
            {

            }
        }
        public async Task EditItemAsync(Guid id)
        {
            try
            {
                await this.repository.EditAsync(id);
            }
            catch (Exception e)
            {

            }
        }


        public async Task CreateItemAsync(ItemRequestDTO itemRequestDTO)
        {
            try
            {
                var item = new Item(itemRequestDTO.Description);
                await this.repository.AddAsync(item);
            }
            catch (Exception e)
            {

            }
        }
        public async Task<IEnumerable<ItemResponseDTO>> GetItemsAsync()
        {

            try
            {
                var response = await this.repository.GetAllAsync();

                return mapper.Map<IEnumerable<ItemResponseDTO>>(response);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
