using Academy.Core.Contracts;
using Academy.Core.Providers;
using Academy.Models;
using Academy.Models.Abstractions;
using Academy.Models.Enums;
using Academy.Models.LectureResources;
using System;

namespace Academy.Core.Factories
{
    public class AcademyFactory : IAcademyFactory
    {
        public Season CreateSeason(string startingYear, string endingYear, string initiative)
        {
            var parsedStartingYear = int.Parse(startingYear);
            var parsedEngingYear = int.Parse(endingYear);

            Enum.TryParse(initiative, out Initiative parsedInitiativeAsEnum);

            return new Season(parsedStartingYear, parsedEngingYear, parsedInitiativeAsEnum);
        }

        public Student CreateStudent(string username, string track)
        {
            Enum.TryParse(track, out Track parsedTrackAsEnum);

            return new Student(username, parsedTrackAsEnum);
        }

        public Trainer CreateTrainer(string username, string technologies)
        {
            return new Trainer(username, technologies.Split(','));
        }

        public Course CreateCourse(string name, string lecturesPerWeek, string startingDate)
        {
            var lectures = int.Parse(lecturesPerWeek);
            var starting = DateTime.Parse(startingDate);
            var ending = starting.AddDays(30);

            return new Course(name, lectures, starting, ending);
        }

        public Lecture CreateLecture(string name, string date, Trainer trainer)
        {
            var parsedDate = DateTime.Parse(date);

            return new Lecture(name, parsedDate, trainer);
        }

        public Resource CreateLectureResource(string type, string name, string url)
        {
            // Use this instead of DateTime.Now if you want any points in BGCoder!!
            var currentDate = DateTimeProvider.Now;

            switch (type)
            {
                case "video": return new VideoResource(name, url, currentDate);
                case "presentation": return new PresentationResource(name, url);
                case "demo": return new DemoResource(name, url);
                case "homework": return new HomeworkResource(name, url, currentDate.AddDays(7));
                default: throw new ArgumentException("Invalid lecture resource type");
            }
        }

        public CourseResult CreateCourseResult(Course course, string examPoints, string coursePoints)
        {
            return new CourseResult(course, double.Parse(examPoints), double.Parse(coursePoints));
        }
    }
}
