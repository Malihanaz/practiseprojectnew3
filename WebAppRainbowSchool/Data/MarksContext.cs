using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAppRainbowSchoolDb.models;

namespace WebAppRainbowSchooldb.Data
{
    public class MarksContext : DbContext
    {
        public MarksContext (DbContextOptions<MarksContext> options)
            : base(options)
        {
        }

        public DbSet<WebAppRainbowSchoolDb.models.Mark> Mark { get; set; } = default!;
    }
}
