﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace undefined_shoes_api.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public int Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpDateAt { get; set; }
        public DateTime DeletedAt { get; set; }

    }
}