using BackEnd.Data.Enums;
using BackEnd.Data.Models;
using BackEnd.Services.Requests;

namespace BackEnd.Services.Mappers
{
    public static class Mapper
    {
        public static User RegisterUserMapper(RegisterUserRequest registerUserRequest)
        {
            return new User
            {
                FirstName = registerUserRequest.FistName,
                LastName = registerUserRequest.LastName,
                Age = registerUserRequest.Age,
                PhoneNumber = registerUserRequest.PhoneNumber,
                Email = registerUserRequest.Email,
                Password = registerUserRequest.Password,
                Type = UserType.Classic,
                RegisterDate = DateTime.UtcNow,
                isDeleted = false,
                DeletedOn = null,
                Address = new Address
                {
                    Country = registerUserRequest.Country,
                    Town = registerUserRequest.Town,
                    StreetName = registerUserRequest.StreetName,
                    StreetNumber = registerUserRequest.StreetNumber,
                    isDeleted = false,
                    DeletedOn = null
                }


            };
        }
    }
}
