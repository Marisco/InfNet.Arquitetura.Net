using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.Application.Dtos.Item
{
    public class ItemResponseDTO
    {
        public Guid Id  { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool Done { get; set; }

    }
}
