using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Operation_Student
{
    public class Program
    {
        static void Main(string[] args)
        {
            int No = 0;
            StudentCrud crud = new StudentCrud();

            do
            {
                Console.WriteLine("------------------------");
                Console.WriteLine("1.Student List");
                Console.WriteLine("2.Get Student By Id");
                Console.WriteLine("3.Add Student");
                Console.WriteLine("4.Update Student Details");
                Console.WriteLine("5.Remove Student");
                Console.WriteLine("Select Option");
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        List<Student> list = crud.getStudents();
                            Console.WriteLine("RollNo\t   Name\t   Percentage\t   Result\t");
                        foreach(Student std in list)
                        {
                            Console.WriteLine($"{std.RollNo}     {std.Name}   {std.Percentage}     {std.Result}");
                        }
                        break;

                    case 2:
                        Console.WriteLine("Enter Student RollNo");
                        int rn = Convert.ToInt32(Console.ReadLine());
                        Student s = crud.GetStudentById(rn);
                        Console.WriteLine("RollNo\t   Name\t   Percentage\t   Result\t");
                        Console.WriteLine($"{s.RollNo}     {s.Name}   {s.Percentage}     {s.Result}");
                        break;

                    case 3:
                        Student s1 = new Student();
                        Console.WriteLine("Enter RollNo");
                        s1.RollNo = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Name");
                        s1.Name = Console.ReadLine();
                        Console.WriteLine("Enter Percentage");
                        s1.Percentage = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Result");
                        s1.Result = Console.ReadLine();
                        crud.AddStudent(s1);
                        Console.WriteLine("Save Student");
                        break;

                    case 4:
                        Student s2 = new Student();
                        Console.WriteLine("Enter RollNo");
                        s2.RollNo = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Name");
                        s2.Name = Console.ReadLine();
                        Console.WriteLine("Enter Percentage");
                        s2.Percentage = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Result");
                        s2.Result = Console.ReadLine();
                        crud.UpdateStudent(s2);
                        Console.WriteLine("Update Student");
                        break;

                    case 5:
                        Console.WriteLine("Enter Roll_No");
                        int rn1 = Convert.ToInt32(Console.ReadLine());
                        crud.DeleteStudent(rn1);
                        Console.WriteLine("Deleted Student");
                        break;
                }

                Console.WriteLine("Press 1 for Continue");
                No = Convert.ToInt32(Console.ReadLine());
            }

            while (No == 1);
        }
    }
}
