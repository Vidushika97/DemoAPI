
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

namespace DemoAPI.Services.MarkService
{
    public class MarkService : IMarkService
    {
        //variable to store application db context
        private readonly ApplicationDbContext context;

        public MarkService(ApplicationDbContext applicationDbContext)
        {
            //get db context through DI
            context = applicationDbContext;
        }


        public BaseResponse CreateMark(CreateMarkRequest request)
        {
            BaseResponse response;
            try
            {

                // create new instace of student model

                MarkModel newMark = new MarkModel();
                newMark.score = request.score;
                newMark.studentId = request.student;
                newMark.subjectId = request.subjectId;



                using (context)
                {
                    context.Add(newMark);
                    context.SaveChanges();

                }

                response = new BaseResponse
                {
                    status_code = StatusCodes.Status200OK,
                    data = new { message = "Successfully created the new mark" }
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


        public BaseResponse MarksList()
        {
            BaseResponse response;

            try
            {
                List<StudentDTO> marks = new List<StudentDTO>();

                using (context)
                {

                    // work //////////////////

                    // var joinedData = from student in context.Students
                    //                  join mark in context.Marks on student.id equals mark.studentId
                    //                  select new
                    //                  {
                    //                      StudentName = student.first_name,
                    //                      MarkValue = mark.score
                    //                  };

                    // foreach (var data in joinedData)
                    // {
                    //     Console.WriteLine($"Student: {data.StudentName}, Mark: {data.MarkValue}");
                    // }


                    // new

                    var joinedData = from student in context.Students
                                     join mark in context.Marks on student.id equals mark.studentId
                                     join subject in context.Subjects on mark.subjectId equals subject.id
                                     select new StudentDTO
                                     {
                                         first_name = student.first_name,
                                         last_name = student.last_name,
                                         address = student.address,
                                         email = student.email,
                                         contact_number = student.contact_number,
                                         mark = mark.score,
                                         subject = subject.subject
                                     };

                    marks = joinedData.ToList();


                }

                response = new BaseResponse
                {
                    status_code = StatusCodes.Status200OK,
                    data = marks
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


