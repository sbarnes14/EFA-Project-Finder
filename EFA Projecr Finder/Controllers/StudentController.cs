using ProjectFinder.Models;
using ProjectFinder.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EFA_Projecr_Finder.Controllers
{
    [Authorize]
    public class StudentController : ApiController
    {
        private StudentService CreateStudentService()
        {
            var StudentId = Parse(ApplicationUserManager.Identity.GetStudentId());
            var StudentService = new StudentService(StudentId);
            return StudentService;
        }

        public IHttpActionResult Get()
        {
            StudentService studentService = CreateStudentService();
            var students = StudentService.GetStudents();
            return Ok(students);
        }

        public IHttpActionResult Post(StudentCreate student)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateStudentService();

            if (!service.CreateStudent(student))
                return InternalServerError();

            return Ok();
        }
    }
}
