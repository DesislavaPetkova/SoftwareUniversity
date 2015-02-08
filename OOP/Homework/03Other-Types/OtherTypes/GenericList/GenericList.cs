using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    [Version (3,4)]
   public class GenericList<T> where T : IComparable<T>
    {
       const int DefaultCapacity = 16;
       private T[] elements;
       private int count = 0;
       private int capacity;

       public GenericList(int capacity = DefaultCapacity)
       {
           elements = new T[capacity];
           this.Capacity = capacity;
           
       }

       public T[] Elements
       {
           get
           {
               return this.elements;
           }

           protected set
           {
               if (null == value)
               {
                   throw new ArgumentNullException("Inner", "Inner array can not be null!");
               }

               this.elements = value;
           }
       }
       public int Capacity { 
           get 
           { 
               return this.capacity;
           }
           set
           {
               this.capacity = value;
           }

       }
       public int Count { get { return this.count; } }

       public void Add(T element)
       {
           if (this.Count >= elements.Length)    
           {
               GrowFunction();
           }
           this.elements[count] = element;
           count++;
       }
       public T this[int index]
       {
           get
           {
               if (index < 0 || index >= count)
               {
                   throw new IndexOutOfRangeException(String.Format(
                       "Invalid index: {0}.", index));
               }
               T result = elements[index];
               return result;
           }

       }
       public void Remove(int index)
       {
           if (index >= count || index < 0)
           {
               throw new ArgumentOutOfRangeException("Invalid index");
           }
           for (int i = index; i < elements.Length-1; i++)
           {
               elements[i] = elements[i + 1];
           }
           
           count--;
       }
       public void Insert(T element, int index)
       {           
           if (index < 0)
           {
               throw new IndexOutOfRangeException(String.Format("The list capacity of {0} was exceeded.", elements.Length));
           }
           if (this.Count>= this.Elements.Length)
           {
               GrowFunction();
           }
           T temp;
           T temp2;
           temp = elements[index];
           elements[index] = element;
           for (int i = index+1; i < elements.Length-1; i++)
           {
               temp2 = elements[i];
               elements[i] = temp;
               temp = temp2;

           }
           count++;
       }
       public void ClearAll()
       {
           for (int i = 0; i < elements.Length; i++)
           {
               elements[i] = default(T);
           }
       }
       public void Find(T element)
       {
          
           for (int i = 0; i < elements.Length; i++)
           {
               if (elements[i].Equals(element))
               {
                   Console.WriteLine(i);
                   return;
               }
               
           }
           Console.WriteLine("There is no such value in this LIST");
           return;
       }
       public void Contain(T element)
       {
           for (int i = 0; i < elements.Length; i++)
           {
               if (elements[i].Equals(element))
               {
                   Console.WriteLine("The list contains your value");
                   return;
               }
           }
           Console.WriteLine("The list doesnt contain your value");
           return;
       }
       public override string ToString()
       {
           StringBuilder result = new StringBuilder();
           for (int i = 0; i < this.Count; i++)
           {
               result.Append(this.Elements[i]+ " ");
           }
           return result.ToString();
       }
       public void GrowFunction()
       {
           
           T[] dobleArr = new T[this.Capacity*2];           
           Array.Copy(this.Elements, dobleArr, this.Capacity);
           this.Elements = dobleArr;
       }
       public T Max()    
       {
           return this.Elements.Max();           
       }
       public T Min()
       {
           
           return this.Elements.Min();
       }

    }

}
    