using FribergRentals.Data.Interfaces;
using FribergRentals.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace FribergRentals.Data.Repositories
{
	public class CategoryRepo : ICategory
	{
		private readonly ApplicationDbContext _applicationDbContext;

		public CategoryRepo(ApplicationDbContext applicationDbContext)
		{
			_applicationDbContext = applicationDbContext;
		}
		public async Task<Category> Add(Category category)
		{
			_applicationDbContext.Categories.Add(category);
			await _applicationDbContext.SaveChangesAsync();

			return category;
		}

		public async Task Delete(int id)
		{
			Category category = _applicationDbContext.Categories.Find(id);
			_applicationDbContext.Remove(category);
			await _applicationDbContext.SaveChangesAsync();
		}

		public async Task Edit(Category category)
		{
			if (category != null)
			{
				_applicationDbContext.Categories.Update(category);
				await _applicationDbContext.SaveChangesAsync();
			}

		}

		public async Task<List<Category>> GetAll()
		{
			var categories = await _applicationDbContext.Categories.ToListAsync();
			return categories;
		}

		public async Task<Category> GetByIdAsync(int id)
		{
			return await _applicationDbContext.Categories.FindAsync(id);
		}

    }
}
