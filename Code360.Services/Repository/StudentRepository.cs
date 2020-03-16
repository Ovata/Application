using Code360.Data;
using Code360.Entities;
using Code360.Services.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Code360.Services.Repository
{
    public class StudentRepository : IStudentRepository
    {
        public StudentRepository(Code360DBContext code360DBContext)
        {

        }
        public Student AddStudent(Student student)
        {
            throw new NotImplementedException();
        }
    }
}
