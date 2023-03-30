using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OnlineResume.Models;

namespace OnlineResume.Data
{
    public class OnlineResumeContext : DbContext
    {
        public OnlineResumeContext (DbContextOptions<OnlineResumeContext> options)
            : base(options)
        {
        }

        public DbSet<OnlineResume.Models.ProjectModel> ProjectModel { get; set; } = default!;
    }
}
