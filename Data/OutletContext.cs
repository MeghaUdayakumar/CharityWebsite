using Microsoft.EntityFrameworkCore;
using WebsiteAPI.Models;

namespace WebsiteAPI.Data
{
    public class OutletContext : DbContext
    {
        public OutletContext(DbContextOptions<OutletContext> options) : base(options)
        {
            
        }
        public DbSet<Outlet> Outlets { get; set; }
        
        
    }
}