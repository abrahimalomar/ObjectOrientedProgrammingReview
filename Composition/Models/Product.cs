using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Composition.Models
{
    public  class Product
    {
        public Product()
        {
           
            SelectedProducts = new List<SelectedProduct>();
            RecommendedProducts = new List<ProductRecommendation>();
        }

        [Key]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Product name is required")]
       [StringLength(100, MinimumLength = 2, ErrorMessage = "Product name must be between 2 and 100 characters")]
        public string ProductName { get; set; }

       [Required(ErrorMessage = "Price is required")]
        [Range(0, 10000, ErrorMessage = "Price must be between 0 and 10,000")]
        [Column(TypeName = "decimal(10,2)")]
        public decimal Price { get; set; }

        [Display(Name = "Date Added")]
        public DateTime DateAdded { get; set; }

        [Display(Name = "Sales Count")]
        public int SalesCount { get; set; }

        [Display(Name = "Offer")]
        public bool IsSelected { get; set; }
        public decimal SalePrice { get; set; }
        public string ImageSrc { get; set; }

        [NotMapped]
        [Display(Name = "Image File")]
        //[Required(ErrorMessage = "Image file is required")]
        //public IFormFile ImageFile { get; set; }

        [Required(ErrorMessage = "Quantity is required")]
        [Range(1, 10000, ErrorMessage = "Quantity must be between 1 and 10,000")]
        public int Quantity { get; set; }

        [Required(ErrorMessage = "Category is required")]
        public int CategorieId { get; set; }

        [ForeignKey(nameof(CategorieId))]
        public virtual Categorie Categorie { get; set; }

        public virtual ICollection<SelectedProduct> SelectedProducts { get; set; }

        public virtual ICollection<ProductRecommendation> RecommendedProducts { get; set; }
    }

}
