using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductRecall.Models
{
    public class ManufacturerDetail
    {
        [Display(Name = "Manufacturer ID")]
        public int ManufacturerId { get; set; }

        [Display(Name = "Manufacturer Name")]
        public string ManufacturerName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }

    }
}
