﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Routine.APi.Models
{
    //输出使用的Dto
    public class CompanyDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Introduction { get; set; }
    }
}
