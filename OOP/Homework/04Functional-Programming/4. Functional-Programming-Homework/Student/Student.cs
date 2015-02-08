using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Student
    {
        private string firstName;
        private string lastName;
        private int age;
        private int facultyNumber;
        private string phone;
        private string email;
        private IList<int> marks;
        private int groupNumber;

        public string FirstName 
        {
            get
            {
                return this.firstName;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("invalid name");
                }
                this.firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("invalid name");
                }
                this.lastName = value;
            }
        }
        public int Age 
        { 
            get 
            { 
                return this.age; 
            } 
            set 
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Invalid Age");
                }
                this.age = value; 
            } 
        }
        public int FacultyNumber
        {
            get
            {
                return this.facultyNumber;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Invalid FacultyNumber");
                }
                this.facultyNumber = value;
            }
        }
        public string Phone { get; set; }
        public string Email { get; set; }
        public IList<int> Marks { get; set; }
        public int GroupNumber { get; set; }

        public Student(string firstName, string lastName, int age, int facultyNumber, string phone, string email, IList<int> marks, int groupNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.FacultyNumber = facultyNumber;
            this.Phone = phone;
            this.Email = email;
            this.Marks = marks;
            this.GroupNumber = groupNumber;
        }

        public override string ToString()
        {
            string marks = String.Join(", ", this.Marks);
            string result =
                String.Format("Student: {0} {1},\nAge: {2} \nFactualy number: {3}, \nPhone: {4}, \nEmail: {5}, \nMarks: ({6}), \nGroup number: {7}\n",
                this.FirstName, this.LastName, this.Age, this.FacultyNumber, this.Phone, this.Email,
                marks, this.GroupNumber);

            return result;
        }
    }
}   
    