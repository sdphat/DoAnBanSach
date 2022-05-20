using DoAnBanSach.Shared;

namespace DoAnBanSach.Server.Services;

public class PaginationService
{
    public PaginationResponse<T> Paginate<T>(List<T> list, int page, int itemsPerPage)
    {
        var count = list.Count;
        var result = list
            .Skip((page - 1) * itemsPerPage)
            .Take(itemsPerPage)
            .ToList();
        return new PaginationResponse<T> { Items = result, ItemsPerPage = itemsPerPage, Pages = (int)Math.Ceiling((decimal)count / itemsPerPage) };
    }
}
