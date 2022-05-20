using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnBanSach.Shared;

public class FilterInfo
{
    public int? CategoryId { get; set; }
    public string SearchString { get; set; }
    public decimal? FromPrice { get; set; }
    public decimal? ToPrice { get; set; }

}
