﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace logistic_app_api.Dtos.Clients
{
    public class ClientsReadDto
    {
        [Key]
        public int Id { get; set; }
        public string Info { get; set; }
    }
}
