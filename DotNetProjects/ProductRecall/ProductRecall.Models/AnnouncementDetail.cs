using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductRecall.Models
{
    public class AnnouncementDetail
    {
        [Key]
        public int AnnouncementId { get; set; }

        [Required]
        public int RecallId { get; set; }

        public string RecallTitle { get; set; }

        [Display(Name = "Description")]
        public string AnnouncementTitle { get; set; }

        [Display(Name = "Date")]
        public DateTimeOffset AnnouncementDate { get; set; }
    }
}
