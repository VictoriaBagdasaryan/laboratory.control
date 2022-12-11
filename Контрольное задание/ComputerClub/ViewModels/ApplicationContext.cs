using Microsoft.EntityFrameworkCore;

namespace ComputerClub.Models
{
    class ApplicationContext : DbContext
    {
        public DbSet<Computer> Computers { get; set; }
        public DbSet<ComputerStatus> ComputersStatuses { get; set; }
        public DbSet<Visit> Visits { get; set; }
        public DbSet<Visitor> Visitors { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=ComputerClub.db");
        }
    }
}
