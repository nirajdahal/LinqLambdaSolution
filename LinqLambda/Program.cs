using System;
using System.Linq;

namespace LinqLambda
{
    class Program
    {
        static void Main(string[] args)
        {

            //LambdaTests();
            LinqTests();
        }


        private static void LambdaTests()
        {
            var data = SimpleData.GetContactData();
            //var results = data.Where(x => x.Addresses.Count > 1);

            //foreach (var item in results)
            //{
            //    Console.WriteLine($"{item.FirstName}{item.LastName}");
            //}

            //var results = data.SelectMany(x => x.FirstName);

            //foreach (var item  in results)
            //{
            //    Console.WriteLine(item);
            //}

            //var results = data.Take(2);
            //foreach (var item in results)
            //{
            //    Console.WriteLine($"{item.FirstName}{item.LastName}");
            //}

            //var results = data.Skip(2).Take(1);
            //foreach (var item in results)
            //{
            //    Console.WriteLine($"{item.FirstName}{item.LastName}");
            //}

            //var results = data.OrderBy(x => x.FirstName);

            //foreach (var item in results)
            //{
            //    Console.WriteLine(item.FirstName); 
            //}

            //var result = data.Find(x => x.FirstName == "Niraj");
            //Console.WriteLine(result.FirstName);



        }

        private static void LinqTests()
        {
            var contacts = SimpleData.GetContactData();
            var addresses = SimpleData.GetAddressData();

            //var results = (from c in contacts
            //               where c.Addresses.Count > 1
            //               select c
            //               ) ;

            var results = (from c in contacts
                           join a in addresses
                           select c
                          );
        }
    }

    
}
