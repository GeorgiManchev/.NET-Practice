using Academy.Commands.Contracts;
using Academy.Core.Contracts;
using Academy.Models;
using System.Collections.Generic;

namespace Academy.Commands.Abstractions
{
    public abstract class Command : ICommand
    {
        private readonly IDataManager dataManager;

        public Command(IDataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        protected IList<Season> Seasons { get => this.dataManager.Seasons; }

        protected IList<Student> Students { get => this.dataManager.Students; }

        protected IList<Trainer> Trainers { get => this.dataManager.Trainers; }

        public abstract string Execute(IList<string> parameters);
    }
}
