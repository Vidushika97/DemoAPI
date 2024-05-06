using DemoAPI.DTOs.Requests;
using DemoAPI.DTOs.Responses;

namespace DemoAPI.Services.MarkService
{
    public interface IMarkService
    {
        BaseResponse CreateMark(CreateMarkRequest request);

        BaseResponse MarksList();


    }
}
