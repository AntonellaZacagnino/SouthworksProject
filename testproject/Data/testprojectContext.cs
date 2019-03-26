using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using testproject;

namespace testproject.Models
{
    public class testprojectContext : DbContext
    {
        public testprojectContext (DbContextOptions<testprojectContext> options)
            : base(options)
        {
        }

        public DbSet<testproject.Patient> Patient { get; set; }
    }
}
