using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace _3._1._01.ValidateApplicationInput
{
    // Running manual validation
    public class MainListing3X3
    {
        public MainListing3X3()
        {
            var customer = CustomerCreate();
            var results = GenericValidator<Customer>.Validate(customer);
            
            var msg  = results.Count == 0 ? "Nenhum erro foi encontrado" : "Lista de Erros";
            Console.WriteLine(msg);

            foreach (var result in results)
            {
                
                Console.WriteLine(result.ErrorMessage.ToString());
            }

            

            Console.ReadKey();
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
                    //FirstName = "John",
                    //LastName = "Doe",
                    BillingAddress = address,
                    ShippingAddress = address
                };

                return customer;

            }

        }
    }

    public class GenericValidator<T>
    {
        public static IList<ValidationResult> Validate(T entity)
        {
            var results = new List<ValidationResult>();
            var context = new ValidationContext(entity, null, null);
            Validator.TryValidateObject(entity, context, results);
            return results;
        }


    }

}