﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI_Lab07.Models
{
    public class PatchViewModel
    {
        public String Op { get; set; }
        public String Path { get; set; }
        public String Value { get; set; }
    }
}
