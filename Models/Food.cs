using System.ComponentModel.DataAnnotations;

namespace FoodStore.Models
{
    public class Food
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}