using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Abp.Domain.Entities.Auditing;
using System.ComponentModel.DataAnnotations.Schema;

namespace fruitShop.Domain
{
    [Table("dStaff")]
    public class staff : AuditedEntity<Int32>  /*Inherits from timestamp class*/
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

    }
}
