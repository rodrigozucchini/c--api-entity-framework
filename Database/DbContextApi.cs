using Microsoft.EntityFrameworkCore;

namespace TodoApi.Model
{
    public class DbContextApi : DbContext
    {
        public DbContextApi(DbContextOptions<DbContextApi> options) : base(options) {}
        public DbSet<Cliente> Clientes { get; set; }
    }
}