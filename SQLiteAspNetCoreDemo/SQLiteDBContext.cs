using Microsoft.EntityFrameworkCore;

namespace SQLiteAspNetCoreDemo
{
    public class SQLiteDBContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<TeamMembership> TeamMemberships { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite(@"Data Source=C:\Users\giorg\Desktop\Remitee\SQLiteAspNetCoreDemo\SQLiteAspNetCoreDemo\sqlitedemo.db");
    }
}
