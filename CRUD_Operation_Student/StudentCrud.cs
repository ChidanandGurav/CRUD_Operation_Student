using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Operation_Student
{
    public class StudentCrud
    {
        private List<Student> students;

        public StudentCrud()
        {
            students = new List<Student>()
            {
                new Student {RollNo = 1, Name = "Akash" , Percentage = 80 , Result = "Pass"},
                new Student {RollNo = 2, Name = "Bhushan" , Percentage = 75 ,  Result = "Pass" }
            };
        }

        public List<Student> getStudents() // Student list 
        {
            return students;
        }

        public Student GetStudentById(int RollNo) // Find the Student
        {
            Student st = new Student();
            foreach(Student s in students)
            {
                if(s.RollNo == RollNo)
                {
                    st = s;
                    break;
                }
            }
            return st;
        }

        public void AddStudent(Student s) // Add Student
        {
            students.Add(s);
        }

        public void UpdateStudent(Student s)
        {
            foreach(Student item in students)
            {
                if(item.RollNo == s.RollNo)
                {
                    item.Name= s.Name;
                    item.Percentage = s.Percentage;
                    item.Result= s.Result;
                    break;
                }
            }

        }

        public void DeleteStudent(int RollNo)
        {
            foreach(Student item in students)
            {
                if(item.RollNo == RollNo)
                {
                    students.Remove(item);
                    break;
                }
            }
        }
    }
}
