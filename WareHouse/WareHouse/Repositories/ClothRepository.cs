using System;
using System.Collections.Generic;
using System.Linq;
using WareHouse.Models;
using WareHouse.Entities;

namespace WareHouse.Repositories
{
    public class ClothRepository
    {
        private ClothContext ClothContext;

        public ClothRepository(ClothContext clothContext)
        {
            ClothContext = clothContext;
        }
        public List<Cloth> GetList()
        {
            return ClothContext.Clothes.ToList();
        }
        
        public List<Cloth> FilterAmmount(int ammount)
        {
            return ClothContext.Clothes.Where(c => c.UnitPrice.Equals(ammount)).ToList();
        }
    }
}