using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Student_Class
{
    public class Student
    {

        public delegate void PropertyChanged(object sender, PropertyChanged eventArgs);
        private string name;
        private int age;
        private PropertyChanged changedArgs;

        public event PropertyChanged PropertyChangedd;

        public Student(string name, int age)
        {

            this.Name = name;
            this.Age = age;
        }

        public string Name { get; set; }
        public int Age { get; set; }

        protected virtual void OnPropertyChanged(object sender, PropertyChanged changedArgs)
        {
           
            if (PropertyChangedd != null)
            {
                
                PropertyChangedd(this, changedArgs);
            }
        }

        
    }
}
