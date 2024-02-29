using FribergRentals.Data.Models;

namespace FribergRentals.Data.Interfaces
{
	public interface ICategory
	{
		Task<Category> Add(Category category);
		Task Edit(Category category);
		Task Delete(int id);
		Task <List<Category>> GetAll();
		Task <Category> GetByIdAsync(int id);
	}
}
