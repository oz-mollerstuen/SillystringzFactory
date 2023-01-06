using Microsoft.EntityFrameworkCore;

namespace Factory.Models
{
    public class FactoryContext : DbContext
    {
        public DbSet<Machine> Machines { get; set; }
        public DbSet<Engineer> Engineer { get; set; }
        public DbSet<MachineEngineer> MachineEngineer { get; set; }
        public FactoryContext(DbContextOptions options) : base (options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        
    }
    }
}