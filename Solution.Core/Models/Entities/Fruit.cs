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

        public Fruit(int id, string name, string imageLink, string club, string birthday, int weight, double height, 
            string description, int NutritionInfoId)
        {
            Id = id;
            Name = name;
            ImageLink = imageLink;
            Club = club;
            Birthday = birthday;
            Weight = weight;
            Height = height;
            Description = description;
            NutritionInfoId = NutritionInfoId;
        }

        public Fruit( FruitRequest Fruit)
        {
            Name = Fruit.Name;
            ImageLink = Fruit.ImageLink;
            Club = Fruit.Club;
            Birthday = Fruit.Birthday;
            Weight = Fruit.Weight;
            Height = Fruit.Height;
            Description = Fruit.Description;
            NutritionInfoId = Fruit.NutritionInfoId;
        }
    }
}
