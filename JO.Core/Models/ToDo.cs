using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JO.Core.Models
{
    public class ToDo
    {
        public int Id { get; set; } = 0;
        public string Description { get; set; } = string.Empty;
        public bool Complete { get; set; } = false;
    }
}
