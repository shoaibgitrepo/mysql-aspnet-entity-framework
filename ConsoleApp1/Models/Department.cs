﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

    }
}
