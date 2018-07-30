using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SystemRezerwacjiToiToi.Models.DAL
{
    public static class CustomerDAL
    {
        public static List<Customer> toiTois = new List<Customer>()
        {
            new Customer()
            {
                ID = 1,               
                Name = "Roman",
                LastName = "Jeżyk"
            },
             new Customer()
            {
                ID = 2,
                Name = "Lukasza",
                LastName = "Kowalski"
            },
              new Customer()
            {
                ID = 3,
                Name = "Alicja",
                LastName = "Jeżykowa"
            }

    };
       
    }
}