using DoAnBanSach.Server.Data;
using DoAnBanSach.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace DoAnBanSach.Server.Services;

public class CategoryService
{
    private readonly ApplicationDbContext _dataContext;

    public CategoryService(ApplicationDbContext dataContext)
    {
        _dataContext = dataContext;
    }

    public async Task<List<Category>> GetCategoriesAsync()
    {
        return await _dataContext.Categories.ToListAsync();
    }

    public async Task CreateCategory(Category category)
    {
        _dataContext.Categories.Add(category);
        await _dataContext.SaveChangesAsync();
    }

    public async Task UpdateCategory(Category category)
    {
        Category dbCategory = _dataContext.Categories.First(c => c.CategoryId == category.CategoryId);
        foreach (PropertyInfo prop in typeof(Category).GetProperties())
        {
            prop.SetValue(dbCategory, prop.GetValue(category));
        }
        await _dataContext.SaveChangesAsync();
    }

    public async Task<bool> DeleteCategory(int categoryId)
    {
        try
        {
            _dataContext.Categories.Remove(_dataContext.Categories.First(c => c.CategoryId == categoryId));
            await _dataContext.SaveChangesAsync();
            return true;
        }
        catch (Exception ex)
        {
            return false;
        }

    }
    }
