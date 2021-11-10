using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductRecall.Data
{
    public class Announcement
    {
        [Key]
        public int AnnouncementId { get; set; }

        [ForeignKey(nameof(Recall))]
        public int RecallId { get; set; }
        public virtual Recall Recall { get; set; }

        [Required]
        [Display(Name = "Announcement Title")]
        public string AnnouncementTitle { get; set; }

        public DateTimeOffset AnnouncementDate { get; set; }

    }
}
