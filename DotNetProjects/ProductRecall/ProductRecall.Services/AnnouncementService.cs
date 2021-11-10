using ProductRecall.Data;
using ProductRecall.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductRecall.Services
{
    public class AnnouncementService
    {
        public bool CreateAnnouncement(AnnouncementCreate model)
        {
            var entity =
            new Announcement()
            {
                AnnouncementTitle = model.AnnouncementTitle,
                AnnouncementDate = model.AnnouncementDate,
                RecallId = model.RecallId
            };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Announcements.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<AnnouncementListItem> GetAnnouncements()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                    .Announcements.ToList()
                    .Select(c => new AnnouncementListItem
                    {
                        AnnouncementId = c.AnnouncementId,
                        AnnouncementTitle = c.AnnouncementTitle,
                        AnnouncementDate = c.AnnouncementDate.ToString("dd-MMM-yyyy"),
                        RecallTitle = c.Recall.RecallTitle

                    });
                return query.ToArray();
            }
        }

        public AnnouncementDetail GetAnnouncementById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Announcements
                        .Single(e => e.AnnouncementId == id);
                return
                    new AnnouncementDetail
                    {
                        AnnouncementId = entity.AnnouncementId,
                        AnnouncementTitle = entity.AnnouncementTitle,
                        AnnouncementDate = entity.AnnouncementDate,
                        RecallTitle = entity.Recall.RecallTitle
                    };
            }
        }

        public bool UpdateAnnouncement(AnnouncementEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Announcements
                        .Single(e => e.AnnouncementId == model.AnnouncementId);

                entity.AnnouncementTitle = model.AnnouncementTitle;
                entity.AnnouncementDate = model.AnnouncementDate;

                return ctx.SaveChanges() == 1;
            }

        }

        public bool DeleteAnnouncement(int announcementId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Announcements
                        .Single(e => e.AnnouncementId == announcementId);

                ctx.Announcements.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
