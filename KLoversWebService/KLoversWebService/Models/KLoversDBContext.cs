using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KLoversWebService.Models
{
    public class KLoversDBContext : DbContext
    {
        public DbSet<AppUser> AppUsers { get; set; }

        public KLoversDBContext(DbContextOptions<KLoversDBContext> options) : base(options)
        {

        }
    }
}
