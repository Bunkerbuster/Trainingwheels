﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Commander_Core_3._1_MVC_Rest_Api.Models
{
    public class Command
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(256)]
        public string  HowTo { get; set; }
        [Required]
        public string  Line { get; set; }
        [Required]
        public string  Platform { get; set; }
    }
}
