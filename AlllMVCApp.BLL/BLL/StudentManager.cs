using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlllMVCApp.Repository.Repository;
using AlllMVCApp.Models.Models;

namespace AlllMVCApp.BLL.BLL
{
    public class StudentManager
    {
        StudentRepository _studentRepository = new StudentRepository();

        public bool Add(Student student)
        {
            return _studentRepository.Add(student);
        }

        public bool Delete(Student student)
        {
            return _studentRepository.Delete(student);
        }

        public bool Update(Student student)
        {
            return _studentRepository.Update(student);
        }

        public Student GetByID(Student student)
        {
            return _studentRepository.GetByID(student);
        }

        public List<Student> GetAll(Student student)
        {
            return _studentRepository.GetAll(student);
        }
    }
}
