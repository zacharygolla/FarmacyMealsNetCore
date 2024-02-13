﻿namespace FarmacyMeals.WebApi.Models.Food
{
    public class FoodModelDto
    {
        public Guid? FoodId { get; set; }
        public string? Name { get; set; }
        public float? Price { get; set; }
        public string? Category { get; set; }
        public string? Description { get; set; }
        public string? ImagePath { get; set; }
        public string? IconPath { get; set; }
    }
}
