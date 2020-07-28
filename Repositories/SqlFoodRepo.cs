using System;
using System.Collections.Generic;
using System.Linq;
using FoodStore.Data;
using FoodStore.Models;

namespace FoodStore.Repositories
{
    public class SqlFoodRepo : IFoodRepo
    {
        private readonly FoodStoreContext _constext;

        public SqlFoodRepo(FoodStoreContext context)
        {
            _constext = context;
        }

        public void AddFoods(Food food)
        {
            if (food == null)
            {
                throw new ArgumentNullException(nameof(food));
            }

            _constext.Food.Add(food);
        }

        public void DeleteFood(Food food)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Food> GetAllFood()
        {
            return _constext.Food.ToList();
        }

        public Food GetFood(int id)
        {
            throw new System.NotImplementedException();
        }

        public bool SaveChanges()
        {
            return (_constext.SaveChanges() >= 0);
        }

        public void UpdateFood(Food food)
        {
            throw new System.NotImplementedException();
        }
    }
}