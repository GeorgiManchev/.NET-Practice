using Academy.Core.Contracts;

namespace Academy.Commands.Abstractions
{
    public abstract class CreateCommand : Command
    {
        private readonly IAcademyFactory factory;

        public CreateCommand(IAcademyFactory factory, IDataManager dataManager) : base(dataManager)
        {
            this.factory = factory;
        }

        protected IAcademyFactory Factory { get => this.factory; }
    }
}
