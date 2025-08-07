using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp.Domain.Contracts.INPUT.Item.UpdateItem
{
    public class UpdateItemCommand
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsDone { get; set; }
        public long CategoryId { get; set; }
    }
}
