using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlllMVCApp.Models.Models;

namespace AlllMVCApp.DatabaseContext.DatabaseContext
{
    public class StudentDbContext:DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}
