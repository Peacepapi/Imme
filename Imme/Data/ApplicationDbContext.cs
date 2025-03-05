using Imme.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Imme.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {
        }

        public DbSet<Deck> Deck { get; set; }
        public DbSet<Card> Card { get; set; }

    }
}
