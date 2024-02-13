using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace FarmacyMeals.WebApi.Models.Food
{
    [DataContract]
    public class FoodModel
    {
        [Key]
        [DataMember]
        public Guid FoodId { get; set; } = default;

        [DataMember]
        public string? Name { get; set; }

        [DataMember]
        public float? Price { get; set; }

        [DataMember]
        public string? Category { get; set; }

        [DataMember]
        public string? Description { get; set; }

        [DataMember]

        public string? ImagePath { get; set; }

        [DataMember]
        public string? IconPath { get; set; }
    }
}
