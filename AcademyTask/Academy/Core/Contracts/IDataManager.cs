using Academy.Models;
using System.Collections.Generic;

namespace Academy.Core.Contracts
{
    public interface IDataManager
    {
        IList<Season> Seasons { get; }

        IList<Student> Students { get; }

        IList<Trainer> Trainers { get; }
    }
}