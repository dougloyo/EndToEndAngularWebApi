using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BaseArchitecture.WebApi.Web.Api.Controllers
{
    [RoutePrefix("api/Orders")]
    public class StudentsController : ApiController
    { 
        [Authorize]
        [Route("")]
        public IHttpActionResult Get()
        {
            return Ok(Student.CreateOrders());
        }

    }

    #region Helpers

    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Boolean IsEnrolled { get; set; }

        public static List<Student> CreateOrders()
        {
            List<Student> students = new List<Student>
            {
                new Student {StudentId = 10248, FirstName = "Taiseer Joudeh", LastName = "Amman", IsEnrolled = true },
                new Student {StudentId = 10249, FirstName = "Ahmad Hasan", LastName = "Dubai", IsEnrolled = false},
                new Student {StudentId = 10250, FirstName = "Tamer Yaser", LastName = "Jeddah", IsEnrolled = false },
                new Student {StudentId = 10251, FirstName = "Lina Majed", LastName = "Abu Dhabi", IsEnrolled = false},
                new Student {StudentId = 10252, FirstName = "Yasmeen Rami", LastName = "Kuwait", IsEnrolled = true}
            };

            return students;
        }
    }

    #endregion
}
