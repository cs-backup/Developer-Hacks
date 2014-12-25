using System;
using System.Runtime.Remoting;

namespace SOLID.Classes
{
    //HACK Question: Consider classes below, what's the problem and violating which SOLID principle? How to refactor it?
    public class CustomerRuleValidator
    {

        public bool IsSpecialCustomer(Customer c)
        {
            if (c.Country == "US" && c.Balance < 50) return false;
            if (c.Country == "UK" && c.Balance < 25) return false;
            if (c.Country == "MY" && c.Balance < 30) return false;
            if (c.Country == "SG" && c.Balance < 100) return false;

            if (c.Age < 18 || c.Age > 65) return false;

            if (c.Income < 50000 && c.Age < 30) return false;

            return true;
        }
    }

    public class Customer
    {
        public int Age { get; set; }
        public string Country { get; set; }
        public decimal Balance { get; set; }
        public decimal Income { get; set; }
    }
}
