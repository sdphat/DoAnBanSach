using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnBanSach.Shared;

public class PaginationResponse<T>
{
    public List<T> Items { get; set; }
    public int ItemsPerPage { get; set; }
    public int Pages { get; set; }
}
