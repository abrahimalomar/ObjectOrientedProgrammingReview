
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace  Composition.Models
{

    public  class Categorie
    {
        public Categorie()
        {
            Products = new List<Product>();
     
        }

        [Key]
        public int CategorieId { get; set; }

       [Required(ErrorMessage = "Category name is required")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Category name must be between 2 and 50 characters")]
        public string CategorieName { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    
    }
}

