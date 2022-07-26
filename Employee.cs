﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SampleWebApi.Model
{
    [Table("Employee")]
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
}
