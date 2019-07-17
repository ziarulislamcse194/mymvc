using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlllMVCApp.Models.Models;
using AlllMVCApp.DatabaseContext.DatabaseContext;


namespace AlllMVCApp.Repository.Repository
{
    public class StudentRepository
    {
        StudentDbContext db = new StudentDbContext();

        public bool Add(Student student)
        {
            db.Students.Add(student);
            db.SaveChanges();

            return false;
        }
    }
}
