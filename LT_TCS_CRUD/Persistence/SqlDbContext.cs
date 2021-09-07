using LT_TCS_CRUD.Models;
using Microsoft.EntityFrameworkCore;

namespace LT_TCS_CRUD.Persistence
{
    public class SqlDbContext : DbContext
    {
        public SqlDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Contato> Contatos { get; set; }
    }
}
