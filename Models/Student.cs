﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppAssesment.Models
{
    public class Student
    {
        public int SId { get; set; }
        public string SName { get; set; }
        public DateTime SDOB { get; set; }
        public string SContact { get; set; }
    }
}