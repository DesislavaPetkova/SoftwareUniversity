using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer
{
    public class Customer :ICloneable,IComparable<Customer>
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private long id;
        private string pernAddress;
        private string phone;
        private string email;
        private List<Payment> payment;
        private Customer customer1;

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public long Id { get; set; }
        public string PernAddress { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public List<Payment> Payment { get; set; }
        public CustomerType Customer1 { get; set; }

        public Customer(string firstName, string middleName, string lastName, long id, string pernAddress, string phone, string email, List<Payment> payment, CustomerType customer1)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.Id = id;
            this.PernAddress = pernAddress;
            this.Phone = phone;
            this.Email = email;
            this.Payment = payment;
            this.Customer1 = customer1;

        }

        public Customer()
        {
            // TODO: Complete member initialization
        }


        public override string ToString()
        {
            string payment = String.Join(")(", this.Payment);
            return string.Format("{0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}", this.FirstName, this.MiddleName, this.LastName, this.Id, this.PernAddress, this.Phone, this.Email, payment, this.Customer1);
        }
        public override bool Equals(object obj)
        {
            Customer client = obj as Customer;
            if (client == null)
            {
                return false;
            }
            if (!Object.Equals(this.FirstName, client.FirstName))
            {
                return false;
            }
            if (this.LastName != client.LastName)
            {
                return false;
            }
            return true;

        }
        public static bool operator ==(Customer student1,
                                  Customer student2)
        {
            return Customer.Equals(student1, student2);
        }
        public static bool operator !=(Customer student1,
                           Customer student2)
        {
            return !(Customer.Equals(student1, student2));
        }
        public override int GetHashCode()
        {
            return this.FirstName.GetHashCode() ^
                this.MiddleName.GetHashCode() ^
                this.LastName.GetHashCode() ^
                this.Id.GetHashCode() ^
                this.PernAddress.GetHashCode() ^
                this.Phone.GetHashCode() ^
                this.Email.GetHashCode() ^
                this.Payment.GetHashCode() ^
                this.Customer1.GetHashCode();
        }


        public object Clone()
        {
            return new Customer()
            {
               FirstName = this.FirstName,
               MiddleName =  this.MiddleName,
               LastName  = this.LastName ,
               Id = this.Id, 
               PernAddress = this.PernAddress,
               Phone = this.Phone,
               Email = this.Email,
               Payment = this.Payment,
               Customer1 = this.Customer1

            };
        }

        public int CompareTo(Customer other)
        {
            if (this.FirstName != other.FirstName)
            {
                return this.FirstName.CompareTo(other.FirstName);

            }
            return this.Id.CompareTo(other.Id);

        }

        
    }
}
