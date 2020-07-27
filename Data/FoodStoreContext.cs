using FoodStore.Models;
using Microsoft.EntityFrameworkCore;

namespace FoodStore.Data
{
    class FoodStoreContext : DbContext
    {
        public FoodStoreContext(DbContextOptions<FoodStoreContext> opt) : base(opt)
        {

        }

        public virtual DbSet<Food> Food { get; set; }
    }
}