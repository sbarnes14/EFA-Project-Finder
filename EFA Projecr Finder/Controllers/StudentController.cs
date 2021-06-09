using Microsoft.AspNet.Identity;
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
            var StudentId = User.Identity.GetUserId();
            var StudentService = new StudentService(Convert.ToInt32(StudentId));
            return StudentService;
        }

        public IHttpActionResult Get()
        {
            StudentService studentService = CreateStudentService();
            var students = studentService.GetStudents();
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
