using EFA_Project_Finder;
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
    }
}
