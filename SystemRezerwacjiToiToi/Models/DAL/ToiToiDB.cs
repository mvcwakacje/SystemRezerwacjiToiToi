using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SystemRezerwacjiToiToi.Models.DAL
{
    public static class ToiToiDB
    {
        public static List<ToiToi> ToiTois = new List<ToiToi>()
        {
            new ToiToi()
            {
                ID = 1,
                HasDoors = true,
                IsFull = false,
                Name = "Mój ulubiony"
            },
             new ToiToi()
            {
                ID = 2,
                HasDoors = true,
                IsFull = false,
                Name = "Twój ulubiony"
            },
              new ToiToi()
            {
                ID = 3,
                HasDoors = false,
                IsFull = false,
                Name = "Jej ulubiony"
            }

    };
       
    }
}