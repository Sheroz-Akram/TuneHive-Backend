using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TuneHive.Domain.Entity;

namespace TuneHive.Persistence
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> context) : base(context) {

        }

        public DbSet<ApplicationUser> Users { get; set; }

    }
}
