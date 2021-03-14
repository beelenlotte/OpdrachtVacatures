﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpdrachtVacatures.DTO
{
    public class JobDTO
    {
        public int CompanyId { get; set; }
        public string JobTitle { get; set; }
        public string Description { get; set; }
        public double Salary { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
