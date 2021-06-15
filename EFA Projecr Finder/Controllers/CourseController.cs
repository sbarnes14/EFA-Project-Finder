using Microsoft.AspNet.Identity;
using ProjectFinder.Models.Course;
using ProjectFinder.Services;
using System;
using System.Web.Http;

namespace EFA_Projecr_Finder.Controllers
{
    [Authorize]
    public class CourseController : ApiController
    {
        public IHttpActionResult Get()
        {
            CourseService courseService = CreateCourseService();
            var courses = courseService.GetCourses();
            return Ok(courses);
        }

        public IHttpActionResult Get(int id)
        {
            CourseService courseService = CreateCourseService();
            var course = courseService.GetCourseById(id);
            return Ok(course);
        }

        public IHttpActionResult Post(CourseCreate course)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateCourseService();

            if (!service.CreateCourse(course))
                return InternalServerError();

            return Ok();
        }

        private CourseService CreateCourseService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var courseService = new CourseService(userId);
            return courseService;
        }

        public IHttpActionResult Put(CourseEdit course)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateCourseService();

            if (!service.UpdateCourse(course))
                return InternalServerError();

            return Ok();
        }

        public IHttpActionResult Delete(int id)
        {
            var service = CreateCourseService();

            if (!service.DeleteCourse(id))
                return InternalServerError();

            return Ok();
        }
    }
}
