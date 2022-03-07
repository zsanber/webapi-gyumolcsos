using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solution.Core.Models.Entities
{
    [Table("NutritionInfo")]
    public class NutritionInfo
    {
        [Required]
        [Key]
        public int Id { get; set; }

        [Required]
        public string Amount { get; set; }

        [Required]
        public string TotalCalories { get; set; }

        [Required]
        public string Carbohydrate { get; set; }

        [Required]
        public string Protein { get; set; }

        [Required]
        public string Fat { get; set; }


        public NutritionInfo()
        {
        }

        public NutritionInfo(int id, string amount, string totalCalories, string carbohydrate, string protein, string fat)
        {
            Id = id;
            Amount = amount;
            TotalCalories = totalCalories;
            Carbohydrate = carbohydrate;
            Protein = protein;
            Fat = fat;
        }
    }
}
