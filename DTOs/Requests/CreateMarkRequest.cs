using System.ComponentModel.DataAnnotations;

namespace DemoAPI.DTOs.Requests
{
    public class CreateMarkRequest
    {

        [Required]
        public int score { get; set; }

        [Required]
        public int student { get; set; }
    }
}
