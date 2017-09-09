using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.DotNetCore.CodeFirst.Domain
{
    public class DotNetCoreContext : DbContext
    {

        public DotNetCoreContext()
        {

        }

        public DotNetCoreContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<User> User { get; set; }

    }
}
