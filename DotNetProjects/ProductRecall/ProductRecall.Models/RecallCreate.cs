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
    public class RecallCreate
    {
        [Key]
        public int RecallId { get; set; }

        [Display(Name = "Product")]
        public int ProductId { get; set; }

        public string Manufacturer { get; set; }
        //[Required]
        //[Display(Name = "Select Product")]
        //public string ProductName { get; set; }

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
