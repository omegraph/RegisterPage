using ProductRecall.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductRecall.Models
{
    public class ProductCreate
    {
        [Key]
        public int ProductId { get; set; }

        [Required]
        public int ManufacturerId { get; set; }

        [Required]
        [Display(Name = "Product Name")]
        public string ProductName { get; set; }

        [Display(Name = "Manufacturer")]
        public string ManufacturerName { get; set; }

        [Required]
        [Display(Name = "Price")]
        public double Price { get; set; }
    }
}
