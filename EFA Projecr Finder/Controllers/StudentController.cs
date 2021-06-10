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
        private StudentService _studentService = new StudentService();

        //private StudentService CreateStudentService()
        //{
        //    var studentId = User.Identity.GetUserId();
        //    var studentService = new StudentService(Convert.ToInt32(studentId));
        //    return studentService;
        //}

        public IHttpActionResult Get()
        {
            //StudentService studentService = CreateStudentService();
            var students = _studentService.GetStudents();
            return Ok(students);
        }

        public IHttpActionResult Post(StudentCreate student)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            //var service = CreateStudentService();

            if (!_studentService.CreateStudent(student))
                return InternalServerError();

            return Ok();
        }
    }
}
