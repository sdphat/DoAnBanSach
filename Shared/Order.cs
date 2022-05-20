using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnBanSach.Shared;

public class Order
{
    public List<OrderDetail> Details { get; set; } = new();
    public int OrderId { get; set; }
    public string? EmployeeId { get; set; }
    public string CustomerId { get; set; }
    public decimal TotalPrice { get; set; }
    public string Status { get; set; } = "Chưa xác nhận";
    public DateTime Date { get; set; } = DateTime.Now;
}
