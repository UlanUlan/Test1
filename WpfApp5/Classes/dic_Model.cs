using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp5.Classes
{
    [Table]
    public class dic_Model
    {
        [Column(IsPrimaryKey = true)]
        public int ModelId { get; set; }
        [Column]
        public string Code { get; set; }
        [Column]
        public string Name { get; set; }
        [Column]
        public int? SeriesId { get; set; }
    }
}
