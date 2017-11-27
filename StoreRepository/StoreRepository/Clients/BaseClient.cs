using StoreRepository.Contracts;

namespace StoreRepository.Clients
{
    public abstract class BaseClient
    {
        private readonly IStoreContext context;
        public BaseClient(IStoreContext context)
        {
            this.context = context;
        }

        protected IStoreContext Context { get { return this.context; } }
    }
}
