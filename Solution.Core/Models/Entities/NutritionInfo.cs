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
        public string Name { get; set; }

        public NutritionInfo()
        {
        }

        public NutritionInfo(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
