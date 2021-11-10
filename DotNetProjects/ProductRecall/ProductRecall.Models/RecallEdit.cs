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
    public class RecallEdit
    {
        public int RecallId { get; set; }

        public int ProductId { get; set; }

        [Display(Name = "Manufacturer Name")]
        public string ManufacturerName { get; set; }

        [Required]
        [Display(Name = "Product Name")]
        public string ProductName { get; set; }

        [Required]
        [Display(Name = "Description")]
        public string RecallTitle { get; set; }

        [Required]
        [Display(Name = "Recall start date")]
        public DateTimeOffset RecallDateStart { get; set; }

        [Required]
        [Display(Name = "Recall end date")]
        public DateTimeOffset RecallDateEnd { get; set; }
    }
}
