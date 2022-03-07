using Solution.Core.Interfaces.IEntities;
using Solution.Core.Models.Requests;
using System.ComponentModel.DataAnnotations;

namespace Solution.Core.Models.Entities
{
    public class Fruit : FruitRequest, IEntity
    {
        [Key]
        [Required]
        public int Id { get; set; }

        public Fruit()
        {
        }

        public Fruit(int id, string name, string sourceUrl,string description, int nutritionInfoId)
        {
            Id = id;
            Name = name;
            SourceUrl = sourceUrl;
            Description = description;
            NutritionInfoId = nutritionInfoId;
        }

        public Fruit( FruitRequest Fruit)
        {
            Name = Fruit.Name;
            SourceUrl = Fruit.SourceUrl;
            Description = Fruit.Description;
            NutritionInfoId = Fruit.NutritionInfoId;

        }
    }
}
