using DemoAPI.DTOs.Requests;
using DemoAPI.DTOs.Responses;
using DemoAPI.Services.StudentService;
using Microsoft.AspNetCore.Http;    
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;

namespace DemoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService studentService;

        //controller
        public StudentController(IStudentService studentService)
        {
            this.studentService = studentService;
        }

        //endpoints

        [HttpPost("save")]
        public BaseResponse CreateStudent(CreateStudentRequest request)
        {
            return studentService.CreateStudent(request);
        }

        [HttpGet("List")]
        public BaseResponse StudentList()
        {
            return studentService.StudentList();
        }

        [HttpGet("{id}")]
        public BaseResponse GetStudentById(long id)
        {
            return studentService.GetStudentById(id);
        }

        [HttpPut("{id}")]
        public BaseResponse UpdateStudentById(long id, UpdateStudentRequest request)
        {
            return studentService.UpdateStudentById(id, request);
        }

        [HttpDelete("{id}")]
        public BaseResponse DeleteStudentById(long id)
        {
            return studentService.DeleteStudentById(id);
        }

    }
}
