using Solution.Core.Models.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Solution.Core.Models.Requests
{
    public class FruitRequest
    {
        [Required(ErrorMessage = "A nevet  kötelező megadni.")]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        [Url]
        [StringLength(2048)]
        public string SourceUrl { get; set; }

        [Required]
        [StringLength(4096)]
        public string Description { get; set; }

        [Required]
        [ForeignKey("NutritionInfo")]
        public int NutritionInfoId { get; set; }
        public virtual NutritionInfo NutritionInfo { get; set; }

        public FruitRequest()
        {
        }

        public FruitRequest(string name, string sourceUrl, string description)
        {
            Name = name;
            SourceUrl = sourceUrl;
            Description = description;
        }
    }
}
