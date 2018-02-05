using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations.Schema;



namespace fruitShop.Domain
{
    [Table("dSuppliers")]
    public class supplier: AuditedEntity<Int32>  /*Inherits from timestamp class*/
    {
        public string Name { get; set; }
        public string Contact { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public fruit





    }
}
