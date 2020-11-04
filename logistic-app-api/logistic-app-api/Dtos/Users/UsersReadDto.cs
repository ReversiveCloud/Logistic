﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace logistic_app_api.Dtos.Users
{
    public class UsersReadDto
    {
        public enum Position
        {
            Admin,
            Driver
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public Position User_position { get; set; }
    }
}