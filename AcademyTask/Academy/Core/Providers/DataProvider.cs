using Academy.Core.Contracts;
using Academy.Models;
using System.Collections.Generic;

namespace Academy.Core.Providers
{
    public class DataProvider : IDataManager
    {
        private readonly IList<Season> seasons = new List<Season>();
        private readonly IList<Student> students = new List<Student>();
        private readonly IList<Trainer> trainers = new List<Trainer>();

        public IList<Season> Seasons { get => this.seasons; }

        public IList<Student> Students { get => this.students; }

        public IList<Trainer> Trainers { get => this.trainers; }
    }
}
