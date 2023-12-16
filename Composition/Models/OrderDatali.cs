
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Composition.Models
{

    public  class OrderDatali
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(OrderId))]
        public int OrderId { get; set; }

        [ForeignKey(nameof(ProductId))]
       
        public int ProductId { get; set; }

        public decimal Price { get; set; }
      
        public int Quantity { get; set; }

        public virtual Order Order { get; set; }

        public virtual Product Product { get; set; }
    }
}