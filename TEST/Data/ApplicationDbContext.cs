using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TEST.Models;

namespace TEST.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<COMPANYADDRESS> COMPANYADDRESS { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<COMPANYADDRESS>(entity =>
            {
                entity.ToTable("COMPANYADDRESS", "NAII");
                entity.HasKey(e => new { e.COMPANYID, e.MAINADDRESSESID });
            });

            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
