using Microsoft.AspNet.Identity;
using ProjectFinder.Models;
using ProjectFinder.Models.Student;
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

        public IHttpActionResult Get()
        {
            var students = _studentService.GetStudents();
            return Ok(students);
        }

        public IHttpActionResult Get(int id)
        {
            var student = _studentService.GetStudentById(id);
            return Ok(student);
        }

        public IHttpActionResult Post(StudentCreate student)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (!_studentService.CreateStudent(student))
                return InternalServerError();

            return Ok();
        }

        public IHttpActionResult Put(StudentEdit student)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (!_studentService.UpdateStudent(student))
                return InternalServerError();

            return Ok();
        }
        public IHttpActionResult Delete(int id)
        {

            if (!_studentService.DeleteStudent(id))
                return InternalServerError();

            return Ok();
        }
    }
}
