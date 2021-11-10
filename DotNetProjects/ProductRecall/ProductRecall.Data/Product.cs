using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductRecall.Data
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        public int ManufacturerId { get; set; }

        [Required]
        [Display(Name = "Product Name")]
        public string ProductName { get; set; }
                
        [Required]
        [Display(Name = "Price")]
        public double Price { get; set; }

        public virtual Manufacturer Manufacturer { get; set; }

    }
}
