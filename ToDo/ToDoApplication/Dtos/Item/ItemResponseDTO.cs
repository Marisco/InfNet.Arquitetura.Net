using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApplication.Dtos.Item
{
    public class ItemResponseDTO
    {
        public Guid Id  { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
