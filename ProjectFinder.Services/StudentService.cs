using EFA_Project_Finder.Data;
using ProjectFinder.Data;
using ProjectFinder.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFinder.Services
{
    public class StudentService
    {
        public bool CreateStudent(StudentCreate model)
        {
            var entity =
                new Student()
                {
                    StudentId = model.StudentId,
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
    }
}
