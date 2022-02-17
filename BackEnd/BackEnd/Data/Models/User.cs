using BackEnd.Data.Abstraction;
using BackEnd.Data.Enums;

namespace BackEnd.Data.Models
{
    public class User:BaseUserModel
    {
        public ICollection<Rating> Ratings { get; set; } = new HashSet<Rating>();
        public UserType Type { get; set; }
    }
}
