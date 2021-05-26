﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantAPI.Models
{
    public class CreateRestaurantDto
    {
        [Required]
        [MaxLength(25)]
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public Boolean HasDelivery { get; set; }
        public string ContactEmail { get; set; }
        public string ContactNumber { get; set; }
        [Required]
        [MaxLength(15)]
        public string City { get; set; }
        [Required]
        [MaxLength(30)]
        public string Street { get; set; }
        public string PostalCode { get; set; }
    }
}
