using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Student_Class
{
    class TestingMain
    {
        static void Main()
        {
            
            var firstStudent = new Student("Grozio", 38);
            var secondStudent = new Student("Grozdanka", 33);

            
            firstStudent.PropertyChangedd += (sender, eventArgs) =>
                Console.WriteLine("Property  cnaged: {0} (from {1} to {2})",
                eventArgs.Property, eventArgs.OldValue, eventArgs.NewValue);

            secondStudent.PropertyChangedd += (sender, eventArgs) =>
                Console.WriteLine("Property  cnaged: {0} (from {1} to {2})",
                eventArgs.Property, eventArgs.OldValue, eventArgs.NewValue);

            
            firstStudent.Name = ("Pesho Manekena");
            firstStudent.Age = 25;

            secondStudent.Name = ("Mara Obshtata");
            secondStudent.Age = 20;

            firstStudent.Name = ("Bai Pesho");
            firstStudent.Age = 48;

            secondStudent.Name = ("Tetka Mara");
            secondStudent.Age = 43;
        }
    }
}
