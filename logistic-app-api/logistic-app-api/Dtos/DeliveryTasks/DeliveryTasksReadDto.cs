﻿using logistic_app_api.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace logistic_app_api.Dtos.DeliveryTasks
{
    public class DeliveryTasksReadDto
    {
        [Key]
        public int Id { get; set; }
        public User Driver { get; set; }
        public Car Car { get; set; }
        public Trailer Trailer { get; set; }
        public Destination From { get; set; }
        public Destination To { get; set; }
        public double Weight { get; set; }
        public string ContainerNumber { get; set; }
        public Client Client { get; set; }
        public Declarant Declarant { get; set; }
        public Customs Customs { get; set; }
        public BorderCrossing BorderCrossing { get; set; }
    }
}
