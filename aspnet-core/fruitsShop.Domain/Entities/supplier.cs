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
        public string supplierName { get; set; }
        public string supplierContact { get; set; }
        public string supplierPhoneNumber { get; set; }
        public string supplierEmail { get; set; }

    }
}
