using BackEnd.Data.Abstraction;
using System.ComponentModel.DataAnnotations;

namespace BackEnd.Data.Models
{
    public class Dish : IDeletable
    {
        public Dish()
        {
            this.ChefDishes = new HashSet<ChefDish>();
        }
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        public bool isDeleted { get; set; }
        public DateTime? DeletedOn { get; set; }
        public ICollection<ChefDish> ChefDishes { get; set; }
    }
}
