using Microsoft.EntityFrameworkCore;
using RocketseatAuction.API.Entities;
using RocketSeatAuction.API.Entities;

namespace RocketSeatAuction.API.Repositories
{
    public class RocketSeatAuctionDbContext : DbContext
    {

        public RocketSeatAuctionDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Auction> Auctions { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Offer> Offers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=C:\Users\breno\source\repos\BrenoAissa\API-Auction\leilaoDbNLW.db");
        }
    }
}
