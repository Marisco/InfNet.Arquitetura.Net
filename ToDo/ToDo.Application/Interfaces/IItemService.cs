using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Application.Dtos.Item;

namespace ToDo.Application.Interfaces
{
    public interface IItemService
    {
        Task<IEnumerable<ItemResponseDTO>> GetItemsAsync();
        Task CreateItemAsync(ItemRequestDTO itemRequestDTO);

        Task DeleteItemAsync(Guid id);

        Task EditItemAsync(Guid id);
    }
}
