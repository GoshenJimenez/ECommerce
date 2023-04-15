using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Contracts.Common
{
    public class Paged<T>
    {
        public int? TotalRows { get; set; }
        public List<T>? Items { get; set; }
        public int? PageIndex { get; set; }
        public int? PageSize { get; set; }
        public string? Keyword { get; set; }
        public SortOrder SortOrder { get; set; }
        public string? SortBy { get; set; }
        public int? PageCount
        {
            get
            {
                if (this.Items != null && this.Items.Count > 0 && this.TotalRows != null)
                {
                    var result = (int?)Math.Ceiling((decimal)(TotalRows / this.PageSize ?? 10));

                    if (result != null && result < 1)
                    {
                        return 1;
                    }

                    return result;
                };

                return 0;
            }
        }
    }
}
