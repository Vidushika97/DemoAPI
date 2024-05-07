using System.ComponentModel.DataAnnotations;

namespace DemoAPI.DTOs.Requests
{
    public class CreateSubjectRequest
    {

        [Required]
        public string subject { get; set; }

    }
}
