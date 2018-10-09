using System;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace _3._1._01.ValidateApplicationInput
{
    public class MainListing3X1
    {

        //############ Lista de DataAnotations  #################
        //  DataTypeAttribute
        //  RangeAttribute
        //  RegularExpressionAttribute
        //  RequiredAttribute
        //  StringLengthAttribute
        //  CustomValidationAttribute
        //  MaxLengthAttribute
        //  MinLengthAttribute
        //  Customer and Address Classes
        //  TimestampAttribute
        //  ConcurrencyCheckAttribute
        //  CreditCardAttribute
        //  DisplayAttribute
        //  EmailAddressAttribute
        //  FileExtensionsAttribute
        //  StringLengthAttribute
        // ########## entre outras implementações ################
        
    }

    public class Customer
    {
        public int Id { get; set; }
            
        [Required, MaxLength(20)]
        public string FirstName { get; set; }
        [Required,MaxLength(20)]
        public string LastName { get; set; }
        [Required]    
        public Address ShippingAddress { get; set; }
        [Required]
        public Address BillingAddress { get; set; }

    }

    public class Address
    {
        public int Id { get; set; }
        [Required,MaxLength(20)]
        public string AddressLine1 { get; set; }
        [Required,MaxLength(20)]
        public string AddressLine2 { get; set; }
        [Required,MaxLength(20)]
        public string City { get; set; }
        [RegularExpression(@"^[1-9][0-9]{3}\s?[a-zA-Z]{2}$")]
        public string ZipCode { get; set; }
    }
}
