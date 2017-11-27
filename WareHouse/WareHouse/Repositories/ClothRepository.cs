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
        //public List<Cloth> FilterCars(string q)
        //{
        //    return CarContext.Cars.Where(c => c.Plate.Contains(q)).ToList();
        //}

        //public List<Car> FilterPolice()
        //{
        //    return CarContext.Cars.Where(c => c.Plate.StartsWith("RB")).ToList();
        //}

        //public List<Car> FilterDiplomat()
        //{
        //    return CarContext.Cars.Where(c => c.Plate.StartsWith("DT")).ToList();
        //}

        //public List<Car> FilterBrand(string brand)
        //{
        //    return CarContext.Cars.Where(c => c.CarBrand.Equals(brand)).ToList();
        //}
    }
}