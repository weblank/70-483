using System;
using System.Data.Entity;

namespace _3._1._01.ValidateApplicationInput
{
    // O DbContext vem no namespace System.Data.Entity do Entity Framework
    // Saving a new customer to the database
    public class MainListing3X2 : DbContext
    {
        public IDbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasRequired(bm => bm.BillingAddress)
                .WithMany().WillCascadeOnDelete(false);
        }

        public Customer CustomerCreate()
        {
            using (var ctx = new MainListing3X2())
            {
                Address address = new Address
                {
                    AddressLine1 = "Somewhere 1",
                    AddressLine2 = "At some floor",
                    City = "SomeCity",
                    ZipCode = "1111AA"
                };

                Customer customer = new Customer
                {
                    FirstName = "John",
                    LastName = "Doe",
                    BillingAddress = address,
                    ShippingAddress = address
                };
                
                ctx.Customers.Add(customer);
                ctx.SaveChanges();

                Console.WriteLine("O cliente: " + customer.FirstName + " " + customer.LastName);
                Console.WriteLine("Salvo com sucesso!");
                Console.ReadKey();

                return customer;

            }

        }
    }


}