namespace ApiTests.Students
{
    public interface IStudent
    {
        Student CreateStudent(Student student);
        void UpdateStudent(Student student);
        Student GetStudent(Student student);
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