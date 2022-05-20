namespace DoAnBanSach.Shared;

public class OrderDetail
{
    public int OrderId { get; set; }
    public Book Book { get; set; }
    public int BookId { get; set; }
    public int Amount { get; set; }
    public decimal Price { get; set; }
    public decimal TotalPrice { get; set; }
}
