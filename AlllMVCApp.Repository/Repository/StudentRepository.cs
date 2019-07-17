using System;
using System.Collections.Generic;
using System.Data.Entity;
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
            int saved = db.SaveChanges();
            if (saved > 0)
            {
                return true;
            }

            return false;
        }

        public bool Delete(Student student)
        {
            Student aStudent = db.Students.FirstOrDefault(c => c.ID == student.ID);
            db.Students.Remove(aStudent);
            int saved = db.SaveChanges();
            if (saved > 0)
            {
                return true;
            }

            return false;
        }

        public bool Update(Student student)
        {
            Student aStudent = db.Students.FirstOrDefault(c => c.ID == student.ID);
            int saved = 0;
            if (aStudent != null)
            {
                aStudent.Name = student.Name;
                saved = db.SaveChanges();
            }
            
            if (saved > 0)
            {
                return true;
            }

            return false;
        }

        public Student GetByID(Student student)
        {
            Student aStudent = db.Students.FirstOrDefault(c => c.ID == student.ID);
            return aStudent;

        }

        public List<Student> GetAll(Student student)
        {
            return db.Students.ToList();
        }

    }
}
