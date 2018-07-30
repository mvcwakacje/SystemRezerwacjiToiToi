using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SystemRezerwacjiToiToi.Models.DTO
{
    public class ToiToiDTO
    {     
        public int ToiToiID { get; set; }
        public bool HasDoors { get; set; }
        public bool IsFull { get; set; }
        public string Name { get; set; }
        //public List<Customer>  Customers { get; set; }      
    }
}