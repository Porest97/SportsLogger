﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SportsLogger.Models.DataModels
{
    public class Person :IdentityUser
    {
        //Person Personalia !
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Name")]
        public string FullName { get { return string.Format("{0} {1} ", FirstName, LastName); } }

        //CName = Contact Name with Phonenumbers attached !
        public string CName { get { return string.Format("{0} {1} ", FullName, Ssn); } }

        [Display(Name = "Streetaddress")]
        public string StreetAddress { get; set; }

        [Display(Name = "Postalcode")]
        [DataType(DataType.PostalCode)]
        public string ZipCode { get; set; }

        [Display(Name = "City")]
        public string City { get; set; }

        [Display(Name = "Country")]
        public string Country { get; set; }

        [Display(Name = "Address")]
        public string Address { get { return string.Format("{0} {1} {2}", StreetAddress, ZipCode, City); } }

        [Display(Name = "SSN")]
        public string Ssn { get; set; }

        [Display(Name = "Telefonnummer1")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber1 { get; set; }

        [Display(Name = "Telefonnummer2")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber2 { get; set; }

        [Display(Name = "Phone #")]
        public string PhoneNumbers { get { return string.Format("{0} {1} ", PhoneNumber1, PhoneNumber2); } }

        

        // Person Accounts !
        [Display(Name = "Swish #")]
        [DataType(DataType.PhoneNumber)]
        public string SwishNumber { get; set; }

        [Display(Name = "Bank #")]
        public string BankAccount { get; set; }

        [Display(Name = "Bank")]
        public string BankName { get; set; }

        [Display(Name = "Swish# and Bank#")]
        public string PaymentDetails { get { return string.Format("{0} {1}", SwishNumber, BankAccount); } }

    }
}
