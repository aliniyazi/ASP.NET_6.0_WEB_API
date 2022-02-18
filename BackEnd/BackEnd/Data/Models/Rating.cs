using BackEnd.Data.Abstraction;
using System.ComponentModel.DataAnnotations;

namespace BackEnd.Data.Models
{
    public class Rating : IDeletable
    {
        [Key]
        public int Id { get; set; }
        public int Score { get; set; }
        public ChefDish? ChefDish { get; set; }
        public int ChefId { get; set; }
        public int DishId { get; set; }
        public User? User { get; set; }
        public int UserId { get; set; }
        public bool isDeleted { get; set; }
        public DateTime? DeletedOn { get; set; }
    }
}
