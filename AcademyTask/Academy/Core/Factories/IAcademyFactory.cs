using Academy.Models;
using Academy.Models.Abstractions;

namespace Academy.Core.Contracts
{
    public interface IAcademyFactory
    {
        Season CreateSeason(string startingYear, string endingYear, string initiative);

        Student CreateStudent(string username, string track);
        Trainer CreateTrainer(string username, string technologies);

        Course CreateCourse(string name, string lecturesPerWeek, string startingDate);
        CourseResult CreateCourseResult(Course course, string examPoints, string coursePoints);

        Lecture CreateLecture(string name, string date, Trainer trainer);
        Resource CreateLectureResource(string type, string name, string url);
    }
}
