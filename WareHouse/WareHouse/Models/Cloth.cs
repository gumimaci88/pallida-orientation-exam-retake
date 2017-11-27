using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WareHouse.Models
{
    public class Cloth
    {
        public int Id { get; set; }
        public string ItemName { get; set; }
        public string Manufacturer { get; set; }
        public string Category { get; set; }
        public string Size { get; set; }
        public int UnitPrice { get; set; }
    }
}