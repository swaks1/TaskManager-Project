﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagerProject.Domain.Entities
{
    public class Customer : BaseEntity
    {
        public string Name { get; set; }

        public string Company { get; set; }

        public string Email { get; set; }

        public virtual ICollection<Project> Projects { get; set; }
    }
}
