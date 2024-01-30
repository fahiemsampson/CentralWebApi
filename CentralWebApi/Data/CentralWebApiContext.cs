using CentralWebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CentralWebApi.Data
{
    public class CentralWebApiContext : DbContext
    {
        public CentralWebApiContext(DbContextOptions<CentralWebApiContext> options) : base(options)
        {

        }

        public DbSet<Complaint> Complaint { get; set; }
        public DbSet<Player> Player { get; set; }
        public DbSet<Team> Team { get; set; }
        //public DbSet<User> User { get; set; }
    }
}
