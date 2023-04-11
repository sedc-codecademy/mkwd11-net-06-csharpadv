﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedLINQ.Domain.Models
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public abstract void PrintInfo();
    }
}
