﻿using System.ComponentModel.DataAnnotations;

namespace core_backend.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ContactNumber { set; get; }
    }
}
