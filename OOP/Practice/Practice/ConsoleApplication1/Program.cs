using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Dog   
{
    private string name;
    private string breed;

    public Dog(string name = null, string breed = null)
    {
        this.Name = name;
        this.Breed = breed;
    }
    public string Name { get; set; }
    public string Breed{ get; set; }
    static void Main()  
    {
        Dog sharo = new Dog("sharo", "koker");
        sharo.breed = "nemska";
        sharo.PrintDog();
       
        
    }
    public void PrintDog() 
    {
        Console.WriteLine("{0} : {1}", name, breed);
    }

}

