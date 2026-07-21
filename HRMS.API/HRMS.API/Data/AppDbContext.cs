using Microsoft.EntityFrameworkCore;
using HRMS.API.Entities;

namespace HRMS.API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // DbSets
        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Department configuration
            modelBuilder.Entity<Department>(entity =>
            {
                entity.HasKey(x => x.Id);

                entity.Property(x => x.DepartmentName)
                      .IsRequired()
                      .HasMaxLength(100);

                entity.Property(x => x.DepartmentCode)
                      .IsRequired()
                      .HasMaxLength(20);

                entity.HasIndex(x => x.DepartmentCode)
                      .IsUnique();
            });
        }
    }
}