using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAppRainbowSchoolDb.models;

namespace WebAppRainbowSchooldb.Data
{
    public class SubjectContext : DbContext
    {
        public SubjectContext (DbContextOptions<SubjectContext> options)
            : base(options)
        {
        }

        public DbSet<WebAppRainbowSchoolDb.models.Subject> Subject { get; set; } = default!;
    }
}
