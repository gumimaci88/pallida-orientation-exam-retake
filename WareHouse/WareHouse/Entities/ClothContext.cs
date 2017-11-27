using Microsoft.EntityFrameworkCore;
using WareHouse.Models;

namespace WareHouse.Entities
{
    public class ClothContext : DbContext
    {
        public ClothContext(DbContextOptions<ClothContext> options) : base(options)
        {

        }

        public DbSet<Cloth> Clothes { get; set; }
    }
}