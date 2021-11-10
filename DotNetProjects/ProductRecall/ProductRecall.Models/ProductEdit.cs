using ProductRecall.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductRecall.Models
{
    public class ProductEdit
    {
        [Key]
        [Display(Name = "Product Id")]
        public int ProductId { get; set; }

        [Required]
        [Display(Name = "Manufacturer Id")]
        public int ManufacturerId { get; set; }

        [Required]
        [Display(Name = "Product Name")]
        public string ProductName { get; set; }

        [Display(Name = "Manufacturer")]
        public string ManufacturerName { get; set; }

        [Required]
        [Display(Name = "Price")]
        public double Price { get; set; }


        public virtual Manufacturer Manufacturer { get; set; }
    }
}
