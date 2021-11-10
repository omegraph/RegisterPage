using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductRecall.Models
{
    public class AnnouncementCreate
    {
        [Key]
        public int AnnouncementId { get; set; }

        [Required]
        public int RecallId { get; set; }
        public string RecallTitle { get; set; }

        [Required]
        [Display(Name = "Description")]
        public string AnnouncementTitle { get; set; }
        public DateTimeOffset AnnouncementDate { get; set; }

    }
}
