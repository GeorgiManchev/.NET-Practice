using StoreRepository.Contracts;
using StoreRepository.Models;
using System.Data.Entity;

namespace StoreRepository.Context
{
    public class StoreContext : DbContext, IStoreContext
    {
        public StoreContext() : base("name=StoreContext")
        {
            Database.CreateIfNotExists();
        }

        public IDbSet<Book> Books { get; set; }
        public IDbSet<Author> Authors { get; set; }
        public IDbSet<Offer> Offers { get; set; }
        public IDbSet<Sale> Sales { get; set; }

    }
}
