using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDBSM.Models
{
    public class Row
    {
        public List<string> Values { get; set; } = new List<string>();
        public int Id { get; set; }

        public Row(int id) => Id = id;
    }
}
