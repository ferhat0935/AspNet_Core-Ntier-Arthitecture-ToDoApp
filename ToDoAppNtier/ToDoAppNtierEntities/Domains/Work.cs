﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoAppNtierEntities.Domains
{
    public class Work:BaseEntity
    {
       
        public string Definition { get; set; }
        public bool IsCompleted { get; set; }
    }
}
