using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations.Schema;



namespace fruitShop.Domain
{
    [Table("dFruit")]
    public class fruit: AuditedEntity<Int32>  /*Inherits from timestamp class*/
    {
        public string name { get; set; }
        public string colour { get; set; }
        public int stockAvailable { get; set; }
        public decimal pricePerItem { get; set; }

    }
}
