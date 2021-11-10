using ProductRecall.Data;
using ProductRecall.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductRecall.Services
{
    public class ManufacturerService
    {

        public bool CreateManufacturer(ManufacturerCreate model)
        {
            var entity =
            new Manufacturer()
            {
                ManufacturerName = model.ManufacturerName,
                Address = model.Address,
                City = model.City,
                State = model.State,
                ZipCode = model.ZipCode
            };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Manufacturers.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<ManufacturerListItem> GetManufacturers()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                    .Manufacturers
                    .Select(c => new ManufacturerListItem
                    {
                        ManufacturerId = c.ManufacturerId,
                        ManufacturerName = c.ManufacturerName,
                        Address = c.Address,
                        City = c.City,
                        State = c.State,
                        ZipCode = c.ZipCode

                    });
                return query.ToArray();
            }
        }

        public ManufacturerDetail GetManufacturerById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Manufacturers
                        .Single(e => e.ManufacturerId == id);
                return
                    new ManufacturerDetail
                    {
                        ManufacturerId = entity.ManufacturerId,
                        ManufacturerName = entity.ManufacturerName,
                        Address = entity.Address,
                        City = entity.City,
                        State = entity.State,
                        ZipCode = entity.ZipCode
                    };
            }

        }

        public bool UpdateManufacturer(ManufacturerEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Manufacturers
                        .Single(e => e.ManufacturerId == model.ManufacturerId);

                entity.ManufacturerName = model.ManufacturerName;
                entity.Address = model.Address;
                entity.City = model.City;
                entity.State = model.State;
                entity.ZipCode = model.ZipCode;

                return ctx.SaveChanges() == 1;
            }
        }

        public bool DeleteManufacturer(int manufacturerId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Manufacturers
                        .Single(e => e.ManufacturerId == manufacturerId);

                ctx.Manufacturers.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
