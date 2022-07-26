using Microsoft.EntityFrameworkCore;
using SampleWebApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleWebApi.Entities
{
    public class RepositoriesContext:DbContext 
    {
        public RepositoriesContext(DbContextOptions options):base(options){ }

        public DbSet<Product> Products { get; set; }

        public DbSet<Employee> Employees { get; set; }
    }
}
