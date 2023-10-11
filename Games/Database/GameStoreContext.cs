using Games.Models;
using Microsoft.EntityFrameworkCore;

namespace Games.Database
{
    public class GameStoreContext: DbContext
    {
        public DbSet<Game> Games { get; set; }
        public GameStoreContext(DbContextOptions op) : base(op)
        {
        
        }
    }
}
