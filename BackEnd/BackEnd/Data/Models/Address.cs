using BackEnd.Data.Abstraction;

namespace BackEnd.Data.Models
{
    public class Address :IDeletable
    {
        public int Id { get; set; }
        public string? Country { get; set; }
        public string? Town { get; set; }
        public string? StreetName { get; set; }
        public string? StreetNumber { get; set; }
        public bool isDeleted { get; set; }
        public DateTime DeletedOn { get; set; }
        public ICollection<Chef> Chefs { get; set; } = new HashSet<Chef>();
        public ICollection<User> Users { get; set; } = new HashSet<User>();
    }
}
