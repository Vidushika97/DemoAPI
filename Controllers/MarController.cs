using DemoAPI.DTOs.Requests;
using DemoAPI.DTOs.Responses;
using DemoAPI.Services.MarkService;
using DemoAPI.Services.StudentService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;

namespace DemoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarkController : ControllerBase
    {
        private readonly IMarkService markService;

        //controller
        public MarkController(IMarkService markService)
        {
            this.markService = markService;
        }

        //endpoints

        [HttpPost("save")]
        public BaseResponse CreateMark(CreateMarkRequest request)
        {
            return markService.CreateMark(request);
        }

        [HttpGet("List")]
        public BaseResponse MarksList()
        {
            return markService.MarksList();
        }

    }
}
