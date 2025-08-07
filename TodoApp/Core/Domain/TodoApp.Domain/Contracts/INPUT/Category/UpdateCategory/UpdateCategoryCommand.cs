using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp.Domain.Contracts.INPUT.Category.UpdateCategory
{
    public class UpdateCategoryCommand
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
