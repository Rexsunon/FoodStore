using System.Collections.Generic;
using FoodStore.Models;

namespace FoodStore.Repositories
{
    public interface IFoodRepo
    {
        void AddFoods(Food food);

        Food GetFood(int id);

        IEnumerable<Food> GetAllFood();

        void UpdateFood(Food food);

        void DeleteFood(Food food);

        bool SaveChanges();
    }
}