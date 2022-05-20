using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnBanSach.Shared;

public class CheckAmountResponse
{
    public int MaxAmount { get; set; }
    public int Amount { get; set; }
    public bool IsValid { get; set; }
    public Book Book { get; set; }
}
