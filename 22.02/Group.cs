using System;
namespace _22._02
{
    public class Group:Student
    {
        public string No;
        public  int Limit;
        public string Student;

        public string[] Students = new Student
        public Group(string no, int limit, string student, string name, string surname):base()
        {
            No = no;
            Limit = limit;
            Student = student;
        }
        public string FullName()
        {
            return $"Name:{Name},Surname:{Surname}";
        }

       


        public void AddStudent(string student)
        {
           
        }
        public void Getstudent(string student)
        {
            
        }
    }
}
