using System;
using System.Collections.Generic;
using System.Text;
using Abp.AutoMapper;
using fruitShop.Domain;
using Abp.Application.Services.Dto;
using System.ComponentModel.DataAnnotations;

namespace fruitShop.Application.fruitApplication.dto
{
    [AutoMap(typeof(fruit))]
    public class fruitdto: AuditedEntityDto<Int32>
    {
        public string name { get; set; }
        public string colour { get; set; }
        public int stockAvailable { get; set; }
        public decimal pricePerItem { get; set; }


    }




}
