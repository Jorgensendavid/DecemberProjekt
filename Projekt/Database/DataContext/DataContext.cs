﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database.Entities;

namespace Database
{
    public class DataContext: DbContext 
    {
      
        public DbSet<User> Users { get; set; }

    }
}
