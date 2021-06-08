using ProjectFinder.Data;
using ProjectFinder.Models.Course;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFinder.Services
{
    public class CourseService
    {
        private readonly Guid _userId;

        public CourseService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateCourse(CourseCreate model)
        {
            var entity =
                new Course()
                {
                    Cohort = model.Cohort,
                    CourseType = model.CourseType,
                    StartDate = DateTimeOffset.Now
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Courses.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<CourseList> GetCourses()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                    .Courses
                    .Where(e => e.OwnerId == _userId) // OwnerId here?
                    .Select(
                        e =>
                        new CourseList
                        {
                            CourseId = e.CourseId,
                            CourseType = e.CourseType,
                            StartDate = e.StartDate
                        }
                        );
                return query.ToArray();
            }
        }
    }
}
