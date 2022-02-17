using BackEnd.Data.Models;
using System.ComponentModel.DataAnnotations;

namespace BackEnd.Data.Abstraction
{
    public abstract class BaseUserModel : IDeletable
    {
        public int Id { get; set; }
        [Required]
        public string? FirstName { get; set; }
        [Required]
        public string? LastName { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public string? PhoneNumber { get; set; }
        [Required]
        public string? Email { get; set; }
        [Required]
        public DateTime RegisterDate { get; set; }
        public bool isDeleted { get; set; }
        public DateTime DeletedOn { get; set; }
        public int AddressId { get; set; }
        public Address? Address { get; set; }
    }
}
