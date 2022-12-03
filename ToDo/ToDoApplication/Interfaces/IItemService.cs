using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoApplication.Dtos.Item;

namespace ToDoApplication.Interfaces
{
    public interface IItemService
    {
        Task<ItemResponseDTO> GetItemsAsync();
        Task CreateItemAsync(ItemRequestDTO itemRequestDTO);
    }
}
