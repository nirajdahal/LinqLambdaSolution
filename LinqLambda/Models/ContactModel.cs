using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace LinqLambda.Models
{
    public class ContactModel
    {
        public int Id { get; set; }

        public string  FirstName { get; set; }

        public string  LastName { get; set; }

        public List<int> Addresses { get; set; }
    }
}
