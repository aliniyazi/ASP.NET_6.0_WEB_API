namespace BackEnd.Data.Abstraction
{
    public interface IDeletable
    {
        bool isDeleted { get; set; }
        DateTime DeletedOn { get; set; }
    }
}
