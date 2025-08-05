using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp.Domain.DTO.INPUT.Item.CreateItem
{
    public class CreateItemCommand
    {
        public string Name { get; set; } = string.Empty;
        public bool IsDone { get; set; }
        public DateTime? DueDate { get; set; }
        public string Description { get; set; } = string.Empty;
        public long CategoryId { get; set; }


        public CreateItemCommand()
        {
            IsDone = false;
            IsActive = true;
        }
    }
}
