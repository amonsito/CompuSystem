using Microsoft.EntityFrameworkCore;

namespace CompuSystem.Data
{
    public class CompuSystemDbContext : DbContext
    {
        public CompuSystemDbContext(DbContextOptions<CompuSystemDbContext> options):base(options) 
        { 
        }
    }
}
