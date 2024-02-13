using FarmacyMeals.WebApi.Models.Food;
using FarmacyMeals.WebApi.Services.Food;

namespace FarmacyMeals.WebApi.Handlers.Food
{
    public class FoodHandler
    {
        private readonly IFoodService _foodService;

        public FoodHandler(IFoodService foodService)
        {
            _foodService = foodService;
        }

        public async Task<List<FoodModelDto>> GetAllFoodsAsync()
        {
            var foods = await _foodService.GetAllFoodsAsync();
            return foods.Select(FoodMapper.MapFoodsToDto).ToList();
        }
    }
}
