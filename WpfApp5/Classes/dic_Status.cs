using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp5.Classes
{
    [Table]
    public class dic_Status
    {
        [Column(IsPrimaryKey = true)]
        public int StatusId { get; set; }
        [Column]
        public string NameEn { get; set; }
        [Column]
        public string NameRu { get; set; }
        [Column]
        public int? StatusTypeId { get; set; }
    }
}
