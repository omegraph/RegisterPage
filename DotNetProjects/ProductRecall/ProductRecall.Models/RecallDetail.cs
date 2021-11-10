using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductRecall.Models
{
    public class RecallDetail
    {
        public int RecallId { get; set; }

        [Display(Name = "Manufacturer Name")]
        public string ManufacturerName { get; set; }

        [Display(Name = "Product Name")]
        public string ProductName { get; set; }

        [Display(Name = "Description")]
        public string RecallTitle { get; set; }

        [Display(Name = "Recall start date")]
        public DateTimeOffset RecallDateStart { get; set; }

        [Display(Name = "Recall end date")]
        public DateTimeOffset RecallDateEnd { get; set; }
    }
}
