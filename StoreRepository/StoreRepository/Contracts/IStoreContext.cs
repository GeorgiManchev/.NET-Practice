using StoreRepository.Models;
using System.Data.Entity;

namespace StoreRepository.Contracts
{
    public interface IStoreContext
    {
        IDbSet<Book> Books { get; }
        IDbSet<Author> Authors { get; }
        IDbSet<Offer> Offers { get; }
        IDbSet<Sale> Sales { get; }
    }
}