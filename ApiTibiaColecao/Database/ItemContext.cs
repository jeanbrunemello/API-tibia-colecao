using ApiTibiaColecao.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiTibiaColecao.Database
{
    public class ItemContext : DbContext
    {
        public ItemContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Item> Items { get; set; }
    }
}
