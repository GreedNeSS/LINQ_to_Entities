﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model_LevelQueryFilters.Models
{
    public class User
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }
        public int RoleId { get; set; }
        public Role? Role { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Age: {Age}, Role: {Role!.Name}";
        }
    }
}
