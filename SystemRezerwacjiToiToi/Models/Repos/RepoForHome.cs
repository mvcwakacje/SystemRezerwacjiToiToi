using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SystemRezerwacjiToiToi.Models.DAL;
using SystemRezerwacjiToiToi.Models.DTO;

namespace SystemRezerwacjiToiToi.Models.Repos
{
    public class RepoForHome
    {
        public ToiToiDTO GetOne(int id)
        {
            var result = new ToiToiDTO();
            var x = ToiToiDB.ToiTois;
            result.Name = x[id].Name;
            result.IsFull = x[id].IsFull;
            result.ToiToiID = x[id].ID;
            result.HasDoors = x[id].HasDoors;
            return result;
        }
        public List<ToiToiDTO> GetAll()
        {
            var result = new List<ToiToiDTO>();
            foreach (var item in ToiToiDB.ToiTois)
            {
                result.Add(new ToiToiDTO()
                {
                    ToiToiID = item.ID,
                    HasDoors = item.HasDoors,
                    IsFull = item.IsFull,
                    Name = item.Name
                });
            }

            return result;
        }
    }
}