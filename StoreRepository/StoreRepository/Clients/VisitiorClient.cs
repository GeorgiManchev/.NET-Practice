using StoreRepository.Contracts;
using System.Collections.Generic;
using System.Linq;

namespace StoreRepository.Clients
{
    public class VisitiorClient : BaseClient
    {
        public VisitiorClient(IStoreContext context) : base(context)
        {
        }

        public IDictionary<int, string> ListBooks()
        {
            var bookList = new SortedDictionary<int, string>(); //key=id value=title
            
            return bookList;
        }
    }
}
