using FribergRentals.Data.Models;

namespace FribergRentals.Data.Interfaces
{
	public interface ICategory
	{
		public Task<Category> Add(Category category);
		public void Edit(Category category);
		public void Delete(int id);
		Task <List<Category>> GetAll();
	}
}
