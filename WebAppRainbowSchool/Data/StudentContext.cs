﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAppRainbowSchoolDb.models;

namespace WebAppRainbowSchooldb.Data
{
    public class StudentContext : DbContext
    {
        public StudentContext (DbContextOptions<StudentContext> options)
            : base(options)
        {
        }

        public DbSet<WebAppRainbowSchoolDb.models.Student> Student { get; set; } = default!;
    }
}
