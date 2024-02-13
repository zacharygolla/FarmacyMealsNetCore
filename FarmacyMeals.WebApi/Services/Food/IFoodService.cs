using FarmacyMeals.WebApi.Models.Food;

namespace FarmacyMeals.WebApi.Services.Food
{
    public interface IFoodService
    {
        Task<List<FoodModel>> GetAllFoodsAsync();
    }
}
