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
        
        public List<Cloth> FilterLower(double price)
        {
            return ClothContext.Clothes.Where(c => c.UnitPrice < price).ToList();
        }

        public List<Cloth> FilterEqual( int price)
        {
            return ClothContext.Clothes.Where(c => c.UnitPrice.Equals(price)).ToList();

        }

        public List<Cloth> FilterHigher(int price)
        {
            return ClothContext.Clothes.Where(c => c.UnitPrice > price).ToList();

        }
    }
}