using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnBanSach.Shared;
public class BookExcerpt
{
    public int BookId { get; set; }
    public string Title { get; set; }
    public decimal Price { get; set; }
    public decimal OriginalPrice { get; set; }
    public bool OutOfStock { get; set; }
    public string ImageURL { get; set; }


    public BookExcerpt()
    {

    }

    public BookExcerpt(string title, decimal price, decimal originalPrice, string imageURL)
    {
        Title = title;
        Price = price;
        OriginalPrice = originalPrice;
        ImageURL = imageURL;
    }

    public BookExcerpt(string title, decimal price, string imageURL)
    {
        Title = title;
        Price = price;
        ImageURL = imageURL;
    }
}
