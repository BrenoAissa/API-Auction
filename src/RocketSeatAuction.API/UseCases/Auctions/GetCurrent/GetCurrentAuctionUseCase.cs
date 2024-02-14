using Microsoft.EntityFrameworkCore;
using RocketseatAuction.API.Entities;
using RocketSeatAuction.API.Repositories;

namespace RocketseatAuction.API.UseCases.Auctions.GetCurrent;

public class GetCurrentAuctionUseCase
{
    public Auction? Execute()
    {
        var repository = new RocketSeatAuctionDbContext();

        var today = DateTime.Now;

        return repository.Auctions.Include(auction => auction.Items).FirstOrDefault(auction => today >= auction.Starts && today <= auction.Ends);
    }
}