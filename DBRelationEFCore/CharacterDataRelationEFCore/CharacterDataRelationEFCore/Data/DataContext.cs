using CharacterDataRelationEFCore.Models;
using Microsoft.EntityFrameworkCore;

namespace CharacterDataRelationEFCore.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<Character> Characters { get; set; }
        public DbSet<BackPack> BackPacks { get; set; }

        public DbSet<Weapon> Weapons { get; set; }

        public DbSet<Clan> Clans { get; set; }

    }
}
