using Microsoft.EntityFrameworkCore;

namespace taller2.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options)    
        {
          
        }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Entrance> entrances { get; set; }

    }
}
