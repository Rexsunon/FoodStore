using System.Collections.Generic;
using FoodStore.Models;
using FoodStore.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace FoodStore.Controllers
{
    [Route("api/foodstore")]
    [ApiController]
    public class FoodsController : ControllerBase
    {
        private readonly IFoodRepo _repository;

        public FoodsController(IFoodRepo repository)
        {
            _repository = repository;
        }

        // POST api/foods
        [HttpPost]
        public ActionResult<Food> AddFoods(Food food)
        {
            _repository.AddFoods(food);
            _repository.SaveChanges();

            return Ok(food);
        }

        // GET api/foods
        [HttpGet]
        public ActionResult<IEnumerable<Food>> GetAllFood()
        {
            var foodsItems = _repository.GetAllFood();

            return Ok(foodsItems);
        }
    }
}