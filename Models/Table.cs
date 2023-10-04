using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDBSM.Models
{
    public class Table
    {
        public int NextRowId { get; set; } = 1;
        public string Name { get; private set; }
        public List<Row> Rows { get; set; } = new List<Row>();
        public List<Column> Columns { get; set; } = new List<Column>();
        public Table(string name) => Name = name;
    }

}
