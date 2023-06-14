using Microsoft.VisualBasic;
using System;
using System.Buffers.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace ApiTests.User
{
    public interface IStudentRepository
    {
        Student CreateStudent(Student student);
        void UpdateStudent(Student student);
        Student GetStudent(Student student);
    }
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
    public class StudentRepository : IStudentRepository
    {
        private Dictionary<int, Student> students;

        public StudentRepository()
        {
            students = new Dictionary<int, Student>();
        }        

        public virtual Student CreateStudent(Student student)
        {
            //unimplemented method, write mock
            return student;
        }

        public void UpdateStudent(Student student)
        {
            students[student.StudentId] = student;
        }

        public Student GetStudent(Student student)
        {
            return student;
        }

        private int GenerateUniqueId()
        {
            // Generate a unique ID using your preferred logic
            // This is just a simple example
            return students.Count + 1;
        }
    }

}


//public Student CreateStudent(string name, int age)
//{
//    int studentId = GenerateUniqueId();
//    var student = new Student
//    {
//        StudentId = studentId,
//        Name = name,
//        Age = age
//    };
//    students.Add(studentId, student);
//    return student;
//}