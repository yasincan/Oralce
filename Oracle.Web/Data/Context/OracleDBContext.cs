using Microsoft.EntityFrameworkCore;
using Oracle.Web.Data.Entities;

namespace Oracle.Web.Data.Context
{
    public class OracleDBContext : DbContext
    {
        public DbSet<Bird> Birds { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseOracle(@"User Id=;Password=;Data Source=127.0.0.1:1521/ORCLCDB.localdomain;");
        }
    }
}
