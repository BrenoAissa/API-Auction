using Microsoft.EntityFrameworkCore;
using RocketseatAuction.API.Entities;
using RocketSeatAuction.API.Communication.Requests;
using RocketSeatAuction.API.Entities;
using RocketSeatAuction.API.Repositories;

namespace RocketseatAuction.API.UseCases.Auctions.GetCurrent;

public class CreateOfferUseCase
{
    public void Execute(int itemId, RequestCreateOfferJson request)
    {
        var repository = new RocketSeatAuctionDbContext();

        var offer = new Offer
        {
            CreatedOn = DateTime.Now,
            ItemId = itemId,
            Price = request.Price,
            UserId
        };

        repository.Offers.Add();

    }
}