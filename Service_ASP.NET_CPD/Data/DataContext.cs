using Microsoft.EntityFrameworkCore;
using Service_ASP.NET_CPD.Models;

namespace Service_ASP.NET_CPD.Data
{
    public class DataContext : DbContext
    {
        public DbSet<User> User { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<Authentication> Authentication { get; set; }
        public DbSet<Authorization> Authorization { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<Document>().ToTable("Documents");
            modelBuilder.Entity<Authentication>().ToTable("Authentication");
            modelBuilder.Entity<Authorization>().ToTable("Authorization");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;port=3306;database=CPD;uid=root;pwd=");
        }
    }
}
