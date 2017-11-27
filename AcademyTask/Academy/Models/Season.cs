using Academy.Models.Enums;
using System;
using System.Collections.Generic;

namespace Academy.Models
{
    public class Season
    {
        private readonly int startingYear;
        private readonly int endingYear;
        private readonly Initiative initiative;
        private readonly IList<Student> students;
        private readonly IList<Trainer> trainers;
        private readonly IList<Course> courses;

        public Season(int starting, int ending, Initiative initiative)
        {
            if (starting < 2016 || starting > 2017)
            {
                throw new ArgumentException("The season's starting year cannot be before 2016 or after 2017!");
            }
            this.startingYear = starting;

            if (ending < 2016 || ending > 2017)
            {
                throw new ArgumentException("The season's ending year cannot be before 2016 or after 2017!");
            }
            this.endingYear = ending;
            this.initiative = initiative;

            this.students = new List<Student>();
            this.trainers = new List<Trainer>();
            this.courses = new List<Course>();
        }

        public int StartingYear { get => this.startingYear; }

        public int EndingYear { get => this.endingYear; }

        public Initiative Initiative { get => this.initiative; }

        public IList<Student> Students { get => this.students; }

        public IList<Trainer> Trainers { get => this.trainers; }

        public IList<Course> Courses { get => this.courses; }
    }
}
