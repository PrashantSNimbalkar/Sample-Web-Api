using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SampleWebApi.Model
{
    [Table("Product")] // mapping of Table Product with class product
    public class Product
    {
        [Key] // primary key col
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
    }

  }
