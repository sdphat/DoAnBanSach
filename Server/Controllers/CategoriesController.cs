using DoAnBanSach.Server.Services;
using DoAnBanSach.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace DoAnBanSach.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CategoriesController : ControllerBase
{
    private readonly CategoryService _categoryService;
    private readonly PaginationService _paginationService;

    public CategoriesController(CategoryService categoryService, PaginationService paginationService)

    {
        _categoryService = categoryService;
        _paginationService = paginationService;
    }
    [HttpGet]
    public async Task<List<Category>> GetCategoriesAsync()
    {
        return await _categoryService.GetCategoriesAsync();
    }

    [HttpGet("{page:int}")]
    public async Task<PaginationResponse<Category>> GetCategoriesPagination(int page)
    {
        var categories = await _categoryService.GetCategoriesAsync();
        return _paginationService.Paginate(categories, page, 8);
    }


    [HttpDelete("{categoryId:int}")]
    public async Task DeleteBookAsync(int categoryId)
    {
        if (await _categoryService.DeleteCategory(categoryId))
        {
            Response.StatusCode = (int)HttpStatusCode.OK;
        }
        else
        {
            Response.StatusCode = (int)HttpStatusCode.BadRequest;
        }
    }

    [HttpPost]
    public async Task CreateCategory()
    {
        try
        {
            Category category = await Request.ReadFromJsonAsync<Category>();
            await _categoryService.CreateCategory(category);
            Response.StatusCode = (int)HttpStatusCode.OK;
        }
        catch (Exception ex)
        {
            Response.StatusCode = (int)HttpStatusCode.BadRequest;
        }
    }

    [HttpPut]
    public async Task UpdateCategory()
    {
        try
        {
            Category category = await Request.ReadFromJsonAsync<Category>();
            await _categoryService.UpdateCategory(category);
            Response.StatusCode = (int)HttpStatusCode.OK;
        }
        catch (Exception ex)
        {
            Response.StatusCode = (int)HttpStatusCode.BadRequest;
        }
    }
}
