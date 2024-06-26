﻿using System.ComponentModel.DataAnnotations;
using DemoAPI.Models;
using Microsoft.OpenApi.Any;

namespace DemoAPI.DTOs
{
    public class StudentDTO
    {
        [Required]
        public long id { get; set; }

        [Required]
        public string first_name { get; set; }

        [Required]
        public string last_name { get; set;}

        [Required]
        public string address { get; set; }

        [Required]
        public string email { get; set; }

        [Required]
        public string contact_number { get; set; }

        public int mark { get; set; }

        public string subject { get; set; }


    }
}
