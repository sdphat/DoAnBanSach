using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnBanSach.Shared;

public class Book
{
    public int BookId { get; set; }
    public int CategoryId { get; set; }
    public Category Category { get; set; }
    public Author Author { get; set; }
    public int AuthorId { get; set; }
    public Publisher Publisher { get; set; }
    public int PublisherId { get; set; }
    public string Title { get; set; }
    public decimal Price { get; set; }
    public int Amount { get; set; }
    public string ImageURL { get; set; }
    public DateTime ImportDateTime { get; set; } = DateTime.Now;
}
