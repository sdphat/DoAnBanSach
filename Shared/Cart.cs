using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnBanSach.Shared;

public class Cart
{
    public string CustomerId { get; set; }
    public List<CartItem> Items { get; set; } = new List<CartItem>();
    public decimal TotalPrice => Items.Sum(i => i.TotalPrice);
}
