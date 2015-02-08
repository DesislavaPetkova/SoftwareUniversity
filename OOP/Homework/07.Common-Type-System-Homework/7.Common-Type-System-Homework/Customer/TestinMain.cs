using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer
{
    class TestinMain
    {
        private static void Main()
        {
            List<Payment> pays = new List<Payment>();
            Payment loan = new Payment("mortgage", 250);
            Payment rent = new Payment("rent", 350);
            pays.Add(loan);
            pays.Add(rent);
            Customer joro = new Customer("Petar", "Ivanov", "Georgiev", 8902021001, "Varna, Gen. Kolev 24", "1232143243", "qwew@abv.bg", pays, CustomerType.Regular);

            Console.WriteLine(joro);
            Object stamat = joro.Clone();
            joro.FirstName = "Aleksandur";
            Console.WriteLine();
            Console.WriteLine(joro);
            Console.WriteLine(joro.ToString());

            Payment payment = new Payment("Dell", 600);
            Payment payment2 = new Payment("Dell", 600);

            Customer gosho = new Customer("Gosho", "Goshev", "Goshev", 6212123344, "jivee nablizo", "0887 888888", "gosho@abv.bg", pays, CustomerType.Diamond);
            Customer pesho = new Customer("Gosho", "Goshev", "Goshev", 6212123344, "jivee nablizo", "0887 888888", "gosho@abv.bg", pays, CustomerType.Diamond);
            Customer peshoPeshev = new Customer("Pesho", "Peshev", "Peshev", 311214244, "jivee nqkyde", "0887 823888", "pesho@abv.bg", pays, CustomerType.Golden);

            Console.WriteLine("Are gosho and pesho equal: {0}", Equals(gosho, pesho));
            Console.WriteLine("Are pesho and pesho peshev equal: {0}", Equals(pesho, peshoPeshev));
            Console.WriteLine("Are gosho and pesho equal using '==': {0}", (gosho == pesho));
            Console.WriteLine(gosho);
            Console.WriteLine("Pesho Peshev HashCode is: {0}", peshoPeshev.GetHashCode());

            var nasko = (Customer)peshoPeshev.Clone();
            nasko.FirstName = "Nasko";
            nasko.MiddleName = "Atanasov";
            nasko.LastName = "Naskov";
            Console.WriteLine();
            Console.WriteLine("Original after cloning: {0}", peshoPeshev);
            Console.WriteLine();
            Console.WriteLine("Clone: {0}", nasko);

            var atanas = (Customer)nasko.Clone();
            atanas.Id = 411214244;
            Customer[] customers = { gosho, atanas, nasko, peshoPeshev };
            Array.Sort(customers);
            Console.WriteLine();
            Console.WriteLine("Sorted customers(first name, egn):");
            foreach (var customer in customers)
            {
                Console.WriteLine(customer.FirstName + " " + customer.LastName + " " + customer.Id);
            }
        }
    }
}
