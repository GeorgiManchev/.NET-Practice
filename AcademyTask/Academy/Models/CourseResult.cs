using Academy.Models.Enums;
using System;

namespace Academy.Models
{
    public class CourseResult
    {
        private readonly double examPoints;
        private readonly double coursePoints;
        private readonly Course course;

        public CourseResult(Course course, double examPoints, double coursePoints)
        {
            this.course = course ?? throw new ArgumentNullException("Course is null");

            if (examPoints < 0 || examPoints > 1000)
            {
                throw new ArgumentException("Course result's exam points should be between 0 and 1000!");
            }

            this.examPoints = examPoints;
            if (coursePoints < 0 || coursePoints > 125)
            {
                throw new ArgumentException("Course result's course points should be between 0 and 125!");
            }
            this.coursePoints = coursePoints;
        }

        public Course Course { get => this.course; }

        public double ExamPoints { get => this.examPoints; }

        public double CoursePoints { get => this.coursePoints; }

        public Grade Grade
        {
            get
            {
                var result = Grade.Failed;
                if (this.examPoints >= 60 || this.coursePoints >= 75)
                {
                    result = Grade.Excellent;
                }
                else if (this.examPoints >= 30 || this.coursePoints >= 45)
                {
                    result = Grade.Passed;
                }

                return result;
            }
        }

        public override string ToString()
        {
            return $"  * {this.course.Name}: Points - {this.coursePoints}, Grade - {this.Grade}";
        }
    }
}
