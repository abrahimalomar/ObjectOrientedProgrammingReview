using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Composition.Models
{

    public  class Order
    {

        public Order()
        {
            OrderDatalis  = new List<OrderDatali>();
        }
        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(UserId))]
        public string UserId { get; set; }

        public DateTime OrderDate { get; set; }

        public decimal Total { get; set; }

        public virtual Users User { get; set; }

        public virtual ICollection<OrderDatali> OrderDatalis { get; set; }
    }
}