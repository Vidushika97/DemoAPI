
using DemoAPI.DTOs;
using DemoAPI.DTOs.Requests;
using DemoAPI.DTOs.Responses;
using DemoAPI.Models;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Http;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;

namespace DemoAPI.Services.SubjectService
{
    public class SubjectService : ISubjectService
    {
        //variable to store application db context
        private readonly ApplicationDbContext context;

        public SubjectService(ApplicationDbContext subjectDbContext)
        {
            //get db context through DI
            context = subjectDbContext;
        }


        public BaseResponse CreateSubject(CreateSubjectRequest request)
        {
            BaseResponse response;
            try
            {

                // create new instace of student model

                SubjectModel newSubject = new SubjectModel();
                newSubject.subject = request.subject;


                using (context)
                {
                    context.Add(newSubject);
                    context.SaveChanges();

                }

                response = new BaseResponse
                {
                    status_code = StatusCodes.Status200OK,
                    data = new { message = "Successfully created the new subject" }
                };

                return response;
            }
            catch (Exception ex)
            {
                response = new BaseResponse
                {
                    status_code = StatusCodes.Status500InternalServerError,
                    data = new { message = "Internal server error : " + ex.Message }
                };

                return response;
            }
        }


    }
}


