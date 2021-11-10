using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductRecall.Data
{
    public class Recall
    {
        [Key]
        public int RecallId { get; set; }

        [Required]
        public int ProductId { get; set; }


        [Required]
        [Display(Name = "Title")]
        public string RecallTitle { get; set; }

        [Required]
        [Display(Name = "Start Date")]
        public DateTimeOffset RecallDateStart { get; set; }

        [Required]
        [Display(Name = "End Date")]
        public DateTimeOffset RecallDateEnd { get; set; }

        public virtual Product Product { get; set; }
        //public virtual Manufacturer Manufacturer { get; set; }

    }
}
