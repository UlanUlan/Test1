using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp5.Classes
{
    [Table]
    public class dic_Pavilion
    {
        [Column(IsPrimaryKey = true)]
        public int PavilionId { get; set; }
        [Column]
        public string Name { get; set; }
    }
}
