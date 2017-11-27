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

        public List<Cloth> Filters(string name)
        {
            return ClothContext.Clothes.Where(c => c.ItemName.Contains(name)).ToList();
        }

        public List<Cloth> FilterSize(string size)
        {
            return ClothContext.Clothes.Where(c => c.Size.Contains(size)).ToList();
        }

        public List<Cloth> FilterSummary ()
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