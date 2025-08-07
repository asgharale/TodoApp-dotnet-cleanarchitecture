using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp.Domain.Contracts.OUTPUT.Item
{
    public class GetItemQr
    {
        public long Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public bool IsDone {  get; set; }
        public DateTime? Duetime { get; set; }
        public long CategoryId { get; set; }
    }
}
