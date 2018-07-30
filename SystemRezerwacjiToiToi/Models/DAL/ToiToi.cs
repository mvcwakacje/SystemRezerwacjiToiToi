using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SystemRezerwacjiToiToi.Models.DAL
{
    public class ToiToi
    {
        public int ID { get; set; }
        public bool HasDoors { get; set; }
        public bool IsFull { get; set; }
        public string Name { get; set; }

    }
}