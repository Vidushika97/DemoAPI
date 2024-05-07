using DemoAPI.DTOs.Requests;
using DemoAPI.DTOs.Responses;
using DemoAPI.Services.MarkService;
using DemoAPI.Services.StudentService;
using DemoAPI.Services.SubjectService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;

namespace DemoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectController : ControllerBase
    {
        private readonly ISubjectService subjectService;

        //controller
        public SubjectController(ISubjectService subjectService)
        {
            this.subjectService = subjectService;
        }

        //endpoints

        [HttpPost("save")]
        public BaseResponse CreateMark(CreateSubjectRequest request)
        {
            return subjectService.CreateSubject(request);
        }

        // [HttpGet("List")]
        // public BaseResponse MarksList()
        // {
        //     return markService.MarksList();
        // }

    }
}
