using BackEnd.Data.Abstraction;
using System.ComponentModel.DataAnnotations;

namespace BackEnd.Data.Models
{
    public class ChefDish : IDeletable
    {
        public int ChefId { get; set; }
        public Chef? Chef { get; set; }
        public int DishId { get; set; }
        public Dish? Dish { get; set; }
        public bool isDeleted { get; set; }
        public DateTime? DeletedOn { get; set; }
        public ICollection<Rating> Rating { get; set; } = new HashSet<Rating>();
    }
}
