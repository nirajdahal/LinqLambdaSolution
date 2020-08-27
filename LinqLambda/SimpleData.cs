using LinqLambda.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LinqLambda
{
    public static class SimpleData
    {

        public static List<ContactModel> GetContactData()
        {
            List<ContactModel> output = new List<ContactModel>
            {
                new ContactModel{Id =1, FirstName="Niraj", LastName="Dahal", Addresses = new List<int>{1,2}},
                new ContactModel{Id =1, FirstName="Tulsi", LastName="Prasad", Addresses = new List<int>{2}},
                new ContactModel{Id =1, FirstName="Saraswoti", LastName="Pokhrel", Addresses = new List<int>{1,3}},
                new ContactModel{Id =1, FirstName="Nirajala", LastName="Dahal", Addresses = new List<int>{3}}
            };

            return output;
        }

        public static List<AddressModel> GetAddressData()
        {
            List<AddressModel> output = new List<AddressModel>
            {
                new AddressModel{Id = 1,City="New York", Country = "USA"},
                new AddressModel{Id = 2,City="London", Country = "UK"},
                new AddressModel{Id = 3,City="Kathmandu", Country = "Nepal"},
            };
            return output;
        }
    }
}
