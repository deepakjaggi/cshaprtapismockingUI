using Microsoft.VisualBasic;
using System;
using System.Buffers.Text;
using System.Collections;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace ApiTests.Students
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
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