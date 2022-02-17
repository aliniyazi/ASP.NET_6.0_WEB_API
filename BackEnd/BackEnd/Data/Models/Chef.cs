using BackEnd.Data.Abstraction;

namespace BackEnd.Data.Models
{
    public class Chef : BaseUserModel
    {
        public Chef()
        {
            this.Chefdishes = new HashSet<ChefDish>();
        }
        public int Rating { get; set; }
        public ChefExperienceLevel Level { get; set; }
        public ICollection<ChefDish> Chefdishes { get; set; }
    }
}
