using DemoAPI.DTOs.Requests;
using DemoAPI.DTOs.Responses;

namespace DemoAPI.Services.SubjectService
{
    public interface ISubjectService
    {
        BaseResponse CreateSubject(CreateSubjectRequest request);

        // BaseResponse SubjectList();


    }
}
