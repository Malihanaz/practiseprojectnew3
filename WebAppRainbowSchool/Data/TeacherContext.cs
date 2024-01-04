using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAppRainbowSchoolDb.models;

namespace WebAppRainbowSchooldb.Data
{
    public class TeacherContext : DbContext
    {
        public TeacherContext (DbContextOptions<TeacherContext> options)
            : base(options)
        {
        }

        public DbSet<WebAppRainbowSchoolDb.models.Teacher> Teacher { get; set; } = default!;
    }
}
