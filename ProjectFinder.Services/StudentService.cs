﻿using EFA_Project_Finder.Data;
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

       // private readonly int _userId;

        //public StudentService(int userId)
        //{
        //    _userId = userId;
        //}

        public bool CreateStudent(StudentCreate model)
        {
            var entity =
                new Student()
                {
                    StudentId = model.StudentId,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    EnrollDate = DateTime.UtcNow
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

        public StudentDetail GetStudentById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .Students
                        .Single(e => e.StudentId == id);
                return
                                new StudentDetail
                                {
                                    StudentId = query.StudentId,
                                    FirstName = query.FirstName,
                                    LastName = query.LastName,
                                    GithubProfile = query.GithubProfile,
                                    EnrollDate = query.EnrollDate,
                                    Projects = (IEnumerable<Models.ProjectListItem>)query.Projects
                                };                  
            }
        }

        public bool UpdateStudent(StudentEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var original =
                    ctx
                    .Students
                    .Single(e => e.StudentId == model.StudentId);

                original.StudentId = model.StudentId;
                original.FirstName = model.FirstName;
                original.LastName = model.LastName;
                original.GithubProfile = model.GithubProfile;
                original.EnrollDate = original.EnrollDate;
                original.Projects = (IEnumerable<Project>)model.Projects;                

                return ctx.SaveChanges() == 1;
            }
        }

        public bool DeleteStudent(int studentId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Students
                        .Single(e => e.StudentId == studentId);
                ctx.Students.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
