﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShop.WebApplication.DomainClasses.AppClasses
{
    public class Order
    {
        public int Id { get; set; }
        public virtual Sale Sale { get; set; }
        public string Name { get; set; }
        public int Product_Id { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public string StatusTypeOrder { get; set; }
    }
}