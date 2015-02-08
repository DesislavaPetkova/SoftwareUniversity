using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    static class TestingStudent
    {
        public static bool enrolled2014(this Student str, int number)
        {
            if ((number.ToString().IndexOf('1', 4) != -1) && (number.ToString().IndexOf('4', 5) != -1))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        static void Main()
        {
            Student pesho =
                    new Student("Petar", "Peshev", 23, 10110000, "02/943-48-06",
                        "pesho_picha@abv.bg", new List<int>() { 2, 5, 5, 6, 6, 6, 6 }, 2);
            Student gosho =
                new Student("Georgi", "Goshev", 19, 13111495, "+359887894568",
                    "gosho.goshev@gmail.com", new List<int>() { 2, 2, 2, 2, 2, 3, 4 }, 1);
            Student stoqn =
                new Student("Stoqn", "Stoqnev", 56, 10111234, "+359279542357",
                    "stoqncho@abv.bg", new List<int>() { 6, 6, 6, 6, 6, 6, 6 }, 3);
            Student angel =
                new Student("Acho", "Stoqnov", 20, 12119874, "+359987456987",
                    "achkata@abv.bg", new List<int>() { 6, 6, 4, 6, 4, 2, 3 }, 2);

            Student angelA =
                new Student("Acho", "Angelov", 18, 14124568, "+359789654123",
                    "angelcho@gmail.com", new List<int>() { 5, 2, 4, 6, 4, 2, 3 }, 1);

            List<Student> students = new List<Student>();
            students.Add(pesho);
            students.Add(stoqn);
            students.Add(gosho);
            students.Add(angel);
            students.Add(angelA);
            
            var byGroup = from student in students  
                          where student.GroupNumber == 2 
                          orderby student.FirstName
                          select student;
            Console.WriteLine("_04_Student by Group: \n");
            foreach (var item in byGroup)
            {
                Console.WriteLine(item);
            }

            var byFirstAndLastName = from student in students
                                     orderby student.FirstName, student.LastName
                                     select student;

            Console.WriteLine(" Problem 5.	Students by First and Last Name \n");
            foreach (var item in byFirstAndLastName)
            {
                Console.WriteLine(item);
            }

            var studentsByAge = from student in students
                                where student.Age >= 18 && student.Age <= 24
                                select new { student.FirstName, student.LastName, student.Age };

            Console.WriteLine("Problem 6.	Students by Age");
            foreach (var item in studentsByAge)
            {
                Console.WriteLine("{0} {1} {2}",item.FirstName, item.LastName, item.Age);
            }


            var sortStudents = students.OrderByDescending(student => student.FirstName).ThenByDescending(student => student.LastName).Select(student => student);

            Console.WriteLine("Problem 7.	Sort Students \n");
            foreach (var item in sortStudents)
            {
                Console.WriteLine("{0} {1}", item.FirstName, item.LastName);
            }

            var filterByEmailDomain = students.Where(student => student.Email.Contains("@abv.bg")).Select(student => student);
            Console.WriteLine("Problem 8.	Filter Students by Email Domain");
            foreach (var item in filterByEmailDomain)
            {
                Console.WriteLine(item);
            }

            var phoneFromSofia = students.Where(student => student.Phone.StartsWith("02") || student.Phone.StartsWith("+3592") || student.Phone.StartsWith("++359 2")).Select(student => student);

            Console.WriteLine("Problem 9.	Filter Students by Phone");

            foreach (var item in phoneFromSofia)
            {
                Console.WriteLine(item);
            }

            var excellentStudents = students.Where(student => student.Marks.Contains(6)).Select(student => new { student.FirstName, student.LastName, student.Marks });

            Console.WriteLine("Problem 10.	Excellent Students");

            foreach (var item in excellentStudents)
            {
                string Marks = string.Join(", ", item.Marks);
                Console.WriteLine(item.FirstName + " "+ item.LastName + " || Marks: " + Marks);
            }
            Console.WriteLine();
            var badStudents = from student in students
                              where student.Marks.Where(s => (s == 2)).Count() == 2
                              select student;

            Console.WriteLine("Problem 11.	Weak Students");

            foreach (var item in badStudents)
            {
                string Marks = string.Join(", ", item.Marks);
                Console.WriteLine(item.FirstName + " " + item.LastName + " || Marks: " + Marks);
            }

            

            var studentsEnrolled = students.Where(student => student.enrolled2014(student.FacultyNumber) == true).Select(student => student);
            Console.WriteLine();
            Console.WriteLine("Problem 12.	Students Enrolled in 2014");

            foreach (var item in studentsEnrolled)
            {
                Console.WriteLine(item);
            }
        }
    }
}
