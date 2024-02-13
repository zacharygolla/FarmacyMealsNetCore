using FarmacyMeals.WebApi.Models.Food;

namespace FarmacyMeals.WebApi.Handlers.Food
{
    public static class FoodMapper
    {
        public static FoodModelDto MapFoodsToDto(FoodModel food)
        {
            return new FoodModelDto
            {
                FoodId = food.FoodId,
                Name = food.Name,
                Price = food.Price,
                Category = food.Category,
                Description = food.Description,
                ImagePath = food.ImagePath,
                IconPath = food.IconPath
            };
        }
    }
}
