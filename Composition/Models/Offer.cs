
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace  Composition.Models
{
    public  class Offer
    {
        public Offer()
        {
            SelectedProducts = new List<SelectedProduct>();
        }

        [Key]
        public int OfferId { get; set; }

        [Required(ErrorMessage = "Offer name is required")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Offer name must be between 2 and 50 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Discount value is required")]
        [Range(0, 100, ErrorMessage = "Discount value must be between 0 and 100")]
        public decimal DiscountValue { get; set; }

        public virtual ICollection<SelectedProduct> SelectedProducts { get; set; }
    }


}
