using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountProgran
{
    public class Account
    {
         public string actype { get; set; }
        public List<Customer> customers = new List<Customer>();
    }

    public class Customer
    {
        public string custn { get; set; }
      
        public List <Loan> loans = new List<Loan>();  
    }
    public class Loan
    {
        public string lname { get; set; }  

    }
   
    public class Program
    {
        static void Main(string[] args)
        {
            List<Account> accounts = new List<Account>()
            {
                new Account
                {

                    actype = "Saving Account",
                    customers =
                    {
                        new Customer
                        {
                            custn = "Customer 1",
                            loans = { new Loan { lname = "Home Loan" },
                                     new Loan { lname = "Car Loan" } },
                        },

                        new Customer
                        {
                            custn = "Customer 2",
                            loans = { new Loan { lname = "Home Loan" } },
                        },
                    },
                },
                new Account
                {
                    actype = "Current Account",
                    customers =
                    {
                        new Customer
                        {
                            custn = "Customer 3", loans = { new Loan { lname = "Gold Loan" }, new Loan { lname = "Car Loan" } },
                        },

                    }
                }
            };
              Console.WriteLine("Account type");
            foreach (Account a in accounts)
            {
                Console.WriteLine($"{a.actype}");
                foreach (Customer c in a.customers)
                {
                    Console.WriteLine($"\t{c.custn}");
                    foreach (Loan l in c.loans)
                    {
                        Console.WriteLine($"\t\t{l.lname}");
                    }
                }
            }
        }
    }
            
            
           
}
                
            
            
    


                
    
                    
            

            
       
    


