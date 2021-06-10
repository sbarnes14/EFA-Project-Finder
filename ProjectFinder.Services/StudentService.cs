using EFA_Project_Finder.Data;
using ProjectFinder.Data;
using ProjectFinder.Models;
using ProjectFinder.Models.Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFinder.Services
{
    public class StudentService
    {
        //private readonly int _userId;

        //public StudentService(int userId)
        //{
        //    _userId = userId;
        //}

        public bool CreateStudent(StudentCreate model)
        {
            var entity =
                new Student()
                {
                    //StudentId = _userId,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    EnrollDate = DateTimeOffset.Now
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Students.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<StudentListItem> GetStudents()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .Students
                        //.Where(e => e.StudentId == _userId)//not sure of this
                        .Select(
                            e =>
                                new StudentListItem
                                {
                                    StudentId = e.StudentId,
                                    FirstName = e.FirstName,
                                    LastName = e.LastName,
                                    EnrollDate = e.EnrollDate
                                }
                        );
                return query.ToArray();
            }
        }
    }
}
