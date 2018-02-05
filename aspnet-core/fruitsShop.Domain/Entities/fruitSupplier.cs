using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations.Schema;

namespace fruitShop.Domain
{
    public class fruitSupplier
    {
        public int fruitId { get; set; }
        public fruit fruits { get; set; }

        public int supplierId { get; set; }
        public supplier suppliers { get; set; }

    }
}
