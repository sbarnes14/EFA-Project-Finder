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
        //    int studentId = User.Identity.GetStudentId);
        //    var studentService = new StudentService(studentId);
        //    return studentService;
        //}

        public IHttpActionResult Get()
        {
            //StudentService studentService = CreateStudentService();
            var students = _studentService.GetStudents();
            return Ok(students);
        }

        public IHttpActionResult Get(int id)
        {
            //StudentService studentService = CreateStudentService();
            var student = _studentService.GetStudentById(id);
            return Ok(student);
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
