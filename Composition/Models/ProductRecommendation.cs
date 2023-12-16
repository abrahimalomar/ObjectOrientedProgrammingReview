
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Composition.Models
{
    public class ProductRecommendation
    {
        [Key]
        public int ProductRecommendationId { get; set; }

        [Required(ErrorMessage = "Rating is required")]
        [Range(1, 5, ErrorMessage = "Rating must be between 1 and 5")]
        public int Rating { get; set; }

        [Required(ErrorMessage = "Product ID is required")]
        public int ProductId { get; set; }

        [ForeignKey(nameof(ProductId))]
        public virtual Product RecommendedProduct { get; set; }
    }

}
