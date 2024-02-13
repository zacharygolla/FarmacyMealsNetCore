using FarmacyMeals.WebApi.Data;
using Microsoft.EntityFrameworkCore;
using FarmacyMeals.WebApi.Models.Food;

namespace FarmacyMeals.WebApi.Services.Food
{
    public class FoodService : IFoodService
    {
        private readonly DataContext _context;

        public FoodService(DataContext dataContext)
        {
            _context = dataContext;
        }

        public async Task<List<FoodModel>> GetAllFoodsAsync()
        {
            return await _context.Foods.ToListAsync();
        }
    }
}
