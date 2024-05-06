using System.ComponentModel.DataAnnotations;
using DemoAPI.Models;
using Microsoft.OpenApi.Any;

namespace DemoAPI.DTOs
{
    public class MarkDto
    {
        [Required]
        public long id { get; set; }

        [Required]
        public int score { get; set; }

        [Required]
        public int studentId { get; set;}

    }
}
