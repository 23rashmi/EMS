using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EMS.Models;

namespace EMS.Data
{
    public class EmpProfileDbContext : DbContext
    {
        public EmpProfileDbContext (DbContextOptions<EmpProfileDbContext> options)
            : base(options)
        {
        }

        public DbSet<EMS.Models.EmpProfiles> EmpProfiles { get; set; } = default!;
    }
}
