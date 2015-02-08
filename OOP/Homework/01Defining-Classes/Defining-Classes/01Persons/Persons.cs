using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Person
{
    private string name;
    private int age;
    private string email;
    
    public string Name { 
        get
        {
            return this.name;
        }
        set 
        {
            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Invalid name");
            }
            this.name = value;
        } 
    }
    public int Age {
        get
        {
            return this.age;
        }
        set 
        {
            if(value < 1 || value > 100)
            {
                throw new ArgumentOutOfRangeException("Invalid age");
            }
            this.age = value;
        } 
    }
    public string Email { 
        get
        {            
            return this.email;
        }

        set
        { 
            if (null!=value && !value.Contains("@"))
            {
                throw new ArgumentException("Invalid email ALOOOO");
                
            }
            this.email = value;
            
        }
    }

    public Person(string name, int age, string email)
    {
        this.Name = name;
        this.Age = age;
        this.Email = email;

    }
    public Person(string name, int age) : this(name, age, null) { }

    public override string ToString()
    {
        return this.name + " "+ this.age +" " + this.email;
    }
    static void Main()
    {
        Person Ivan = new Person("Ivan", 23, "asdasd@abv.bg");
        Console.WriteLine(Ivan.ToString());
    }
}

