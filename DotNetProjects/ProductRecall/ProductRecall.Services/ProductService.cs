using ProductRecall.Data;
using ProductRecall.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductRecall.Services
{
    public class ProductService
    {

        public bool CreateProduct(ProductCreate model)
        {
            var entity =
            new Product()
            {
                ProductName = model.ProductName,
                Price = model.Price,
                ManufacturerId = model.ManufacturerId
            };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Products.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }


        public IEnumerable<ProductListItem> GetProducts()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                    .Products
                    .Select(c => new ProductListItem
                    {
                        ProductId = c.ProductId,
                        ProductName = c.ProductName,
                        Price = c.Price,
                        Manufacturer = c.Manufacturer.ManufacturerName
                    });
                return query.ToArray();
            }
        }

        public ProductDetail GetProductById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity = ctx.Products.Single(e => e.ProductId == id);

                return
                    new ProductDetail
                    {
                        ProductId = entity.ProductId,
                        ProductName = entity.ProductName,
                        Price = entity.Price,
                        ManufacturerId = entity.ManufacturerId,
                        ManufacturerName = entity.Manufacturer.ManufacturerName

                    };
            }
        }

        public bool UpdateProduct(ProductEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Products
                        .Single(e => e.ProductId == model.ProductId);

                entity.ManufacturerId = model.ManufacturerId;
                entity.ProductName = model.ProductName;
                entity.Price = model.Price;

                return ctx.SaveChanges() == 1;
            }
        }

        public bool DeleteProduct(int productId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Products
                        .Single(e => e.ProductId == productId);

                ctx.Products.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }

    }
}
