namespace BackEnd.Services.Requests
{
    public class RegisterUserRequest
    {
        public string? FistName { get; set; }
        public string? LastName { get; set; }
        public int Age { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Country { get; set; }
        public string? Town { get; set; }
        public string? StreetName { get; set; }
        public string? StreetNumber { get; set; }
    }
}
