using ProductRecall.Data;
using ProductRecall.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductRecall.Services
{
    public class RecallService
    {

        public bool CreateRecall(RecallCreate model)
        {
            var entity =
            new Recall()
            {
                //ProductName = model.ProductName,
                RecallTitle = model.RecallTitle,
                RecallDateStart = model.RecallDateStart,
                RecallDateEnd = model.RecallDateEnd,
                ProductId = model.ProductId

            };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Recalls.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }


        public IEnumerable<RecallListItem> GetRecalls()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                    .Recalls.ToList()
                    .Select(c => new RecallListItem
                    {
                        RecallId = c.RecallId,
                        ProductName = c.Product.ProductName,
                        RecallTitle = c.RecallTitle,
                        RecallDateStart = c.RecallDateStart.ToString("dd-MMM-yyyy"),
                        RecallDateEnd = c.RecallDateEnd.ToString("dd-MMM-yyyy")
                    });
                return query.ToArray();
            }
        }

        public RecallDetail GetRecallById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Recalls
                        .Single(e => e.RecallId == id);
                return
                    new RecallDetail
                    {
                        RecallId = entity.RecallId,
                        ManufacturerName = entity.Product.Manufacturer.ManufacturerName,
                        ProductName = entity.Product.ProductName,
                        RecallTitle = entity.RecallTitle,
                        RecallDateStart = entity.RecallDateStart,
                        RecallDateEnd = entity.RecallDateEnd
                    };
            }
        }
        public List<ManufacturerProducts> GetProductsByManufacturerId(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                List<ManufacturerProducts> productList = new List<ManufacturerProducts>();

                var entity = ctx.Products.Where(x => x.ManufacturerId == id);

                //entity.ToList().ForEach(x => productList { ProductId = x.ProductId, Name =x.ProductName});

                foreach (var item in entity.ToList())
                {
                    productList.Add(new ManufacturerProducts() { ProductId = item.ProductId, Name = item.ProductName });
                }

                return productList;


            }
        }

        public bool UpdateRecall(RecallEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Recalls
                        .Single(e => e.RecallId == model.RecallId);

                //entity.ProductName = model.ProductName;
                entity.RecallTitle = model.RecallTitle;
                entity.RecallDateStart = model.RecallDateStart;
                entity.RecallDateEnd = model.RecallDateEnd;

                return ctx.SaveChanges() == 1;
            }
        }

        public bool DeleteRecall(int recallId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Recalls
                        .Single(e => e.RecallId == recallId);

                ctx.Recalls.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
