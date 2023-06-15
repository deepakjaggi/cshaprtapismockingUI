using System.Collections.Generic;

namespace ApiTests.Students
{
    public class StudentRepository : IStudent
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