using EFA_Project_Finder;
using EFA_Project_Finder.Data;
using ProjectFinder.Data;
using ProjectFinder.Models;
using ProjectFinder.Models.Course;
using ProjectFinder.Models.Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFinder.Services
{
    public class ProjectService
    {
        private readonly Guid _userId;

        public ProjectService(Guid userId)
        {
            _userId = userId;
        }
        public bool CreateProject(ProjectCreate model)
        {
            var entity =
                new Project()
                {
                    OwnerId = _userId,
                    ProjectName = model.Projectname,
                    ProjectDescription = model.ProjectDescription,
                    StartDate = DateTimeOffset.Now,
                    EndDate = DateTimeOffset.Now
                };
            using (var ctx = new ApplicationDbContext())
            {
                ctx.Projects.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }
        public IEnumerable<ProjectListItem> GetProjects()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .Projects
                        .Where(e => e.OwnerId == _userId)
                        .Select(
                                e =>
                                        new ProjectListItem
                                        {
                                            ProjectId = e.ProjectId,
                                            ProjectName = e.ProjectName
                                        }
                    );
                return query.ToArray();
            }
        }
        public ProjectDetail GetProjectById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Projects
                        .Single(e => e.ProjectId == id && e.OwnerId == _userId);
                return
                    new ProjectDetail
                    {
                        ProjectId = entity.ProjectId,
                        ProjectName = entity.ProjectName,
                        ProjectDescription = entity.ProjectDescription,
                        CreatedUtc = entity.StartDate,
                        ModfiedUtc = entity.EndDate,
                        Students = entity.Students.Select(x => new StudentDetail
                        {
                            StudentId = x.StudentId,
                            Name = x.FirstName + " " + x.LastName,
                            GithubProfile = x.GithubProfile,
                            Course = x.Course.Cohort + " " + x.Course.CourseType,
                            EnrollDate = x.EnrollDate,
                        }).ToList(),                        
                    };
            }
        }
        public bool UpdateProject(ProjectEdit model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Projects
                        .Single(e => e.ProjectId == model.ProjectId && e.OwnerId == _userId);
                entity.ProjectName = model.ProjectName;
                entity.ProjectDescription = model.ProjectDescription;
                entity.StartDate = DateTimeOffset.UtcNow;

                return ctx.SaveChanges() == 1;
            }
        }
        public bool DeleteProject(int projectId)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .Projects
                        .Single(e => e.ProjectId == projectId && e.OwnerId == _userId);
                ctx.Projects.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
