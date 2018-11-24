using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using T1708M1aspnet.Models;

namespace T1708M1aspnet.Models
{
    public class T1708M1aspnetContext : DbContext
    {
        public T1708M1aspnetContext (DbContextOptions<T1708M1aspnetContext> options)
            : base(options)
        {
        }

        public DbSet<T1708M1aspnet.Models.Product> Product { get; set; }

        public DbSet<T1708M1aspnet.Models.Category> Category { get; set; }
    }
}
