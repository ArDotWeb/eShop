﻿
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShop.WebApplication.DomainClasses.AppClasses
{
    public class Comment
    {
        public int Id { get; set; }

        public string Explain { get; set; }
        public DateTime DateTimeComment { get; set; }


        public bool DisplayStatus { get; set; }
        public bool ReadStatus { get; set; }

        [ForeignKey("Product_Id")]
        public virtual Product Product { get; set; }
        public int? Product_Id { get; set; }


        [ForeignKey("User_Id")]
        public virtual ApplicationUser ApplicationUser { get; set; }
        public int? User_Id { get; set; }
    }
}
