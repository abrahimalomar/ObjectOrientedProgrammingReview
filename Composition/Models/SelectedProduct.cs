
using System;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Composition.Models
{
    public class SelectedProduct
    {
        [Key]
        public int Id { get; set; }

       [Required(ErrorMessage = "Date is required")]
        public DateTime Date { get; set; }

  
        public int OfferId { get; set; }

        [ForeignKey(nameof(OfferId))]
        public virtual Offer Offer { get; set; }

        [Required(ErrorMessage = "Product ID is required")]
        public int ProductId { get; set; }

        [ForeignKey(nameof(ProductId))]
        public virtual Product Product { get; set; }

    }


}
